using Microsoft.AspNet.Identity.Owin;
using Microsoft.CSharp;
using Microsoft.Owin;
using System;
using System.CodeDom.Compiler;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TP.AspNet.Identity.EntityFramework;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Utility.Interfaces;

namespace TP.Repository.Utility.Services
{
    public class WorkflowRepository<TApplication, TWorkflowLog> : IWorkflowRepository<TApplication, TWorkflowLog>
        where TApplication : ApplicationBase
        where TWorkflowLog : EntityBaseOfLong, IWorkflowLog, ITraceable, new()
    {
        private readonly IRepositoryOfLong<TApplication> _applicationRepository;
        private readonly IRepositoryOfLong<Workflow> _workflowRepository;
        private readonly IRepositoryOfLong<BasicWorkflowState> _basicStateRepository;
        private readonly IRepositoryOfLong<SequentialWorkflowStateSetting> _seqSettingRepository;
        private readonly IRepositoryOfLong<WorkflowInstance> _instanceRepository;
        private readonly IRepositoryOfLong<TWorkflowLog> _logRepository;
        
        private readonly INumberRepository _numberRepository;
        private readonly IUserRepository _userRepository;

        public WorkflowRepository(IUserRepository userRepository, INumberRepository numberRepository, IRepositoryOfLong<TApplication> applicationRepository, IRepositoryOfLong<Workflow> workflowRepository, IRepositoryOfLong<BasicWorkflowState> basicStateRepository
            , IRepositoryOfLong<SequentialWorkflowStateSetting> seqSettingRepository, IRepositoryOfLong<WorkflowInstance> instanceRepository, IRepositoryOfLong<TWorkflowLog> logRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _numberRepository = numberRepository ?? throw new ArgumentNullException(nameof(numberRepository));

            _applicationRepository = applicationRepository ?? throw new ArgumentException(nameof(applicationRepository));
            _workflowRepository = workflowRepository ?? throw new ArgumentNullException(nameof(workflowRepository));
            _basicStateRepository = basicStateRepository ?? throw new ArgumentNullException(nameof(basicStateRepository));
            _seqSettingRepository = seqSettingRepository ?? throw new ArgumentNullException(nameof(seqSettingRepository));
            _instanceRepository = instanceRepository ?? throw new ArgumentNullException(nameof(instanceRepository));
            _logRepository = logRepository ?? throw new ArgumentNullException(nameof(logRepository));
        }
        
        public async Task<bool> SubmitAsync(TApplication application)
        {
            var workflow = this.FindWorkflowByName();

            var originId = workflow.InitialStateId; long? destinagionId = workflow.InitialStateId;

            if (destinagionId <= 0 || workflow.InitialState.Type != WorkflowStateType.Sequential)
                throw new InvalidOperationException("初始流程設置錯誤，請聯繫系統管理員獲取更多信息！");

            var applicant = await _userRepository.GetProfileById(application.ApplicantId);

            application.Number = await _numberRepository.GenerateAsync(typeof(TApplication).FullName, applicant.SubsidiaryId);

            var instance = await UpdateInstanceAsync(new WorkflowInstance()
            {
                WorkflowId = workflow.Id,
                ApplicantId = applicant.Id,
                CreatorId = applicant.Id,
                CreateDate = DateTime.Now,
                ModificatorId = applicant.Id,
                ModifyDate = DateTime.Now
            }, workflow.InitialState);

            application.InstanceId = instance.Id;
            application.Status = !instance.StateId.HasValue ? ApplicationStatus.Completed : ApplicationStatus.Submitted;

            application.CreatorId = applicant.Id;
            application.CreateDate = DateTime.Now;
            application.ModificatorId = applicant.Id;
            application.ModifyDate = DateTime.Now;

            await this.InsertLogAsync(instance.Id, originId, instance.StateId, applicant.Id, null, ActionStatus.Submitted, string.Empty);

            await _applicationRepository.InsertAsync(application);

            return await Task.FromResult(true);
        }

        public async Task<bool> ExecuteAsync(string number, string checkerId, string comment)
        {
            var application = await this.FindApplicationByNumberAsync(number);

            if (application == null)
                throw new InvalidOperationException("審批時發生錯誤，請聯繫系統管理員獲取更多信息！");

            var canApprove = await this.CanApproveAsync(application.WorkflowInstance, application.Status, checkerId);

            if (!canApprove) return await Task.FromResult(false);

            long instanceId = application.InstanceId.Value;
            long originId = application.WorkflowInstance.StateId.Value;
            string instanceCheckerId = application.WorkflowInstance.CheckerId;
            string agentId = canApprove && !instanceCheckerId.Equals(checkerId) ? checkerId : string.Empty;

            var instance = await this.UpdateInstanceAsync(application.WorkflowInstance, application.WorkflowInstance.State);

            await this.InsertLogAsync(instanceId, originId, null, instanceCheckerId, agentId, ActionStatus.Approved, comment);

            var status = instance.StateId.HasValue ? ApplicationStatus.Submitted : ApplicationStatus.Completed;

            await this.UpdateApplicationAsync(application, checkerId, status);

            return await Task.FromResult(true);
        }

        public async Task<bool> RejectAsync(string number, string checkerId, string comment)
        {
            var application = await this.FindApplicationByNumberAsync(number);

            if (application == null)
                throw new InvalidOperationException("審批時發生錯誤，請聯繫系統管理員獲取更多信息！");

            var canApprove = await this.CanApproveAsync(application.WorkflowInstance, application.Status, checkerId);

            if (!canApprove) return await Task.FromResult(false);

            long instanceId = application.InstanceId.Value;
            long originId = application.WorkflowInstance.StateId.Value;
            string instanceCheckerId = application.WorkflowInstance.CheckerId;
            string agentId = canApprove && !instanceCheckerId.Equals(checkerId) ? checkerId : string.Empty;

            await this.UpdateInstanceAsync(application.WorkflowInstance, null);

            await this.InsertLogAsync(instanceId, originId, null, instanceCheckerId, agentId, ActionStatus.Rejected, comment);

            await this.UpdateApplicationAsync(application, checkerId, ApplicationStatus.Rejected);

            return await Task.FromResult(true);
        }

        public async Task<bool> CancelAsync(TApplication application)
        {
            return await Task.FromResult(true);
        }
        
        public async Task<bool> CanApproveAsync(WorkflowInstance instance, ApplicationStatus status, string checkerId)
        {
            if (instance == null || status != ApplicationStatus.Submitted || string.IsNullOrWhiteSpace(checkerId)) return false;

            var defaultChecker = await _userRepository.FindById(instance.CheckerId);

            if (defaultChecker.Id.Equals(checkerId) || defaultChecker.AgentId.Equals(checkerId)) return true;

            return false;
        }

        private async Task UpdateApplicationAsync(TApplication application, string checkerId, ApplicationStatus status)
        {
            application.Status = status;
            application.ModificatorId = checkerId;
            application.ModifyDate = DateTime.Now;

            await _applicationRepository.UpdateAsync(application);
        }

        private async Task<WorkflowInstance> UpdateInstanceAsync(WorkflowInstance instance, WorkflowState state)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));

            var result = await this.FindDestinagionByStateAsync(state, instance.Level, instance.ApplicantId);

            instance.Level = result.Level;
            instance.StateId = result.DestinagionId > 0 ? result.DestinagionId : new Nullable<long>();
            instance.CheckerId = !string.IsNullOrWhiteSpace(result.CheckerId) ? result.CheckerId : null;

            if (instance.Id > 0)
            {
                instance.ModificatorId = instance.CheckerId;
                instance.ModifyDate = DateTime.Now;

                return await _instanceRepository.UpdateAsync(instance);
            }
            else
            {
                return await _instanceRepository.InsertAsync(instance);
            }
        }

        private async Task<bool> InsertLogAsync(long instanceId, long originId, long? destinagionId, string checkerId, string agentId, ActionStatus status, string comment)
        {
            var log = new TWorkflowLog()
            {
                InstanceId = instanceId,
                OriginId = originId,
                DestinagionId = destinagionId,
                CheckerId = checkerId,
                AgentId = agentId,
                Status = status,
                Comment = comment,
                IpAddress = IpManager.GetClientIp(),
                CreatorId = agentId ?? checkerId,
                CreateDate = DateTime.Now,
                ModificatorId = agentId ?? checkerId,
                ModifyDate = DateTime.Now
            };

            await _logRepository.InsertAsync(log);

            return await Task.FromResult(true);
        }

        private async Task<TApplication> FindApplicationByNumberAsync(string number)
        {
            return await _applicationRepository.FirstOrDefaultAsync(x => x.Number == number, s => s.WorkflowInstance);
        }

        /// <summary>
        /// name is typeof(TApplication).FullName
        /// </summary>
        /// <returns></returns>
        private Workflow FindWorkflowByName()
        {
            return _workflowRepository.GetAllIncluding(x => x.InitialState)
                .FirstOrDefault(x => x.ApplicationName == typeof(TApplication).FullName);
        }

        private SequentialWorkflowStateSetting FindSequentialSettingByStateId(long stateId, string applicantId)
        {
            return _seqSettingRepository.GetAllIncluding(x => x.Sequences)
                .FirstOrDefault(x => x.ApplicantId == applicantId && x.StateId == stateId);
        }

        private async Task<WorkflowDestinagion> FindDestinagionByStateAsync(WorkflowState state, int level, string applicantId)
        {
            WorkflowDestinagion result = new WorkflowDestinagion()
            {
                DestinagionId = 0,
                CheckerId = string.Empty,
                Level = 0
            };

            if (state == null) return await Task.FromResult(result);

            var destinagion = this.LookupNextDestinagion(state);

            if (state.Type == WorkflowStateType.Basic)
            {
                if (destinagion != null)
                {
                    var basicState = await _basicStateRepository.GetAsync(destinagion.Id);

                    result.DestinagionId = basicState.Id;
                    result.CheckerId = basicState.CheckerId;
                    result.Level = 0;
                }
            }
            else
            {
                int nextLevel = level;

                var sequentialSetting = await _seqSettingRepository.FirstOrDefaultAsync(x => x.StateId == state.Id && x.ApplicantId == applicantId, s => s.Sequences);

                if (sequentialSetting == null)
                    throw new InvalidOperationException("流程設置錯誤，請聯繫系統管理員獲取更多信息！");

                if (sequentialSetting.Sequences != null)
                {
                    foreach (var sequence in sequentialSetting.Sequences.OrderBy(x => x.Level))
                    {
                        if (level == 0 || sequence.Level > level)
                        {
                            result.DestinagionId = state.Id;
                            result.CheckerId = sequence.CheckerId;
                            result.Level = nextLevel = sequence.Level;

                            break;
                        }
                    }
                }

                if (sequentialSetting.Sequences == null || level == nextLevel)
                {
                    await this.FindDestinagionByStateAsync(destinagion, level, applicantId);
                }
            }

            return await Task.FromResult(result);
        }

        private WorkflowState LookupNextDestinagion(WorkflowState state)
        {
            if (state.Options != null)
            {
                foreach (var option in state.Options)
                {
                    if (Evaluate(option.Eval))
                    {
                        return option.Destinagion;
                    }
                }
            }

            return state.Destinagion;
        }

        private bool Evaluate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
            {
                throw new ArgumentNullException(nameof(expression));
            }

            using (CSharpCodeProvider csc = new CSharpCodeProvider())
            {
                CompilerParameters parameters = new CompilerParameters()
                {
                    CompilerOptions = "/t:library",
                    GenerateInMemory = true
                };

                var currentAssembly = GetType().Assembly;
                var assemblyNames = currentAssembly.GetReferencedAssemblies();

                foreach (var assemblyName in assemblyNames)
                {
                    parameters.ReferencedAssemblies.Add(Assembly.Load(assemblyName).Location);
                }

                parameters.ReferencedAssemblies.Add(currentAssembly.Location);

                StringBuilder builder = new StringBuilder();
                builder.AppendLine("using System;");
                builder.AppendLine("using System.Linq;");

                builder.Append("namespace TP.Repository.Utility.Workflow {");
                builder.Append("public class CodeEvaler {");
                builder.Append(string.Format("public bool Eval({0} application) {{", typeof(TApplication).FullName));
                builder.Append(string.Format("Func<{0}, bool> action = {1};", typeof(TApplication).FullName, expression));
                builder.Append("return action.Invoke(application);");
                builder.Append("}");
                builder.Append("}");
                builder.Append("}");

                CompilerResults results = csc.CompileAssemblyFromSource(parameters, builder.ToString());

                if (results.Errors.Count > 0)
                {
                    throw new InvalidOperationException();
                }

                var assembly = results.CompiledAssembly; var type = assembly.GetType("TP.Repository.Utility.Workflow.CodeEvaler");

                return (bool)type.GetMethod("Eval").Invoke(Activator.CreateInstance(type), new object[] { this });
            }
        }
    }

    public class WorkflowDestinagion
    {
        public long DestinagionId { get; set; }

        public string CheckerId { get; set; }

        public int Level { get; set; }
    }
}
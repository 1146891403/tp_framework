using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class WorkflowRepository<TApplication, TWorkflowLog> : IWorkflowRepository<TApplication, TWorkflowLog>
        where TApplication : ApplicationBase
        where TWorkflowLog : EntityBaseOfLong, IWorkflowLog, ITraceable, new()
    {
        private readonly IRepositoryOfLong<Workflow> _workflowRepository;
        private readonly IRepositoryOfLong<SequentialWorkflowStateSetting> _sequentialRepository;

        public WorkflowRepository(IRepositoryOfLong<Workflow> workflowRepository, IRepositoryOfLong<SequentialWorkflowStateSetting> sequentialRepository)
        {
            _workflowRepository = workflowRepository ?? throw new ArgumentNullException(nameof(workflowRepository));
            _sequentialRepository = sequentialRepository ?? throw new ArgumentNullException(nameof(sequentialRepository));
        }
        
        public async Task<Workflow> FindWorkflowByNameAsync(string applicationName)
        {
            return await _workflowRepository.FirstOrDefaultAsync(x => x.ApplicationName == applicationName);
        }

        public async Task<SequentialWorkflowStateSetting> FindSequentialByUserIdAsync(string applicantId, long stateId)
        {
            return await _sequentialRepository.FirstOrDefaultAsync(x => x.ApplicantId == applicantId && x.StateId == stateId);
        }

        public async Task<IEnumerable<Workflow>> GetWorkflowsAsync()
        {
            return await _workflowRepository.GetAllListAsync();
        }

        public async Task<IEnumerable<WorkflowState>> GetWorkflowStateAsync()
        {
            return await Task.FromResult(new List<WorkflowState>());
        }
    }
}

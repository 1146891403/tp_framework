using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Utility.Interfaces;
using TP.Repository.Utility.Services;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Repository.Crm.Interfaces;

namespace TP.WL.ERP.Repository.Crm.Services
{
    public class ClientWorkflowRepository : WorkflowRepository<Client, ClientWorkflowLog>, IClientWorkflowRepository
    {
        public ClientWorkflowRepository(IUserRepository userRepository, INumberRepository numberRepository, IRepositoryOfLong<Client> applicationRepository, IRepositoryOfLong<Workflow> workflowRepository, IRepositoryOfLong<BasicWorkflowState> basicStateRepository, IRepositoryOfLong<SequentialWorkflowStateSetting> seqSettingRepository, IRepositoryOfLong<WorkflowInstance> instanceRepository, IRepositoryOfLong<ClientWorkflowLog> logRepository) 
            : base(userRepository, numberRepository, applicationRepository, workflowRepository, basicStateRepository, seqSettingRepository, instanceRepository, logRepository)
        {
        }
    }
}

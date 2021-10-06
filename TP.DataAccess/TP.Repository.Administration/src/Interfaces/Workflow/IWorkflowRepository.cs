using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IWorkflowRepository<TApplication, TWorkflowLog> : IRepository
        where TApplication : ApplicationBase
        where TWorkflowLog : IWorkflowLog, ITraceable
    {
        Task<Workflow> FindWorkflowByNameAsync(string applicationName);

        Task<SequentialWorkflowStateSetting> FindSequentialByUserIdAsync(string applicantId, long stateId);

        Task<IEnumerable<Workflow>> GetWorkflowsAsync();

        Task<IEnumerable<WorkflowState>> GetWorkflowStateAsync();
    }
}

using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Utility.Interfaces
{
    public interface IWorkflowRepository<TApplication, TWorkflowLog> : IRepository
        where TApplication : ApplicationBase
        where TWorkflowLog : IWorkflowLog, ITraceable
    {
        Task<bool> SubmitAsync(TApplication application);

        Task<bool> ExecuteAsync(string number, string checkerId, string comment);

        Task<bool> RejectAsync(string number, string checkerId, string comment);

        Task<bool> CancelAsync(TApplication application);

        //Task<bool> CanSubmit();

        Task<bool> CanApproveAsync(WorkflowInstance instance, ApplicationStatus status, string checkerId);
    }
}

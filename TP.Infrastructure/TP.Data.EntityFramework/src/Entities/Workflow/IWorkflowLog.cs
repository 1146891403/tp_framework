using TP.Infrastructure.Common.Enums;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public interface IWorkflowLog
    {
        long InstanceId { get; set; }

        WorkflowInstance Instance { get; set; }

        long OriginId { get; set; }

        WorkflowState Origin { get; set; }

        long? DestinagionId { get; set; }

        WorkflowState Destinagion { get; set; }

        string CheckerId { get; set; }

        ApplicationUser Checker { get; set; }

        string AgentId { get; set; }

        ApplicationUser Agent { get; set; }

        ActionStatus Status { get; set; }

        string Comment { get; set; }

        string IpAddress { get; set; }
    }
}

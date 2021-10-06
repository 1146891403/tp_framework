using System;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Enums;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientWorkflowLog : EntityBaseOfLong, IWorkflowLog, ITraceable
    {
        public long InstanceId { get; set; }

        public virtual WorkflowInstance Instance { get; set; }

        public string Comment { get; set; }

        public long OriginId { get; set; }

        public virtual WorkflowState Origin { get; set; }

        public long? DestinagionId { get; set; }

        public virtual WorkflowState Destinagion { get; set; }

        public string CheckerId { get; set; }

        public virtual ApplicationUser Checker { get; set; }

        public string AgentId { get; set; }

        public virtual ApplicationUser Agent { get; set; }

        public ActionStatus Status { get; set; }

        public string IpAddress { get; set; }

        public string CreatorId { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

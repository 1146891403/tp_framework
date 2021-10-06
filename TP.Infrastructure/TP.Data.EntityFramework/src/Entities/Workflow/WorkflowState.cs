using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class WorkflowState : EntityBaseOfLong, ITraceable
    {
        public WorkflowState()
        {
            Options = new List<WorkflowStateOption>();
        }

        public string Number { get; set; }

        public string DisplayName { get; set; }

        public WorkflowStateType Type { get; set; }

        public long? DestinagionId { get; set; }

        public virtual WorkflowState Destinagion { get; set; }

        public string Comment { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;

        public virtual ICollection<WorkflowStateOption> Options { get; set; }
    }
}

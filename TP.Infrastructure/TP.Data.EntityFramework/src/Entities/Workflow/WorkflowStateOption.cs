using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class WorkflowStateOption : EntityBaseOfLong, ITraceable
    {
        public int Priority { get; set; }

        public string Eval { get; set; }

        public long StateId { get; set; }

        public virtual WorkflowState State { get; set; }

        public long DestinagionId { get; set; }

        public virtual WorkflowState Destinagion { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

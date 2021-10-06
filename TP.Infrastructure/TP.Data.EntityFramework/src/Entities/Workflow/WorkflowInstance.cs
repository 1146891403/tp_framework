using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class WorkflowInstance : EntityBaseOfLong, ITraceable
    {
        public int Level { get; set; }

        public long WorkflowId { get; set; }

        public virtual Workflow Workflow { get; set; }

        public string ApplicantId { get; set; }

        public virtual ApplicationUser Applicant { get; set; }

        public long? StateId { get; set; }

        public virtual WorkflowState State { get; set; }

        public string CheckerId { get; set; }

        public virtual ApplicationUser Checker { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;

        public virtual ICollection<IWorkflowLog> Logs { get; set; }
    }
}

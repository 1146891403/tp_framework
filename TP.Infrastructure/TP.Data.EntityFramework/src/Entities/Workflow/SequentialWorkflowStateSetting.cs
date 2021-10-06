using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class SequentialWorkflowStateSetting : EntityBaseOfLong, ITraceable
    {
        public long StateId { get; set; }

        public virtual SequentialWorkflowState State { get; set; }

        public string ApplicantId { get; set; }

        public virtual ApplicationUser Applicant { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;

        public virtual ICollection<SequentialLevel> Sequences { get; set; } = new List<SequentialLevel>();
    }
}

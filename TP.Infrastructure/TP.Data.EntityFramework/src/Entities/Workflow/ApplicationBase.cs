using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class ApplicationBase : EntityBaseOfLong, ITraceable
    {
        public string Number { get; set; }

        public ApplicationStatus Status { get; set; }

        public long? InstanceId { get; set; }

        public virtual WorkflowInstance WorkflowInstance { get; set; }

        public string ApplicantId { get; set; }

        public virtual ApplicationUser Applicant { get; set; }
        
        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

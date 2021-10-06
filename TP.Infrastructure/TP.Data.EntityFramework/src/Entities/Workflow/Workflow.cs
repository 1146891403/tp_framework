using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class Workflow : EntityBaseOfLong, ITraceable
    {
        public string DisplayName { get; set; }

        public string ApplicationName { get; set; }

        public long InitialStateId { get; set; }

        public virtual WorkflowState InitialState { get; set; }

        public string Comment { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

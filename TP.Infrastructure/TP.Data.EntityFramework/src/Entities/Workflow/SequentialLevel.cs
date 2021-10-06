using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class SequentialLevel: EntityBaseOfLong, ITraceable
    {
        public long SettingId { get; set; }

        public virtual SequentialWorkflowStateSetting Setting { get; set; }

        public int Level { get; set; }

        public string CheckerId { get; set; }

        public virtual ApplicationUser Checker { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

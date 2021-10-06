using System;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class Certificate : EntityBaseOfLong, ITraceable
    {
        public string Number { get; set; }

        public string DisplayName { get; set; }

        public bool IsGuarantee { get; set; }

        public bool IsTestReport { get; set; }

        public bool IsGuaranteeOrReport { get; set; }

        public decimal LifetimeScope { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsDefault { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

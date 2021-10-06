using System;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Estimate
{
    public class EstimateMaterial : EntityBaseOfLong, ITraceable
    {
        public long ComponentId { get; set; }

        public virtual EstimateComponent Component { get; set; }

        public string MaterialNumber { get; set; }

        public string DisplayName { get; set; }

        public decimal Price { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

using System;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Estimate
{
    public class EstimateCost : EntityBaseOfLong, ITraceable
    {
        public long ComponentItemId { get; set; }

        public virtual EstimateComponentItem ComponentItem { get; set; }

        public string Type { get; set; }

        public string DisplayName { get; set; }

        public decimal Price { get; set; }

        public decimal Amount { get; set; }
        
        public string Remark { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

using System;
using System.Collections.Generic;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Estimate
{
    public class EstimateComponentItem : EntityBaseOfLong, ITraceable
    {
        public long ComponentId { get; set; }

        public virtual EstimateComponent Component { get; set; }

        public decimal Quantity { get; set; }

        public decimal AttritionRate { get; set; }

        public decimal PaperQuantity { get; set; }

        public decimal PaperWaste { get; set; }

        public decimal PrintTime { get; set; }

        public decimal PrintPrice { get; set; }
        
        public decimal GrossRate { get; set; }

        public decimal CostPrice { get; set; }

        public decimal CostPriceOfVAT { get; set; }

        public decimal CostAmount { get; set; }

        public decimal AdjustmentPrice { get; set; }

        public decimal ClientPrice { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;

        public virtual ICollection<EstimateCost> Costs { get; set; }
    }
}

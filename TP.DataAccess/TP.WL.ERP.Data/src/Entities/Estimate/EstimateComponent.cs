using System;
using System.Collections.Generic;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Estimate
{
    public class EstimateComponent : EntityBaseOfLong, ITraceable
    {
        public long EstimateId { get; set; }

        public virtual EstimateRequest Estimate { get; set; }

        public string Group { get; set; }
        
        public decimal SizeH { get; set; }

        public decimal SizeV { get; set; }

        public decimal SpellingH { get; set; }

        public decimal SpellingV { get; set; }

        public decimal MarginTop { get; set; }

        public decimal MarginRight { get; set; }

        public decimal MarginBottom { get; set; }

        public decimal MarginLeft { get; set; }

        public string Color { get; set; }

        public string OtherColor { get; set; }

        public bool IsPunch { get; set; }

        public bool IsGild { get; set; }

        public decimal LengthMM { get; set; }

        public decimal LengthInch { get; set; }

        public decimal HeightMM { get; set; }

        public decimal HeightInch { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;

        public virtual ICollection<EstimateComponentItem> Items { get; set; }

        public virtual ICollection<EstimateMaterial> Materials { get; set; }
    }
}

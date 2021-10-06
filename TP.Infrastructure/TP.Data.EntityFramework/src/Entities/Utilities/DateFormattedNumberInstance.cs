using System;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class DateFormattedNumberInstance : EntityBaseOfLong
    {
        public long TemplateId { get; set; }

        public virtual DateFormattedNumberTemplate Template { get; set; }
        
        public string ApplicationName { get; set; }

        public string Prefix { get; set; }
        
        public int Seed { get; set; }

        public DateTime LastGenerateDate { get; set; } = DateTime.Now;

        public bool IsEnabled { get; set; }

        public long SubsidiaryId { get; set; }

        public virtual Subsidiary Subsidiary { get; set; }
    }
}

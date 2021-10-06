using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class DictionaryData : EntityBaseOfLong
    {
        public long TypeId { get; set; }

        public virtual DictionaryType Type { get; set; }

        public string DisplayName { get; set; }

        public string Value { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public string Remark { get; set; }

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}

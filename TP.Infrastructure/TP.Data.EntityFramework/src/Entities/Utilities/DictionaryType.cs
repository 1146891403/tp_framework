using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class DictionaryType : EntityBaseOfLong
    {
        public string Number { get; set; }

        public string DisplayName { get; set; }

        public int ListOrder { get; set; }

        public string Remark { get; set; }

        public long? ParentId { get; set; }

        public virtual DictionaryType Parent { get; set; }

        public virtual ICollection<DictionaryType> Children { get; set; }

        public virtual ICollection<DictionaryData> Datas { get; set; }
    }
}

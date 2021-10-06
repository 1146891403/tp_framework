using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class Country : EntityBaseOfLong
    {
        public string Number { get; set; }

        public string DisplayName { get; set; }
        
        public virtual ICollection<Province> Provinces { get; set; }
    }
}

using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class Province : EntityBaseOfLong
    {
        public string Number { get; set; }

        public string DisplayName { get; set; }
        
        public long CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<City> Citys { get; set; }
    }
}

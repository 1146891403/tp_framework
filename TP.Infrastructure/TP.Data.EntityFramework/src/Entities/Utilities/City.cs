using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class City : EntityBaseOfLong
    {
        public string Number { get; set; }

        public string DisplayName { get; set; }

        public string ZipCode { get; set; }
        
        public long ProvinceId { get; set; }

        public virtual Province Province { get; set; }
    }
}

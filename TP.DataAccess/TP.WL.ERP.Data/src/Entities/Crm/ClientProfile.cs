using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Enums;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientProfile : EntityBaseOfLong
    {
        public virtual Client Client { get; set; }

        public string Nature { get; set; }

        public string AreaCovered { get; set; }

        public string EmployeeCount { get; set; }

        public string Website { get; set; }

        public string Customer { get; set; }

        public string Supplier { get; set; }

        public string Product { get; set; }

        public decimal SalesAmount { get; set; }

        public Currency CapitalCurrency { get; set; }

        public decimal CapitalAmount { get; set; }

        public int OrderQuantity { get; set; }

        public string ISOStatus { get; set; }

        public string ProductionDescription { get; set; }

        public string PackageDescription { get; set; }

        public string DeliveryDescription { get; set; }

        public string Remark { get; set; }
    }
}

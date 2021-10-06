using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Crm
{
    public class ClientProfileEditModel : EditModelBase
    {
        public string Nature { get; set; }

        public string AreaCovered { get; set; }

        public string EmployeeCount { get; set; }

        public string Website { get; set; }

        public string Customer { get; set; }

        public string Supplier { get; set; }

        public string Product { get; set; }

        public decimal SalesAmount { get; set; }

        public string CapitalCurrency { get; set; }

        public decimal CapitalAmount { get; set; }

        public int OrderQuantity { get; set; }

        public string ISOStatus { get; set; }

        public string ProductionDescription { get; set; }

        public string PackageDescription { get; set; }

        public string DeliveryDescription { get; set; }

        public string Remark { get; set; }
    }
}

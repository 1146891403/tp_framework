using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Crm
{
    public class ClientEditModel : EditModelBase
    {
        public string ShortName { get; set; }
        
        public string ChineseName { get; set; }

        public string EnglishName { get; set; }

        public string Level { get; set; }

        public string OrderType { get; set; }

        public string Industry { get; set; }

        public string InformationSource { get; set; }

        public string Terms { get; set; }

        public decimal NationalTax { get; set; }

        public string BusinessNumber { get; set; }

        public string TaxNumber { get; set; }

        public string BankName { get; set; }

        public string BankNumber { get; set; }

        public string InvoiceAddress1 { get; set; }

        public string InvoiceAddress2 { get; set; }

        public string InvoiceAddress3 { get; set; }

        public string LicenseAddress1 { get; set; }

        public string LicenseAddress2 { get; set; }

        public string LicenseAddress3 { get; set; }

        public string Currency { get; set; }

        public bool IsVAT { get; set; }

        public decimal VAT { get; set; }

        public bool IsMonthlyStatement { get; set; }

        public decimal Discount { get; set; }

        public decimal EstimateRate { get; set; }

        public string GroupNumber { get; set; }

        public decimal GroupCreditLimit { get; set; }

        public decimal CreditLimit { get; set; }

        public string PaymentArea { get; set; }

        public bool IsSample { get; set; }

        public bool IsLiaisonForm { get; set; }
    }
}

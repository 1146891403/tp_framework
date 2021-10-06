using System.Collections.Generic;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Enums;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class Client : ApplicationBase
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

        public Currency Currency { get; set; }

        public bool IsVAT { get; set; }

        public decimal VAT { get; set; }

        public bool IsMonthlyStatement { get; set; }

        public bool IsSample { get; set; }

        public bool IsLiaisonForm { get; set; }

        public decimal Discount { get; set; }

        public decimal EstimateRate { get; set; }

        public decimal CreditLimit { get; set; }

        public string PaymentArea { get; set; }

        //public decimal LastSales { get; set; }

        //public decimal BeforeLastSales { get; set; }

        //public decimal TempCreditLimit { get; set; }

        //public DateTime TempEffectiveDate { get; set; }

        //public string TempRemark { get; set; }

        public bool IsLockedOut { get; set; }

        public string LockedOutRemark { get; set; }

        public string SalesmanId { get; set; }

        public string Salesman { get; set; }

        public virtual ApplicationUser Sales { get; set; }

        public string MerchandiserId { get; set; }

        public string MerchandiserName { get; set; }

        public virtual ApplicationUser Merchandiser { get; set; }

        public long? OriginId { get; set; }

        public virtual Client Origin { get; set; }
        
        public long? GroupId { get; set; }

        public virtual Client Group { get; set; }

        public decimal GroupCreditLimit { get; set; }

        public virtual ClientProfile Profile { get; set; }

        public virtual ICollection<ClientCertificateGroup> CertificateGroups { get; set; }
        
        public virtual ICollection<ClientBrand> Brands { get; set; }

        public virtual ICollection<ClientOpenFile> OpenFiles { get; set; }

        public virtual ICollection<ClientSignFile> SignFiles { get; set; }

        public virtual ICollection<ClientContact> Contacts { get; set; }

        public virtual ICollection<ClientExpress> Expresses { get; set; }
    }
}

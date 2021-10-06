using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Infrastructure.Common.Enums;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            this.ToTable("tpwl_crm_Clients");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            this.Property(x => x.ShortName).HasMaxLength(50).IsRequired();
            this.Property(x => x.ChineseName).HasMaxLength(256);
            this.Property(x => x.EnglishName).HasMaxLength(256);
            this.Property(x => x.Level).HasMaxLength(10).IsRequired();
            this.Property(x => x.OrderType).HasMaxLength(10);
            this.Property(x => x.Industry).HasMaxLength(10);
            this.Property(x => x.InformationSource).HasMaxLength(128);
            this.Property(x => x.Salesman).HasMaxLength(256);
            this.Property(x => x.MerchandiserName).HasMaxLength(256);
            this.Property(x => x.Terms).HasMaxLength(128);
            this.Property(x => x.NationalTax).HasPrecision(18, 4);
            this.Property(x => x.BusinessNumber).HasMaxLength(50);
            this.Property(x => x.TaxNumber).HasMaxLength(50);
            this.Property(x => x.BankName).HasMaxLength(256);
            this.Property(x => x.BankNumber).HasMaxLength(50);
            this.Property(x => x.InvoiceAddress1).HasMaxLength(256);
            this.Property(x => x.InvoiceAddress2).HasMaxLength(256);
            this.Property(x => x.InvoiceAddress3).HasMaxLength(256);
            this.Property(x => x.LicenseAddress1).HasMaxLength(256);
            this.Property(x => x.LicenseAddress2).HasMaxLength(256);
            this.Property(x => x.LicenseAddress3).HasMaxLength(256);
            this.Property<Currency>(x => x.Currency).IsRequired();
            this.Property(x => x.IsVAT).IsRequired();
            this.Property(x => x.VAT).HasPrecision(18, 4);
            this.Property(x => x.IsMonthlyStatement).IsRequired();
            this.Property(x => x.IsSample).IsRequired();
            this.Property(x => x.IsLiaisonForm).IsRequired();
            this.Property(x => x.Discount).HasPrecision(18, 4);
            this.Property(x => x.EstimateRate).HasPrecision(18, 4);
            this.Property(x => x.PaymentArea).HasMaxLength(128);
            this.Property(x => x.CreditLimit).HasPrecision(18, 4);
            this.Property(x => x.GroupCreditLimit).HasPrecision(18, 4);
            //this.Property(x => x.LastSales).HasPrecision(18, 4);
            //this.Property(x => x.BeforeLastSales).HasPrecision(18, 4);
            //this.Property(x => x.TempCreditLimit).HasPrecision(18, 4);
            //this.Property(x => x.TempEffectiveDate);
            //this.Property(x => x.TempRemark).HasMaxLength(1024);
            this.Property(x => x.IsLockedOut);
            this.Property(x => x.LockedOutRemark).HasMaxLength(1024);

            this.HasOptional(x => x.Sales).WithMany().HasForeignKey(k => k.SalesmanId).WillCascadeOnDelete(false);
            this.HasOptional(x => x.Merchandiser).WithMany().HasForeignKey(k => k.MerchandiserId).WillCascadeOnDelete(false);
            this.HasOptional(x => x.Origin).WithMany().HasForeignKey(k => k.OriginId).WillCascadeOnDelete(false);
            this.HasOptional(x => x.Group).WithMany().HasForeignKey(k => k.GroupId).WillCascadeOnDelete(false);

            this.WithApplication();
        }
    }
}

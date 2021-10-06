using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Infrastructure.Common.Enums;
using TP.WL.ERP.Data.Entities.Crm;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientProfileMap : EntityTypeConfiguration<ClientProfile>
    {
        public ClientProfileMap()
        {
            this.ToTable("tpwl_crm_ClientProfiles");

            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("ClientId");
            this.Property(x => x.Nature).HasMaxLength(128);
            this.Property(x => x.EmployeeCount).HasMaxLength(128);
            this.Property(x => x.AreaCovered).HasMaxLength(50);
            this.Property(x => x.Customer).HasMaxLength(1024);
            this.Property(x => x.Supplier).HasMaxLength(1024);
            this.Property(x => x.Product).HasMaxLength(1024);
            this.Property(x => x.SalesAmount).HasPrecision(18, 4);
            this.Property<Currency>(x => x.CapitalCurrency);
            this.Property(x => x.CapitalAmount).HasPrecision(18, 4);
            this.Property(x => x.OrderQuantity);
            this.Property(x => x.ISOStatus).HasMaxLength(20);
            this.Property(x => x.ProductionDescription).HasMaxLength(1024);
            this.Property(x => x.PackageDescription).HasMaxLength(1024);
            this.Property(x => x.DeliveryDescription).HasMaxLength(1024);
            this.Property(x => x.Remark).HasMaxLength(1024);

            this.HasRequired(x => x.Client).WithRequiredDependent(y => y.Profile);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class CertificateMap : EntityTypeConfiguration<Certificate>
    {
        public CertificateMap()
        {
            this.ToTable("tpwl_crm_Certificates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.IsGuarantee).IsRequired();
            this.Property(x => x.IsTestReport).IsRequired();
            this.Property(x => x.IsGuaranteeOrReport).IsRequired();
            this.Property(x => x.LifetimeScope).HasPrecision(5, 2);
            this.Property(x => x.StartDate).IsRequired();
            this.Property(x => x.EndDate).IsRequired();
            this.Property(x => x.IsDefault).IsRequired();

            this.WithTraceable();
        }
    }
}

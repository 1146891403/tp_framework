using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class SalesTargetMap : EntityTypeConfiguration<SalesTarget>
    {
        public SalesTargetMap()
        {
            this.ToTable("tpwl_crm_SalesTargets");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.SalesNumber).HasMaxLength(32).IsRequired();
            this.Property(x => x.SalesName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Year).IsRequired();
            this.Property(x => x.Month).IsRequired();
            this.Property(x => x.Amount).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.Remark).HasMaxLength(1024);

            this.HasRequired(x => x.Owner).WithMany().HasForeignKey(k => k.OwnerId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

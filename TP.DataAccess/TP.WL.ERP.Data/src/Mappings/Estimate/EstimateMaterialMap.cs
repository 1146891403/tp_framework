using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Estimate;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Estimate
{
    public class EstimateMaterialMap : EntityTypeConfiguration<EstimateMaterial>
    {
        public EstimateMaterialMap()
        {
            this.ToTable("tpwl_est_EstimateMaterials");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.MaterialNumber).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Price).HasPrecision(18, 4).IsRequired();

            this.HasRequired(x => x.Component).WithMany(y => y.Materials).HasForeignKey(k => k.ComponentId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Estimate;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Estimate
{
    public class EstimateCostMap : EntityTypeConfiguration<EstimateCost>
    {
        public EstimateCostMap()
        {
            this.ToTable("tpwl_est_EstimateCosts");
            
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Type).HasMaxLength(128).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(512).IsRequired();
            this.Property(x => x.Price).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.Amount).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.Remark).HasMaxLength(1024);

            this.HasRequired(x => x.ComponentItem).WithMany(y => y.Costs).HasForeignKey(k => k.ComponentItemId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

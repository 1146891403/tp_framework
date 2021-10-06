using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Estimate;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Estimate
{
    public class EstimateComponentItemMap : EntityTypeConfiguration<EstimateComponentItem>
    {
        public EstimateComponentItemMap()
        {
            this.ToTable("tpwl_est_EstimateComponentItems");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Quantity).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.AttritionRate).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.PaperQuantity).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.PaperWaste).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.PrintTime).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.PrintPrice).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.GrossRate).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.CostAmount).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.CostPrice).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.CostPriceOfVAT).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.AdjustmentPrice).HasPrecision(18, 4).IsRequired();
            this.Property(x => x.ClientPrice).HasPrecision(18, 4).IsRequired();

            this.HasRequired(x => x.Component).WithMany(y => y.Items).HasForeignKey(k => k.ComponentId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

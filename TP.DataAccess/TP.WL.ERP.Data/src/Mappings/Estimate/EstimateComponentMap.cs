using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Estimate;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Estimate
{
    public class EstimateComponentMap : EntityTypeConfiguration<EstimateComponent>
    {
        public EstimateComponentMap()
        {
            this.ToTable("tpwl_est_EstimateComponents");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Group).HasMaxLength(10).IsRequired();
            this.Property(x => x.SizeH).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.SizeV).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.SpellingH).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.SpellingV).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.MarginTop).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.MarginRight).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.MarginBottom).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.MarginLeft).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.Color).HasMaxLength(20);
            this.Property(x => x.OtherColor).HasMaxLength(256);
            this.Property(x => x.IsPunch).IsRequired();
            this.Property(x => x.IsGild).IsRequired();
            this.Property(x => x.LengthMM).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.LengthInch).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.HeightMM).HasPrecision(10, 2).IsRequired();
            this.Property(x => x.HeightInch).HasPrecision(10, 2).IsRequired();

            this.HasRequired(x => x.Estimate).WithMany(y => y.Components).HasForeignKey(k => k.EstimateId).WillCascadeOnDelete(false);
            
            this.WithTraceable();
        }
    }
}

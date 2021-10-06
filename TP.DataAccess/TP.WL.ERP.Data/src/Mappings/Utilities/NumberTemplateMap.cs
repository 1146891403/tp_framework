using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class NumberTemplateMap : EntityTypeConfiguration<NumberTemplate>
    {
        public NumberTemplateMap()
        {
            ToTable("tpwl_util_NumberTemplates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.Description).HasMaxLength(256);
            this.Property(x => x.Body).HasMaxLength(128).IsRequired();
            this.Property(x => x.Seed).IsRequired();
            this.Property<NumberFormat>(x => x.Format).IsRequired();
            this.Property(x => x.Comment).HasMaxLength(1024);
            this.Property(x => x.CreateDate).IsRequired();
        }
    }
}

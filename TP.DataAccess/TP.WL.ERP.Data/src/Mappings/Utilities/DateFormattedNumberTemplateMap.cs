using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class DateFormattedNumberTemplateMap : EntityTypeConfiguration<DateFormattedNumberTemplate>
    {
        public DateFormattedNumberTemplateMap()
        {
            ToTable("tpwl_util_DateFormattedNumberTemplates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("TemplateId");

            this.Property(x => x.ResetCriterion).HasMaxLength(128).IsRequired();
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class DateFormattedNumberInstanceMap : EntityTypeConfiguration<DateFormattedNumberInstance>
    {
        public DateFormattedNumberInstanceMap()
        {
            ToTable("tpwl_util_DateFormattedNumberInstances");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.ApplicationName).HasMaxLength(128).IsRequired();
            this.Property(x => x.Prefix).HasMaxLength(32).IsRequired();
            this.Property(x => x.Seed).IsRequired();
            this.Property(x => x.LastGenerateDate).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();
            
            this.HasRequired(x => x.Template).WithMany(y => y.Instances).HasForeignKey(k => k.TemplateId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Subsidiary).WithMany().HasForeignKey(k => k.SubsidiaryId).WillCascadeOnDelete(false);
        }
    }
}

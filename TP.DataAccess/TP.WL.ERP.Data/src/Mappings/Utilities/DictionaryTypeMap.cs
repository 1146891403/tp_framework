using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class DictionaryTypeMap : EntityTypeConfiguration<DictionaryType>
    {
        public DictionaryTypeMap()
        {
            ToTable("tpwl_util_DictionaryTypes");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(128).IsRequired();
            this.Property(x => x.ListOrder).IsRequired();
            this.Property(x => x.Remark).HasMaxLength(1024);
            
            this.HasOptional(x => x.Parent).WithMany(y => y.Children).HasForeignKey(k => k.ParentId).WillCascadeOnDelete(false);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class DictionaryDataMap : EntityTypeConfiguration<DictionaryData>
    {
        public DictionaryDataMap()
        {
            ToTable("tpwl_util_DictionaryDatas");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.DisplayName).HasMaxLength(128).IsRequired();
            this.Property(x => x.Value).HasMaxLength(128).IsRequired();
            this.Property(x => x.ListOrder).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();
            this.Property(x => x.Remark).HasMaxLength(1024);
            this.Property(x => x.ModifyDate).IsRequired();
            
            this.HasRequired(x => x.Type).WithMany(y => y.Datas).HasForeignKey(k => k.TypeId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Modificator).WithMany().HasForeignKey(k => k.ModificatorId).WillCascadeOnDelete(false);
        }
    }
}

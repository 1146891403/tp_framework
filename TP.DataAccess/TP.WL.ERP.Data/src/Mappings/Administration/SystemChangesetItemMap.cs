using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class SystemChangesetItemMap : EntityTypeConfiguration<SystemChangesetItem>
    {
        public SystemChangesetItemMap()
        {
            this.ToTable("tpwl_admin_SystemChangesetItems");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.EntityName).HasMaxLength(100).IsRequired();
            this.Property(x => x.FieldName).HasMaxLength(50).IsRequired();
            this.Property(x => x.OldValue).HasMaxLength(1024);
            this.Property(x => x.NewValue).HasMaxLength(1024);

            this.HasRequired(x => x.Changeset).WithMany(y => y.Items).HasForeignKey(k => k.ChangesetId).WillCascadeOnDelete(false);
        }
    }
}

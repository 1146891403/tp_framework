using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class ViewLinkMap : EntityTypeConfiguration<ViewLink>
    {
        public ViewLinkMap()
        {
            this.ToTable("tpwl_admin_ViewLinks");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.ViewName).HasMaxLength(128).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Description).HasMaxLength(512);
            this.Property(x => x.IconSource).HasMaxLength(256);
            this.Property(x => x.ListOrder).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();
            
            this.HasRequired(x => x.Parent).WithMany(y => y.Links).HasForeignKey(k => k.ParentId).WillCascadeOnDelete(false);

            this.HasMany(x => x.Roles).WithRequired().HasForeignKey(k => k.ViewLinkId);
        }
    }
}

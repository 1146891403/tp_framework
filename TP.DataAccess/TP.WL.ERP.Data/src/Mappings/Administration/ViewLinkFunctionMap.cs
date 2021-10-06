using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class ViewLinkFunctionMap : EntityTypeConfiguration<ViewLinkFunction>
    {
        public ViewLinkFunctionMap()
        {
            this.ToTable("tpwl_admin_ViewLinkFunctions");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.ListOrder).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();

            this.HasRequired(x => x.ViewLink).WithMany(y => y.Functions).HasForeignKey(k => k.ViewLinkId).WillCascadeOnDelete(false);
            this.HasMany(x => x.Roles).WithRequired().HasForeignKey(k => k.FunctionId);
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class ApplicationRoleViewMap : EntityTypeConfiguration<ApplicationRoleView>
    {
        public ApplicationRoleViewMap()
        {
            this.ToTable("tpwl_admin_RoleInViewLinks");

            this.HasKey(x => new { x.RoleId, x.ViewLinkId });
        }
    }
}

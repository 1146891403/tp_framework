using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class ApplicationRoleGroupMap : EntityTypeConfiguration<ApplicationRoleGroup>
    {
        public ApplicationRoleGroupMap()
        {
            this.ToTable("tpwl_admin_RoleInGroups");

            this.HasKey(x => new { x.RoleId, x.GroupId });
        }
    }
}

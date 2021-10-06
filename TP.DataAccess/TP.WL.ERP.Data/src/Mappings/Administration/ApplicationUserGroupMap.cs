using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class ApplicationUserGroupMap : EntityTypeConfiguration<ApplicationUserGroup>
    {
        public ApplicationUserGroupMap()
        {
            this.ToTable("tpwl_admin_UserInGroups");

            this.HasKey(x => new { x.UserId, x.GroupId });
        }
    }
}

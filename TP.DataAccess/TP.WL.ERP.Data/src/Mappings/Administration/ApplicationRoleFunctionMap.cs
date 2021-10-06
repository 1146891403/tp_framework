using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class ApplicationRoleFunctionMap : EntityTypeConfiguration<ApplicationRoleFunction>
    {
        public ApplicationRoleFunctionMap()
        {
            this.ToTable("tpwl_admin_RoleInFunctions");

            this.HasKey(x => new { x.RoleId, x.FunctionId });
        }
    }
}

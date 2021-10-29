using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Data.EntityFramework.src.Entities.Administration;

namespace TP.WL.ERP.Data.src.Mappings.Administration
{
    public class ApplicationRoleDepartmentsMap : EntityTypeConfiguration<ApplicationRoleDepartment>
    {
        public ApplicationRoleDepartmentsMap()
        {
            this.ToTable("tpwl_admin_RoleInDepartments");

            this.HasKey(x => new { x.RoleId, x.DepartmentId });
        }
    }
}

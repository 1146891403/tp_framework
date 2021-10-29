using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.Data.EntityFramework.src.Entities.Administration
{
    public class ApplicationRoleDepartment
    {
        public string RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }

        public long DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}

using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class Department : EntityBaseOfLong
    {
        public string Number { get; set; }

        public string DisplayName { get; set; }

        public string Category { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime ModifyDate { get; set; }

        public long? ParentId { get; set; }

        public virtual Department Parent { get; set; }

        public virtual ICollection<Department> Children { get; set; } = new List<Department>();

        public long SubsidiaryId { get; set; }

        public virtual Subsidiary Subsidiary { get; set; }

        public virtual ICollection<UserProfile> Staffs { get; set; } = new List<UserProfile>();
    }
}

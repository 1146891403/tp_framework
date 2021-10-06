using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class Subsidiary : EntityBaseOfLong
    {
        public string Number { get; set; }

        public string LegalName { get; set; }

        public string Category { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime ModifyDate { get; set; }

        public long? ParentId { get; set; }

        public virtual Subsidiary Parent { get; set; }

        public virtual ICollection<Subsidiary> Children { get; set; } = new List<Subsidiary>();

        public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

        public virtual ICollection<UserProfile> Staffs { get; set; } = new List<UserProfile>();

        public virtual ICollection<ApplicationRole> Roles { get; set; } = new List<ApplicationRole>();
    }
}

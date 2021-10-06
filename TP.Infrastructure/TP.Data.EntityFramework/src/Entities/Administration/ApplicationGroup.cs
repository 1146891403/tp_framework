using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ApplicationGroup : EntityBaseOfLong
    {
        public long? ParentId { get; set; }

        public virtual ApplicationGroup Parent { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ICollection<ApplicationGroup> Children { get; set; } = new List<ApplicationGroup>();

        public virtual ICollection<ApplicationUserGroup> Users { get; set; } = new List<ApplicationUserGroup>();

        public virtual ICollection<ApplicationRoleGroup> Roles { get; set; } = new List<ApplicationRoleGroup>();
    }
}

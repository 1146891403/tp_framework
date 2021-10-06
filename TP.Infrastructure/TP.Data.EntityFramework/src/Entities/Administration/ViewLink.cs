using System;
using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ViewLink : EntityBaseOfLong
    {
        public long ParentId { get; set; }

        public virtual ViewLinkDirectory Parent { get; set; }
        
        public string Number { get; set; }

        public string ViewName { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string IconSource { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ICollection<ViewLinkFunction> Functions { get; set; } = new List<ViewLinkFunction>();

        public virtual ICollection<ApplicationRoleView> Roles { get; set; } = new List<ApplicationRoleView>();
    }
}

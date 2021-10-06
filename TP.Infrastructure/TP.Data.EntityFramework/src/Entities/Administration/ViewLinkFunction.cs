using System.Collections.Generic;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ViewLinkFunction : EntityBaseOfLong
    {
        public long ViewLinkId { get; set; }

        public virtual ViewLink ViewLink { get; set; }

        public string Number { get; set; }

        public string DisplayName { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public virtual ICollection<ApplicationRoleFunction> Roles { get; set; } = new List<ApplicationRoleFunction>();
    }
}

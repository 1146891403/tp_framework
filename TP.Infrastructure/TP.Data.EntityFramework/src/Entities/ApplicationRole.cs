using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using TP.Infrastructure.Common;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.Data.EntityFramework.Entities
{
    public class ApplicationRole : IdentityRole<string, ApplicationUserRole>, ITraceable
    {
        public ApplicationRole() : base()
        {
            this.Id = IdWorker.Instance.NextId().ToString();
            Groups = new List<ApplicationRoleGroup>();
            ViewLinks = new List<ApplicationRoleView>();
            Functions = new List<ApplicationRoleFunction>();
        }
        
        public ApplicationRole(string name, string description)
            : base()
        {
            //this.Id = IdWorker.Instance.NextId();
            this.Name = name;
            this.Description = description;
        }

        public string Description { get; set; }

        public bool IsEnabled { get; set; }

        public long SubsidiaryId { get; set; }

        public virtual Subsidiary Subsidiary { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public virtual ApplicationUser Modificator { get; set; }

        public string ModificatorId { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;

        public virtual ICollection<ApplicationRoleGroup> Groups { get; set; }

        public virtual ICollection<ApplicationRoleView> ViewLinks { get; set; }

        public virtual ICollection<ApplicationRoleFunction> Functions { get; set; }
    }
}

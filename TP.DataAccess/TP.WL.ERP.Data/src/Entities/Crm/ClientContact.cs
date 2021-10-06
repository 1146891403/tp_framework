using System;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientContact : EntityBaseOfLong, ITraceable
    {
        public long ClientId { get; set; }
        
        public virtual Client Client { get; set; }

        public string DisplayName { get; set; }

        public string Designation { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Remark { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

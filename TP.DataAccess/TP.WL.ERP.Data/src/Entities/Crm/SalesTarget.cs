using System;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class SalesTarget : EntityBaseOfLong, ITraceable
    {
        public string SalesNumber { get; set; }

        public string SalesName { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public decimal Amount { get; set; }

        public string Remark { get; set; }
        
        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }
        
        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

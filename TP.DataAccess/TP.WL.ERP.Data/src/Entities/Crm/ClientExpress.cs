using System;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientExpress : EntityBaseOfLong, ITraceable
    {
        public long ClientId { get; set; }
        
        public virtual Client Client { get; set; }

        public string Number { get; set; }

        public ClientExpressCategory Category { get; set; }

        public string Type { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }
        
        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public bool IsDefault { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

using System;
using System.Collections.Generic;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientCertificateGroup : EntityBaseOfLong, ITraceable
    {
        public long ClientId { get; set; }

        public virtual Client Client { get; set; }

        public string Number { get; set; }

        public string DisplayName { get; set; }

        public string Remark { get; set; }

        public long? FileId { get; set; }

        public virtual FileCabinet File { get; set; }

        public virtual ICollection<ClientCertificate> Certificates { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

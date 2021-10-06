using System;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientBrand : EntityBaseOfLong, ITraceable
    {
        public long ClientId { get; set; }
        
        public virtual Client Client { get; set; }

        public string Number { get; set; }

        public string DisplayName { get; set; }

        public string Registration { get; set; }
        
        public DateTime RegistrationDate { get; set; }

        public long RegistrationFileId { get; set; }

        public virtual FileCabinet RegistrationFile { get; set; }
        
        public string Authorization { get; set; }

        public DateTime AuthorizationDate { get; set; }
        
        public long AuthorizationFileId { get; set; }

        public virtual FileCabinet AuthorizationFile { get; set; }

        public DateTime SignDate { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

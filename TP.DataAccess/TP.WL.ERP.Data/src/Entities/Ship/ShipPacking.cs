using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Ship
{
    public class ShipPacking : EntityBaseOfLong, ITraceable
    {
        public long CartonId { get; set; }

        public string PackingAsk { get; set; }
        
        public string Contents { get; set; }

        public string CreatorId { get; set; }

        public virtual ShipCarton ShipCarton { get; set; }

        public ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; }

        public string ModificatorId { get; set; }

        public ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}

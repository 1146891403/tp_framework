using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Model;
using TP.WL.ERP.Data.Entities.Ship;

namespace TP.WL.ERP.Model.Ship
{
    public class ShipPackingEditModel : EditModelBase
    {
        public long CartonId { get; set; }

        public string PackingAsk { get; set; }

        public string Contents { get; set; }

        public string CreatorId { get; set; }

        public virtual ShipCarton ShipCarton { get; set; }
    }
}

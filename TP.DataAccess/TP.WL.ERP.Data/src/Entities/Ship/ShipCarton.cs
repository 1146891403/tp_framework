using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Entities;

namespace TP.WL.ERP.Data.Entities.Ship
{
    public class ShipCarton : EntityBaseOfLong, ITraceable
    {
        public string JobNumber { get; set; }

        public string DescriptiveName { get; set; }

        public string Edition { get; set; }

        public string CopyRight { get; set; }

        public DateTime Delivery_Date { get; set; }

        public string Consignee { get; set; }

        public string Notify { get; set; }

        public string Notify1 { get; set; }

        public string WaehouseAddr { get; set; }

        public string Country { get; set; }

        public string Terms { get; set; }

        public string CreatorId { get; set; }

        public virtual ICollection<ShipPacking> Packings { get; set; }

        public ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; }

        public string ModificatorId { get; set; }

        public ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}

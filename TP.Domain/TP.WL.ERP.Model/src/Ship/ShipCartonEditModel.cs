using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Ship
{
    public class ShipCartonEditModel : EditModelBase
    {
        //public long CartonId { get; set; }

        public string JobNumber { get; set; }

        public string DescriptiveName { get; set; }

        public string Edition { get; set; }

        public string CopyRight { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Consignee { get; set; }

        public string Notify { get; set; }

        public string Notify1 { get; set; }

        public string WaehouseAddr { get; set; }

        public string Country { get; set; }

        public string Terms { get; set; }

        public ICollection<ShipPackingEditModel> PackingModels { get; set; }

        //public string CreatorId { get; set; }

        //public DateTime CreateDate { get; set; }

        //public string ModificatorId { get; set; }

        //public DateTime ModifyDate { get; set; }
    }
}
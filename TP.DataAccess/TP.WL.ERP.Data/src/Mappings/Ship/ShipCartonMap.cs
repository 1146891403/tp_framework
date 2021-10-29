using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.WL.ERP.Data.Extensions;
using TP.WL.ERP.Data.Entities.Ship;

namespace TP.WL.ERP.Data.Mappings.Ship
{
    public class ShipCartonMap : EntityTypeConfiguration<ShipCarton>
    {
        public ShipCartonMap()
        {
            this.ToTable("tpwl_ship_carton");

            this.HasKey(x => x.Id);

            this.Property(x => x.JobNumber).HasMaxLength(200).IsRequired();
            this.Property(x => x.DescriptiveName).HasMaxLength(200);
            this.Property(x => x.Edition).HasMaxLength(50);
            this.Property(x => x.CopyRight).HasMaxLength(150);
            this.Property(x => x.Delivery_Date);
            this.Property(x => x.Consignee).HasMaxLength(200);
            this.Property(x => x.Notify).HasMaxLength(200);
            this.Property(x => x.Notify1).HasMaxLength(200);
            this.Property(x => x.WaehouseAddr).HasMaxLength(200);
            this.Property(x => x.Country).HasMaxLength(200);
            this.Property(x => x.Terms).HasMaxLength(50);

            //this.Property(x => x.Id).IsOptional();

            this.WithTraceable();
        }
    }
}

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
    public class ShipPackingMap : EntityTypeConfiguration<ShipPacking>
    {
        public ShipPackingMap()
        {
            this.ToTable("tpwl_ship_packing");

            this.HasKey(x => x.Id);
            this.Property(x => x.PackingAsk).HasMaxLength(100).IsOptional();
            this.Property(x => x.Contents).HasMaxLength(500).IsOptional();


            this.WithTraceable();

            this.HasRequired(x => x.ShipCarton).WithMany(y => y.Packings).HasForeignKey(x => x.CartonId);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            this.ToTable("tpwl_util_Cities");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(128).IsRequired();
            this.Property(x => x.ZipCode).HasMaxLength(32).IsRequired();
            
            this.HasRequired(x => x.Province).WithMany(y => y.Citys).HasForeignKey(k => k.ProvinceId).WillCascadeOnDelete(false);
        }
    }
}

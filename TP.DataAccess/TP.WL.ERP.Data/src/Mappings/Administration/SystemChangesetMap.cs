using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class SystemChangesetMap : EntityTypeConfiguration<SystemChangeset>
    {
        public SystemChangesetMap()
        {
            this.ToTable("tpwl_admin_SystemChangesets");
            
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.UserId).HasMaxLength(128).IsRequired();
            this.Property(x => x.UserName).HasMaxLength(256).IsRequired();
            this.Property(x => x.FullName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Memo).HasMaxLength(512);
            this.Property(x => x.IPAddress).HasMaxLength(50).IsRequired();
            this.Property(x => x.MacAddress).HasMaxLength(50).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();
        }
    }
}

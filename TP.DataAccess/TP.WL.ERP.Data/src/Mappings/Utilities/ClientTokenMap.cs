using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class ClientTokenMap : EntityTypeConfiguration<ClientToken>
    {
        public ClientTokenMap()
        {
            ToTable("tpwl_util_ClientTokens");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Name).HasMaxLength(128).IsRequired();
            this.Property(x => x.Secret).HasMaxLength(128).IsRequired();
            this.Property(x => x.IsActive).IsRequired();
            this.Property(x => x.RefreshTokenLifeTime).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();
        }
    }
}

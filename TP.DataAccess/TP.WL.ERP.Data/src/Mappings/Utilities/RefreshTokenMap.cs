using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class RefreshTokenMap : EntityTypeConfiguration<RefreshToken>
    {
        public RefreshTokenMap()
        {
            ToTable("tpwl_util_RefreshTokens");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.UserName).HasMaxLength(128).IsRequired();
            this.Property(x => x.ClientId).IsRequired();
            this.Property(x => x.IssuedUtc).IsRequired();
            this.Property(x => x.ExpiresUtc).IsRequired();
            this.Property(x => x.ProtectedTicket).HasMaxLength(1024).IsRequired();
        }
    }
}

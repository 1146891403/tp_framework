using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientBrandMap : EntityTypeConfiguration<ClientBrand>
    {
        public ClientBrandMap()
        {
            this.ToTable("tpwl_crm_ClientBrands");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Registration).HasMaxLength(256);
            this.Property(x => x.RegistrationDate);
            this.Property(x => x.Authorization).HasMaxLength(256);
            this.Property(x => x.AuthorizationDate);
            this.Property(x => x.SignDate);

            this.HasRequired(x => x.Client).WithMany(y => y.Brands).HasForeignKey(k => k.ClientId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.RegistrationFile).WithMany().HasForeignKey(k => k.RegistrationFileId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.AuthorizationFile).WithMany().HasForeignKey(k => k.AuthorizationFileId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

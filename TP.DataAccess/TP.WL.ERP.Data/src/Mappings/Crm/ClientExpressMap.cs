using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientExpressMap : EntityTypeConfiguration<ClientExpress>
    {
        public ClientExpressMap()
        {
            this.ToTable("tpwl_crm_ClientExpresses");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.Type).HasMaxLength(50);
            this.Property<ClientExpressCategory>(x => x.Category).IsRequired();
            this.Property(x => x.State).HasMaxLength(50);
            this.Property(x => x.PostalCode).HasMaxLength(20);
            this.Property(x => x.AddressLine1).HasMaxLength(256);
            this.Property(x => x.AddressLine2).HasMaxLength(256);
            this.Property(x => x.AddressLine3).HasMaxLength(256);
            this.Property(x => x.Contact).HasMaxLength(256).IsRequired();
            this.Property(x => x.Phone).HasMaxLength(20);
            this.Property(x => x.Fax).HasMaxLength(20);
            this.Property(x => x.IsDefault).IsRequired();

            this.HasRequired(x => x.Client).WithMany(y => y.Expresses).HasForeignKey(k => k.ClientId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

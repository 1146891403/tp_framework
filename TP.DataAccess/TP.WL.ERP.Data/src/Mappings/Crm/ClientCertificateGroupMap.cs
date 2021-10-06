using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientCertificateGroupMap : EntityTypeConfiguration<ClientCertificateGroup>
    {
        public ClientCertificateGroupMap()
        {
            this.ToTable("tpwl_crm_ClientCertificateGroups");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(50).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(128).IsRequired();
            this.Property(x => x.Remark).HasMaxLength(1024);

            this.HasRequired(x => x.Client).WithMany(y => y.CertificateGroups).HasForeignKey(k => k.ClientId).WillCascadeOnDelete(false);
            this.HasOptional(x => x.File).WithMany().HasForeignKey(k => k.FileId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

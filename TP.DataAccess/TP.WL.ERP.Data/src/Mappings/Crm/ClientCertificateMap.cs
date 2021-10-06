using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientCertificateMap : EntityTypeConfiguration<ClientCertificate>
    {
        public ClientCertificateMap()
        {
            this.ToTable("tpwl_crm_ClientCertificateInGroups");

            this.HasKey(x => new { x.GroupId, x.CertificateId });
        }
    }
}

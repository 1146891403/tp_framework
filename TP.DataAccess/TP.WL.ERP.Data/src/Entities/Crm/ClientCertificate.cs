namespace TP.WL.ERP.Data.Entities.Crm
{
    public class ClientCertificate
    {
        public long GroupId { get; set; }

        public virtual ClientCertificateGroup Group { get; set; }

        public long CertificateId { get; set; }

        public virtual Certificate Certificate { get; set; }
    }
}

using System;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Crm
{
    public class CertificateEditModel : EditModelBase
    {
        public string DisplayName { get; set; }

        public bool IsGuarantee { get; set; } = true;

        public bool IsTestReport { get; set; } = true;

        public bool IsGuaranteeOrReport { get; set; } = true;

        public decimal LifetimeScope { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsDefault { get; set; }
    }
}

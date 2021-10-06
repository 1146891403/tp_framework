using System;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Crm
{
    public class CertificateListModel : ListModelBase
    {
        public string DisplayName { get; set; }

        public bool IsGuarantee { get; set; }

        public bool IsTestReport { get; set; }

        public bool IsGuaranteeOrReport { get; set; }

        public decimal LifetimeScope { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsDefault { get; set; }
    }
}

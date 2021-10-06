using System.Collections.Generic;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Enums;
using TP.WL.ERP.Data.Entities.Crm;

namespace TP.WL.ERP.Data.Entities.Estimate
{
    public class EstimateRequest : ApplicationBase
    {
        public long ClientId { get; set; }

        public virtual Client Client { get; set; }

        public string ClientName { get; set; }

        public string ClientLevel { get; set; }

        public Currency Currency { get; set; }

        public string SalesmanId { get; set; }

        public virtual ApplicationUser Sales { get; set; }

        public string Salesman { get; set; }

        public virtual ICollection<EstimateComponent> Components { get; set; }
    }
}

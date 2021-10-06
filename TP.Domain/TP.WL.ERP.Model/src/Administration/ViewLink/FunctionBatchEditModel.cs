using System.Collections.Generic;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class FunctionBatchEditModel : EditModelBase
    {
        public long ViewLinkId { get; set; }

        public string DisplayName { get; set; }

        public IDictionary<FunctionCategory, string> Categories { get; set; } = new Dictionary<FunctionCategory, string>();
    }
}

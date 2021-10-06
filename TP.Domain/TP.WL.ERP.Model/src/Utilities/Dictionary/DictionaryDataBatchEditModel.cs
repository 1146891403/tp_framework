using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class DictionaryDataBatchEditModel : EditModelBase
    {
        public long TypeId { get; set; }

        public string Mode { get; set; } = BulkMode.Enter.ToString();

        public string Data { get; set; }

        public int ListOrder { get; set; }
    }
}

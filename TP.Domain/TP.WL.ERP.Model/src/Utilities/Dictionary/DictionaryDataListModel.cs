using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class DictionaryDataListModel : ListModelBase
    {
        public long TypeId { get; set; }

        public string DisplayName { get; set; }

        public string Value { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public string Remark { get; set; }
    }
}

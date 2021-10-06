using System.Collections.Generic;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class DictionaryTypeListModel : TreeListModelBase
    {
        public int ListOrder { get; set; }

        public string Remark { get; set; }

        public ICollection<DictionaryDataListModel> Items { get; set; }
    }
}

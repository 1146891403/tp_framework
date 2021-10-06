using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class DictionaryTypeEditModel : EditModelBase
    {
        public long ParentId { get; set; }

        public string DisplayName { get; set; }

        public int ListOrder { get; set; }

        public string Remark { get; set; }
    }
}

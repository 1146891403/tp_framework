using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class FunctionListModel : TreeListModelBase
    {
        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsFunction { get; set; } = false;
    }
}

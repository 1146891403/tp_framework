using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class ViewLinkListModel : TreeListModelBase
    {
        public string ViewName { get; set; }

        public string Description { get; set; }

        public string IconSource { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsGroup { get; set; } = false;
    }
}

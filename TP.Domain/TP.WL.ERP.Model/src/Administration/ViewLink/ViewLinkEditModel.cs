using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class ViewLinkEditModel : EditModelBase
    {
        public long ParentId { get; set; }

        public string ViewName { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string IconSource { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; } = true;

        public bool IsGroup { get; set; } = true;
    }
}

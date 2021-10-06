using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class FunctionEditModel : EditModelBase
    {
        public long ViewLinkId { get; set; }

        public string DisplayName { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; } = true;
    }
}

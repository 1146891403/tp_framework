using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class SubsidiaryEditModel : EditModelBase
    {
        public long ParentId { get; set; }

        public string DisplayName { get; set; }

        public string Category { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }
    }
}

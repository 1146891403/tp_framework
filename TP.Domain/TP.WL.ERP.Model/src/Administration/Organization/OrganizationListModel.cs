using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class OrganizationListModel : TreeListModelBase
    {
        public long SubsidiaryId { get; set; }

        public string Category { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }
    }
}
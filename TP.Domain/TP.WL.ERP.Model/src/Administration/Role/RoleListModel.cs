using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class RoleListModel : TreeListModelBase
    {
        public string Description { get; set; }

        public bool IsEnabled { get; set; }

        public long SubsidiaryId { get; set; }
    }
}

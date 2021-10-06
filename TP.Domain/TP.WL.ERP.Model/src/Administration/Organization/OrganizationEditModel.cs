using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class OrganizationEditModel : EditModelBase
    {
        public long ParentId { get; set; }

        public long SubsidiaryId { get; set; }

        public string DisplayName { get; set; }

        public string Category { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; } = true;
    }
}
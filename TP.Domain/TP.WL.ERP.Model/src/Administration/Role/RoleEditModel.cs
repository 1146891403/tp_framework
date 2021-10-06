using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class RoleEditModel : EditModelBase
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public bool IsEnabled { get; set; } = true;

        public long SubsidiaryId { get; set; }
    }
}

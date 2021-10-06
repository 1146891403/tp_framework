using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class DepartmentEditModel: EditModelBase
    {
        public long ParentId { get; set; }

        public string DisplayName { get; set; }

        public long SubsidiaryId { get; set; }
        
        public string Category { get; set; }

        public int ListOrder { get; set; }

        public bool IsEnabled { get; set; }
    }
}

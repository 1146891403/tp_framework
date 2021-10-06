using System.Collections.Generic;
using TP.Infrastructure.Common.Enums;

namespace TP.WL.ERP.Model.Administration
{
    public class NavigationListModel
    {
        public string DisplayName { get; set; }

        public string ViewName { get; set; }
        
        public NavigationCategory Category { get; set; }

        public int ListOrder { get; set; }

        public ICollection<NavigationListModel> Children { get; set; } = new List<NavigationListModel>();
    }
}

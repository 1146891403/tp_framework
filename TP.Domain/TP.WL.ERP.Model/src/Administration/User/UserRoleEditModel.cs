using System.Collections.Generic;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class UserRoleEditModel : EditModelBase
    {
        public IDictionary<string, string> Users { get; set; } = new Dictionary<string, string>();
    }
}

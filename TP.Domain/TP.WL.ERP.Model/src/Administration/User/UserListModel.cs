using System;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class UserListModel : ListModelBase
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Alias { get; set; }
        
        public string Gender { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public DateTime JoinDate { get; set; }

        public bool Status { get; set; }
    }
}

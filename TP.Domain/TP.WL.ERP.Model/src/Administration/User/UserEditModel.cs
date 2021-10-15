using System;
using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Administration
{
    public class UserEditModel : EditModelBase
    {
        public UserEditModel()
        {
            JoinDate = DateTime.Now;
        }

        public string UserId { get; set; }
        
        public string UserName { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Alias { get; set; }

        public string StaffNumber { get; set; }

        public string Gender { get; set; }

        public DateTime JoinDate { get; set; }

        public string Designation { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public long SubsidiaryId { get; set; }

        public long DepartmentId { get; set; }

        public bool LockoutEnabled { get; set; }

        public string Remark { get; set; }
    }
}

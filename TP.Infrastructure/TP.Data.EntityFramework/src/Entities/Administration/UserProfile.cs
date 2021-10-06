using System;
using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Enums;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class UserProfile : EntityBase<string>, ITraceable
    {
        public virtual ApplicationUser User { get; set; }

        public string FullName { get; set; }

        public string Alias { get; set; }

        public string StaffNumber { get; set; }

        public Gender Gender { get; set; }
        
        public string Designation { get; set; }

        public DateTime JoinDate { get; set; }

        public string Tel { get; set; }

        public string Remark { get; set; }

        public long SubsidiaryId { get; set; }

        public virtual Subsidiary Subsidiary { get; set; }

        public long DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModificatorId { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

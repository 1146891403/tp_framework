using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Enums;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            ToTable("tpwl_admin_UserProfiles");
            
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("UserId");

            this.Property(x => x.FullName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Alias).HasMaxLength(256);
            this.Property(x => x.StaffNumber).HasMaxLength(32);
            this.Property<Gender>(x => x.Gender).IsRequired();
            this.Property(x => x.Designation).HasMaxLength(256);
            this.Property(x => x.JoinDate);
            this.Property(x => x.Tel).HasMaxLength(20);
            this.Property(x => x.Remark).HasMaxLength(1024);

            this.HasRequired(x => x.User).WithRequiredDependent(y => y.Profile);

            this.HasRequired(x => x.Subsidiary).WithMany(y => y.Staffs).HasForeignKey(k => k.SubsidiaryId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Department).WithMany(y => y.Staffs).HasForeignKey(k => k.DepartmentId).WillCascadeOnDelete(false);
            
            this.WithTraceable();
        }
    }
}

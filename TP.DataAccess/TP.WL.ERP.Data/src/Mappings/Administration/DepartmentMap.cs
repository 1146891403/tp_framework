using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            ToTable("tpwl_admin_Departments");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Category).HasMaxLength(128).IsRequired();
            this.Property(x => x.ListOrder).IsRequired();
            this.Property(x => x.IsEnabled).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();
            this.Property(x => x.ModifyDate).IsRequired();

            this.HasOptional(x => x.Parent).WithMany(y => y.Children).HasForeignKey(k => k.ParentId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Subsidiary).WithMany(y => y.Departments).HasForeignKey(k => k.SubsidiaryId).WillCascadeOnDelete(false);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.WL.ERP.Data.Mappings.Administration
{
    public class GroupMap : EntityTypeConfiguration<ApplicationGroup>
    {
        public GroupMap()
        {
            ToTable("tpwl_admin_Groups");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Description).HasMaxLength(1024);
            this.Property(x => x.CreateDate);
            
            this.HasOptional(x => x.Parent).WithMany(y => y.Children).HasForeignKey(k => k.ParentId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Creator).WithMany().HasForeignKey(k => k.CreatorId).WillCascadeOnDelete(false);
            
            this.HasMany(x => x.Users).WithRequired().HasForeignKey(k => k.GroupId);
            this.HasMany(x => x.Roles).WithRequired().HasForeignKey(k => k.GroupId);
        }
    }
}

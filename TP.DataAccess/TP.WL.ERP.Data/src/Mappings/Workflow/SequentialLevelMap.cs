using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings
{
    public class SequentialLevelMap : EntityTypeConfiguration<SequentialLevel>
    {
        public SequentialLevelMap()
        {
            this.ToTable("tpwl_wfs_SequentialLevels");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Level).IsRequired();
            
            this.HasRequired(x => x.Setting).WithMany(y => y.Sequences).HasForeignKey(k => k.SettingId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Checker).WithMany().HasForeignKey(k => k.CheckerId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

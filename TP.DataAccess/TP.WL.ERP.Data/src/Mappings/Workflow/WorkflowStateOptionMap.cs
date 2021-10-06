using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings
{
    public class WorkflowStateOptionMap : EntityTypeConfiguration<WorkflowStateOption>
    {
        public WorkflowStateOptionMap()
        {
            this.ToTable("tpwl_wfs_WorkflowStateOptions");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Priority).IsRequired();
            this.Property(x => x.Eval).HasMaxLength(1024).IsRequired();
            
            this.HasRequired(x => x.State).WithMany(y => y.Options).HasForeignKey(k => k.StateId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Destinagion).WithMany().HasForeignKey(k => k.DestinagionId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

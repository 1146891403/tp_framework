using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings
{
    public class WorkflowStateMap : EntityTypeConfiguration<WorkflowState>
    {
        public WorkflowStateMap()
        {
            this.ToTable("tpwl_wfs_WorkflowStates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(50).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256);
            this.Property<WorkflowStateType>(x => x.Type).IsRequired();
            this.Property(x => x.Comment).HasMaxLength(512);
            
            this.HasOptional(x => x.Destinagion).WithMany().HasForeignKey(k => k.DestinagionId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;

namespace TP.WL.ERP.Data.Mappings
{
    public class BasicWorkflowStateMap : EntityTypeConfiguration<BasicWorkflowState>
    {
        public BasicWorkflowStateMap()
        {
            this.ToTable("tpwl_wfs_BasicWorkflowStates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("WorkflowStateId");
            
            this.HasRequired(x => x.Checker).WithMany().HasForeignKey(k => k.CheckerId).WillCascadeOnDelete(false);
        }
    }
}

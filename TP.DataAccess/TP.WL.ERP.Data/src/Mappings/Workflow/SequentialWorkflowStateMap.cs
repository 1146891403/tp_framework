using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;

namespace TP.WL.ERP.Data.Mappings
{
    public class SequentialWorkflowStateMap : EntityTypeConfiguration<SequentialWorkflowState>
    {
        public SequentialWorkflowStateMap()
        {
            this.ToTable("tpwl_wfs_SequentialWorkflowStates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnName("WorkflowStateId");
        }
    }
}

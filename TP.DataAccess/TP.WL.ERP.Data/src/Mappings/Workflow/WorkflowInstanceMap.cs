using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings
{
    public class WorkflowInstanceMap : EntityTypeConfiguration<WorkflowInstance>
    {
        public WorkflowInstanceMap()
        {
            this.ToTable("tpwl_wfs_WorkflowInstances");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Level).IsRequired();
            
            this.HasRequired(x => x.Workflow).WithMany().HasForeignKey(k => k.WorkflowId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Applicant).WithMany().HasForeignKey(k => k.ApplicantId).WillCascadeOnDelete(false);
            this.HasOptional(x => x.State).WithMany().HasForeignKey(k => k.StateId).WillCascadeOnDelete(false);
            this.HasOptional(x => x.Checker).WithMany().HasForeignKey(k => k.CheckerId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

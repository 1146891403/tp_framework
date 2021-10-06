using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings
{
    public class SequentialWorkflowStateSettingMap : EntityTypeConfiguration<SequentialWorkflowStateSetting>
    {
        public SequentialWorkflowStateSettingMap()
        {
            this.ToTable("tpwl_wfs_SequentialWorkflowStateSettings");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            this.HasRequired(x => x.State).WithMany().HasForeignKey(k => k.StateId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Applicant).WithMany().HasForeignKey(k => k.ApplicantId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

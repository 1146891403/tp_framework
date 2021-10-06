using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings
{
    public class WorkflowMap : EntityTypeConfiguration<Workflow>
    {
        public WorkflowMap()
        {
            this.ToTable("tpwl_wfs_Workflows");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            this.Property(x => x.ApplicationName).HasMaxLength(128);
            this.Property(x => x.Comment).HasMaxLength(512);
            
            this.HasRequired(x => x.InitialState).WithMany().HasForeignKey(k => k.InitialStateId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

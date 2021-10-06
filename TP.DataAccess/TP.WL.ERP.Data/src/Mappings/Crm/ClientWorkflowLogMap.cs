using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientWorkflowLogMap : EntityTypeConfiguration<ClientWorkflowLog>
    {
        public ClientWorkflowLogMap()
        {
            this.ToTable("tpwl_crm_ClientWorkflowLogs");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.WithWorkflowLog();
            this.WithTraceable();
        }
    }
}

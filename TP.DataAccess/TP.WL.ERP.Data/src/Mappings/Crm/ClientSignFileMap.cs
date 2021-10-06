using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientSignFileMap : EntityTypeConfiguration<ClientSignFile>
    {
        public ClientSignFileMap()
        {
            this.ToTable("tpwl_crm_ClientSignFiles");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            this.Property(x => x.Type).HasMaxLength(128).IsRequired();
            this.Property(x => x.SignDate);

            this.HasRequired(x => x.Client).WithMany(y => y.SignFiles).HasForeignKey(k => k.ClientId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.File).WithMany().HasForeignKey(k => k.FileId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}

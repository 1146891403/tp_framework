using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Net.Mail;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class MailTemplateMap : EntityTypeConfiguration<MailTemplate>
    {
        public MailTemplateMap()
        {
            ToTable("tpwl_util_MailTemplates");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.Number).HasMaxLength(32).IsRequired();
            this.Property(x => x.Description).HasMaxLength(256);
            this.Property(x => x.Recipients).HasMaxLength(1024).IsRequired();
            this.Property(x => x.CopyRecipients).HasMaxLength(1024);
            this.Property(x => x.BlindCopyRecipients).HasMaxLength(1024);
            this.Property(x => x.Subject).HasMaxLength(512).IsRequired();
            this.Property(x => x.Body).HasMaxLength(4096).IsRequired();
            this.Property(x => x.IsBodyHtml).IsRequired();
            this.Property<MailPriority>(x => x.Priority).IsRequired();
            this.Property(x => x.Comment).HasMaxLength(1024);
            this.Property(x => x.CreateDate).IsRequired();
        }
    }
}

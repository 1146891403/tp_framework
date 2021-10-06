using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class FileCabinetMap : EntityTypeConfiguration<FileCabinet>
    {
        public FileCabinetMap()
        {
            this.ToTable("tpwl_util_FileCabinets");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.FileName).HasMaxLength(256).IsRequired();
            this.Property(x => x.ContentType).HasMaxLength(128).IsRequired();
            this.Property(x => x.ContentLength).IsRequired();
            this.Property(x => x.LocalFileName).HasMaxLength(1024).IsRequired();
            this.Property<FileStatus>(x => x.Status).IsRequired();
            this.Property(x => x.CreateDate).IsRequired();

            this.HasRequired(x => x.Owner).WithMany().HasForeignKey(k => k.OwnerId).WillCascadeOnDelete(false);
        }
    }
}

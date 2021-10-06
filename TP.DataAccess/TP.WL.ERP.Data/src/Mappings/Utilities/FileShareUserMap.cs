using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class FileShareUserMap : EntityTypeConfiguration<FileShareUser>
    {
        public FileShareUserMap()
        {
            this.ToTable("tpwl_util_FileShareInUsers");

            this.HasKey(x => new { x.FileId, x.UserId });
        }
    }
}

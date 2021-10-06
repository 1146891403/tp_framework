using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities.Utilities;

namespace TP.WL.ERP.Data.Mappings.Utilities
{
    public class FileShareRoleMap : EntityTypeConfiguration<FileShareRole>
    {
        public FileShareRoleMap()
        {
            this.ToTable("tpwl_util_FileShareInRoles");

            this.HasKey(x => new { x.FileId, x.RoleId });
        }
    }
}

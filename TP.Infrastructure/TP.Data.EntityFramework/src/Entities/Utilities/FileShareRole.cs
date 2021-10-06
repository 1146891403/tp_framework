namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class FileShareRole
    {
        public long FileId { get; set; }

        public virtual FileCabinet File { get; set; }

        public string RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }
    }
}

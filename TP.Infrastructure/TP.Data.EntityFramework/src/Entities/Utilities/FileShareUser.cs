namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class FileShareUser
    {
        public long FileId { get; set; }

        public virtual FileCabinet File { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}

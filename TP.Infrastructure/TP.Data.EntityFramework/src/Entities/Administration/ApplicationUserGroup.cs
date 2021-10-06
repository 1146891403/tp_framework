namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ApplicationUserGroup
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public long GroupId { get; set; }

        public virtual ApplicationGroup Group { get; set; }
    }
}

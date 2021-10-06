namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ApplicationRoleView
    {
        public string RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }

        public long ViewLinkId { get; set; }

        public virtual ViewLink ViewLink { get; set; }
    }
}

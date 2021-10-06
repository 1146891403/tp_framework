namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ApplicationRoleGroup
    {
        public string RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }

        public long GroupId { get; set; }

        public virtual ApplicationGroup Group { get; set; }
    }
}

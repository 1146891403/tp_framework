namespace TP.Data.EntityFramework.Entities.Administration
{
    public class ApplicationRoleFunction
    {
        public string RoleId { get; set; }

        public virtual ApplicationRole Role { get; set; }

        public long FunctionId { get; set; }

        public virtual ViewLinkFunction Function { get; set; }
    }
}

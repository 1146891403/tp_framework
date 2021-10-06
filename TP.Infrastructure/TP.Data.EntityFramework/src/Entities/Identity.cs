using Microsoft.AspNet.Identity.EntityFramework;

namespace TP.Data.EntityFramework.Entities
{
    public class ApplicationUserLogin : IdentityUserLogin<string>
    {
    }

    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
    }

    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public ApplicationUserRole()
            : base()
        { }

        public virtual ApplicationRole Role { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
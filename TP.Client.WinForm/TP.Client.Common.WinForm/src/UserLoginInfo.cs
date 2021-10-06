using System.Collections.Generic;
using TP.Infrastructure.Common.Enums;

namespace TP.Client.WinForm.Common
{
    public class UserLoginInfo
    {
        private static UserLoginInfo currentUser = null;
        private readonly static object syncObject = new object();

        private UserLoginInfo() { }

        public static UserLoginInfo Current
        {
            get
            {
                if (currentUser == null)
                {
                    lock(syncObject)
                    {
                        if(currentUser == null)
                            currentUser = new UserLoginInfo();

                    }
                }

                return currentUser;
            }
        }

        public bool Succeeded { get; set; } = false;

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Token { get; set; }

        public IEnumerable<UserNavigation> Navigations { get; set; }

        public IEnumerable<string> Functions { get; set; }
    }

    public class UserNavigation
    {
        public string Name { get; set; }

        public string Text { get; set; }
        
        public NavigationCategory Category { get; set; }

        public ICollection<UserNavigation> Children { get; set; }
    }
}

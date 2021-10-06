using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class LoginActivity : EntityBaseOfLong
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Memo { get; set; }

        public string IPAddress { get; set; }

        public string MacAddress { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

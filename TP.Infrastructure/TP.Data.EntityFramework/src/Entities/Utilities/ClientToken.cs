using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class ClientToken : EntityBaseOfLong
    {
        public string Name { get; set; }

        public string Secret { get; set; }

        public bool IsActive { get; set; }

        public int RefreshTokenLifeTime { get; set; }

        public DateTime CreateDate { get; set; }
    }
}

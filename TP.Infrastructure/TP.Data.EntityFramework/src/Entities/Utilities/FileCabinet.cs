using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class FileCabinet : EntityBaseOfLong
    {
        public string FileName { get; set; }

        public string ContentType { get; set; }

        public long ContentLength { get; set; }

        public string LocalFileName { get; set; }

        public FileStatus Status { get; set; }

        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

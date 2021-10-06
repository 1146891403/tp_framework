using System;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class NumberTemplate : EntityBaseOfLong
    {
        public string Number { get; set; }
        
        public string Description { get; set; }
        
        public string Body { get; set; }
        
        public int Seed { get; set; }
        
        public NumberFormat Format { get; set; }
        
        public string Comment { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

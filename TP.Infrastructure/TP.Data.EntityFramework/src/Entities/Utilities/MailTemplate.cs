using System;
using System.Net.Mail;
using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class MailTemplate : EntityBaseOfLong
    {
        public string Number { get; set; }
        
        public string Description { get; set; }
        
        public string Recipients { get; set; }
        
        public string CopyRecipients { get; set; }
        
        public string BlindCopyRecipients { get; set; }
        
        public string Subject { get; set; }
        
        public string Body { get; set; }
        
        public  bool IsBodyHtml { get; set; }
        
        public MailPriority Priority { get; set; }
        
        public string Comment { get; set; }
        
        public DateTime CreateDate { get; set; }
    }
}

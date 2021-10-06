using System;

namespace TP.WL.ERP.Model.Utilities
{
    public class RefreshTokenEditModel
    {
        public string UserName { get; set; }

        public string ClientId { get; set; }

        public DateTime IssuedUtc { get; set; }

        public DateTime ExpiresUtc { get; set; }

        public string ProtectedTicket { get; set; }
    }
}

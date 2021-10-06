using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class NumberInstanceListModel : ListModelBase
    {
        public string ApplicationName { get; set; }

        public string Prefix { get; set; }

        public int Seed { get; set; }

        public bool IsEnabled { get; set; }
    }
}

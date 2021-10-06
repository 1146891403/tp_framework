using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class NumberTemplateListModel : ListModelBase
    {
        public string Description { get; set; }

        public string Body { get; set; }

        public string ResetCriterion { get; set; }

        public int Seed { get; set; }

        public string Format { get; set; }
    }
}

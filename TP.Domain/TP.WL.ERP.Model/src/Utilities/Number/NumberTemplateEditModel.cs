using TP.Infrastructure.Common.Model;

namespace TP.WL.ERP.Model.Utilities
{
    public class NumberTemplateEditModel : EditModelBase
    {
        public string Description { get; set; }

        public string Body { get; set; }

        public string ResetCriterion { get; set; }

        public int Seed { get; set; }

        public string Format { get; set; }

        public string Comment { get; set; }
    }
}

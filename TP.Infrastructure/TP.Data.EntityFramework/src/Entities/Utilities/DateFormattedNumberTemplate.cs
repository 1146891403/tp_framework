using System.Collections.Generic;

namespace TP.Data.EntityFramework.Entities.Utilities
{
    public class DateFormattedNumberTemplate : NumberTemplate
    {
        public string ResetCriterion { get; set; }
        
        public virtual ICollection<DateFormattedNumberInstance> Instances { get; set; }
    }
}

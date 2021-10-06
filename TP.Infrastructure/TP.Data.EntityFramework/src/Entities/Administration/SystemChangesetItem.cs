using TP.Infrastructure.Common.Entities;

namespace TP.Data.EntityFramework.Entities.Administration
{
    public class SystemChangesetItem : EntityBaseOfLong
    {
        public long ChangesetId { get; set; }

        public virtual SystemChangeset Changeset { get; set; }

        public string EntityName { get; set; }

        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}

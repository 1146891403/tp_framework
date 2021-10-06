namespace TP.Infrastructure.Common.Model
{
    public class TreeListModelBase : ListModelBase
    {
        public long ParentId { get; set; }
        
        public string DisplayName { get; set; }
    }
}

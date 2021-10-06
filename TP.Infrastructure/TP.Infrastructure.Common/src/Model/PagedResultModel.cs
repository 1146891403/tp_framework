using System.Collections.Generic;

namespace TP.Infrastructure.Common.Model
{
    public class PagedResultModel<TListModel> where TListModel : ListModelBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
        
        public IEnumerable<TListModel> Models { get; set; }
    }
}

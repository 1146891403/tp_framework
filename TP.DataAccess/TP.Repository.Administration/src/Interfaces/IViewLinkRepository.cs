using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IViewLinkRepository : IRepository
    {
        Task<IEnumerable<ViewLinkDirectory>> FindAllAsync();

        Task<IEnumerable<ViewLinkDirectory>> FindAllEnabledAsync();

        Task<IEnumerable<ViewLinkDirectory>> FindDirectoriesAsync();

        Task<IEnumerable<ViewLinkDirectory>> FindDirectoriesAsync(IEnumerable<long> ids);

        Task<IEnumerable<ViewLink>> FindLinksAsync(long directoryId);

        Task<ViewLinkDirectory> FindDirectoryByIdAsync(long id);

        Task<ViewLink> FindLinkByIdAsync(long id);

        Task<IEnumerable<ViewLinkFunction>> FindFunctionsAsync();

        Task<IEnumerable<ViewLinkFunction>> FindFunctionsAsync(long linkId);

        Task<IEnumerable<ViewLinkFunction>> FindFunctionsAsync(IEnumerable<long> linkIds);

        Task<ViewLinkFunction> FindFunctionByIdAsync(long id);

        Task<bool> InsertDirectoryAsync(ViewLinkDirectory directory);

        Task<bool> InsertLinkAsync(ViewLink link);

        Task<bool> InsertFunctionAsync(ViewLinkFunction function);

        Task<bool> BulkInsertFunctionsAsync(IEnumerable<ViewLinkFunction> functions);

        Task<bool> UpdateDirectoryAsync(ViewLinkDirectory directory);

        Task<bool> UpdateLinkAsync(ViewLink link);

        Task<bool> UpdateFunctionAsync(ViewLinkFunction function);
    }
}

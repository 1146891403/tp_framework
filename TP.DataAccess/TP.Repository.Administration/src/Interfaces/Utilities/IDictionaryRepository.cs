using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IDictionaryRepository : IRepository
    {
        Task<IEnumerable<DictionaryType>> FindTypesAsync();

        Task<IEnumerable<DictionaryType>> FindTypesByParentAsync(long? parentId);

        Task<IEnumerable<DictionaryData>> FindDatasByTypeAsync(long typeId);

        Task<DictionaryType> FindTypeByIdAsync(long id);

        Task<DictionaryData> FindDataByIdAsync(long id);

        Task<bool> InsertTypeAsync(DictionaryType type);

        Task<bool> InsertDataAsync(DictionaryData data);

        Task<bool> BulkInsertDatasAsync(IEnumerable<DictionaryData> datas);

        Task<bool> UpdateTypeAsync(DictionaryType type);

        Task<bool> UpdateDataAsync(DictionaryData data);
    }
}

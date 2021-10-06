using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class DictionaryRepository : IDictionaryRepository
    {
        private readonly IRepositoryOfLong<DictionaryType> _dictionaryTypeRepository;
        private readonly IRepositoryOfLong<DictionaryData> _dictionaryDataRepository;

        public DictionaryRepository(IRepositoryOfLong<DictionaryType> dictionaryTypeRepository, IRepositoryOfLong<DictionaryData> dictionaryDataRepository)
        {
            _dictionaryTypeRepository = dictionaryTypeRepository ?? throw new ArgumentNullException(nameof(dictionaryTypeRepository));
            _dictionaryDataRepository = dictionaryDataRepository ?? throw new ArgumentNullException(nameof(dictionaryDataRepository));
        }

        public async Task<IEnumerable<DictionaryType>> FindTypesAsync()
        {
            return await _dictionaryTypeRepository.GetAllListAsync();
        }

        public async Task<IEnumerable<DictionaryType>> FindTypesByParentAsync(long? parentId)
        {
            return await _dictionaryTypeRepository.GetAllListAsync(x => x.ParentId == parentId);
        }

        public async Task<DictionaryType> FindTypeByIdAsync(long id)
        {
            return await _dictionaryTypeRepository.GetAsync(id);
        }

        public async Task<IEnumerable<DictionaryData>> FindDatasByTypeAsync(long typeId)
        {
            return await _dictionaryDataRepository.GetAllListAsync(x => x.TypeId == typeId);
        }

        public async Task<DictionaryData> FindDataByIdAsync(long id)
        {
            return await _dictionaryDataRepository.GetAsync(id);
        }

        public async Task<bool> InsertTypeAsync(DictionaryType type)
        {
            await _dictionaryTypeRepository.InsertAsync(type);

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertDataAsync(DictionaryData data)
        {
            await _dictionaryDataRepository.InsertAsync(data);

            return await Task.FromResult(true);
        }

        public async Task<bool> BulkInsertDatasAsync(IEnumerable<DictionaryData> datas)
        {
            await _dictionaryDataRepository.BulkInsertAsync(datas);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateTypeAsync(DictionaryType type)
        {
            await _dictionaryTypeRepository.UpdateAsync(type);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateDataAsync(DictionaryData data)
        {
            await _dictionaryDataRepository.UpdateAsync(data);

            return await Task.FromResult(true);
        }
    }
}

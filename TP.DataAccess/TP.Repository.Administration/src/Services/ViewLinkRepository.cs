using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TP.Repository.Administration.Interfaces;
using TP.Infrastructure.Common.Repository;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.Repository.Administration.Services
{
    public class ViewLinkRepository : IViewLinkRepository
    {
        private readonly IRepositoryOfLong<ViewLinkDirectory> _directoryRepository;
        private readonly IRepositoryOfLong<ViewLink> _linkRepository;
        private readonly IRepositoryOfLong<ViewLinkFunction> _functionRepository;

        public ViewLinkRepository(IRepositoryOfLong<ViewLinkDirectory> directoryRepository, IRepositoryOfLong<ViewLink> linkRepository, IRepositoryOfLong<ViewLinkFunction> functionRepository)
        {
            _directoryRepository = directoryRepository ?? throw new ArgumentNullException(nameof(directoryRepository));
            _linkRepository = linkRepository ?? throw new ArgumentNullException(nameof(linkRepository));
            _functionRepository = functionRepository ?? throw new ArgumentNullException(nameof(functionRepository));
        }
        
        public async Task<IEnumerable<ViewLinkDirectory>> FindAllAsync()
        {
            return await _directoryRepository.GetAllIncluding(x => x.Links).ToListAsync();
        }

        public async Task<IEnumerable<ViewLinkDirectory>> FindAllEnabledAsync()
        {
            return await _directoryRepository.GetAllIncluding(x => x.Links).Where(x => x.IsEnabled).ToListAsync();
        }

        public async Task<IEnumerable<ViewLinkDirectory>> FindDirectoriesAsync()
        {
            return await _directoryRepository.GetAllListAsync();
        }
        
        public async Task<IEnumerable<ViewLinkDirectory>> FindDirectoriesAsync(IEnumerable<long> ids)
        {
            return await _directoryRepository.GetAll().Where(x => ids.Contains(x.Id)).ToListAsync();
        }

        public async Task<IEnumerable<ViewLink>> FindLinksAsync(long directoryId)
        {
            return await _linkRepository.GetAllListAsync(x => x.ParentId == directoryId);
        }

        public async Task<ViewLinkDirectory> FindDirectoryByIdAsync(long id)
        {
            return await _directoryRepository.GetAsync(id);
        }

        public async Task<ViewLink> FindLinkByIdAsync(long id)
        {
            return await _linkRepository.GetAsync(id);
        }

        public async Task<IEnumerable<ViewLinkFunction>> FindFunctionsAsync()
        {
            return await _functionRepository.GetAllIncluding(x => x.ViewLink.Parent).Where(x => x.IsEnabled).ToListAsync();
        }

        public async Task<IEnumerable<ViewLinkFunction>> FindFunctionsAsync(long linkId)
        {
            return await _functionRepository.GetAllListAsync(x => x.ViewLinkId == linkId);
        }

        public async Task<IEnumerable<ViewLinkFunction>> FindFunctionsAsync(IEnumerable<long> linkIds)
        {
            return await _functionRepository.GetAllIncluding(x => x.ViewLink.Parent)
                .Where(x => linkIds.Contains(x.ViewLinkId)).ToListAsync();
        }

        public async Task<ViewLinkFunction> FindFunctionByIdAsync(long id)
        {
            return await _functionRepository.GetAsync(id);
        }

        public async Task<bool> InsertDirectoryAsync(ViewLinkDirectory directory)
        {
            await _directoryRepository.InsertAsync(directory);

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertLinkAsync(ViewLink link)
        {
            await _linkRepository.InsertAsync(link);

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertFunctionAsync(ViewLinkFunction function)
        {
            await _functionRepository.InsertAsync(function);

            return await Task.FromResult(true);
        }

        public async Task<bool> BulkInsertFunctionsAsync(IEnumerable<ViewLinkFunction> functions)
        {
            await _functionRepository.BulkInsertAsync(functions);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateDirectoryAsync(ViewLinkDirectory directory)
        {
            await _directoryRepository.UpdateAsync(directory);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateLinkAsync(ViewLink link)
        {
            await _linkRepository.UpdateAsync(link);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateFunctionAsync(ViewLinkFunction function)
        {
            await _functionRepository.UpdateAsync(function);

            return await Task.FromResult(true);
        }
    }
}

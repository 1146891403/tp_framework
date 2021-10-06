using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class NumberRepository : INumberRepository
    {
        private readonly IRepositoryOfLong<DateFormattedNumberTemplate> _templateRepository;
        private readonly IRepositoryOfLong<DateFormattedNumberInstance> _instanceRepository;

        public NumberRepository(IRepositoryOfLong<DateFormattedNumberTemplate> templateRepository, IRepositoryOfLong<DateFormattedNumberInstance> instanceRepository)
        {
            _templateRepository = templateRepository ?? throw new ArgumentNullException(nameof(templateRepository));
            _instanceRepository = instanceRepository ?? throw new ArgumentNullException(nameof(instanceRepository));
        }

        public async Task<IEnumerable<DateFormattedNumberTemplate>> FindTemplatesAsync()
        {
            return await _templateRepository.GetAllListAsync();
        }

        public async Task<IEnumerable<DateFormattedNumberInstance>> FindInstancesAsync()
        {
            return await _instanceRepository.GetAllListAsync();
        }

        public async Task<bool> InsertTemplateAsync(DateFormattedNumberTemplate template)
        {
            await _templateRepository.InsertAsync(template);

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertInstanceAsync(DateFormattedNumberInstance instance)
        {
            await _instanceRepository.InsertAsync(instance);

            return await Task.FromResult(true);
        }
    }
}

using System;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Async;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Utility.Interfaces;

namespace TP.Repository.Utility.Services
{
    public class NumberRepository : INumberRepository
    {
        private readonly object syncObject = new object();
        private readonly AsyncLock aLock = new AsyncLock();

        private readonly IRepositoryOfLong<DateFormattedNumberInstance> _numberInstanceRepository;

        public NumberRepository(IRepositoryOfLong<DateFormattedNumberInstance> numberInstanceRepository)
        {
            _numberInstanceRepository = numberInstanceRepository ?? throw new ArgumentNullException(nameof(numberInstanceRepository));
        }

        public async Task<string> GenerateAsync(string applicationName, long subsidiaryId)
        {
            using (var releaser = await aLock.LockAsync())
            {
                var numberInstance = await _numberInstanceRepository.FirstOrDefaultAsync(x => x.ApplicationName == applicationName && x.SubsidiaryId == subsidiaryId, s => s.Template);

                if (numberInstance == null)
                    throw new InvalidOperationException("單號模板不存在，請聯繫系統管理員獲取更多信息！");

                var template = numberInstance.Template;

                DateTime lastGenerateDate = numberInstance.LastGenerateDate;
                numberInstance.LastGenerateDate = DateTime.Now;

                if (string.Format(template.ResetCriterion, numberInstance.LastGenerateDate) == string.Format(template.ResetCriterion, lastGenerateDate))
                    numberInstance.Seed++;
                else
                    numberInstance.Seed = template.Seed;

                await _numberInstanceRepository.UpdateAsync(numberInstance);

                var number = string.Format(template.Body, numberInstance.Prefix, numberInstance.LastGenerateDate, numberInstance.Seed);

                return await Task.FromResult(number);
            }
        }
    }
}

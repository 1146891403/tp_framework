using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Repository.Crm.Interfaces;

namespace TP.WL.ERP.Repository.Crm.Services
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly IRepositoryOfLong<Certificate> _certificateRepository;

        public CertificateRepository(IRepositoryOfLong<Certificate> certificateRepository)
        {
            _certificateRepository = certificateRepository ?? throw new ArgumentNullException(nameof(certificateRepository));
        }

        public async Task<IEnumerable<Certificate>> GetAllAsync()
        {
            return await _certificateRepository.GetAllListAsync();
        }

        public async Task<Certificate> FindByIdAsync(long id)
        {
            return await _certificateRepository.GetAsync(id);
        }

        public async Task<bool> InsertAsync(Certificate certificate)
        {
            await _certificateRepository.InsertAsync(certificate);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Certificate certificate)
        {
            await _certificateRepository.UpdateAsync(certificate);

            return await Task.FromResult(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Repository.Crm.Interfaces;

namespace TP.WL.ERP.Repository.Crm.Services
{
    public class ClientRepository : IClientRepository
    {
        private readonly IRepositoryOfLong<Client> _clientRepository;

        public ClientRepository(IRepositoryOfLong<Client> clientRepository)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        public async Task<Client> FindByNumberAsync(string number)
        {
            return await _clientRepository.FirstOrDefaultAsync(x => x.Number == number);
        }

        public async Task<IEnumerable<Client>> GetClientsAsync(string userId)
        {
            return await _clientRepository.GetAllListAsync(x => x.ApplicantId == userId);
        }

        public async Task<IEnumerable<ClientBrand>> GetBrandsAsync(long clientId)
        {
            throw new Exception();
        }

        public Task<IEnumerable<ClientCertificateGroup>> GetCertificateGroupsAsync(long clientId)
        {
            throw new NotImplementedException();
        }

        //public Task<IEnumerable<Certificate>> GetCertificatesAsync(long groupId)
        //{
        //    throw new NotImplementedException();
        //}

        public Task<IEnumerable<ClientSignFile>> GetSignFilesAsync(long clientId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientContact>> GetContactsAsync(long clientId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientExpress>> GetExpressesAsync(long clientId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertClientAsync(Client client)
        {
            await _clientRepository.InsertAsync(client);

            throw new NotImplementedException();
        }

        public Task<bool> UpdateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}

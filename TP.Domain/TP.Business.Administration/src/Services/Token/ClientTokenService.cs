using System;
using System.Threading.Tasks;
using TP.Business.Administration.Interfaces;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Repository.Administration.Interfaces;

namespace TP.Business.Administration.Services
{
    public class ClientTokenService : IClientTokenService
    {
        private IClientTokenRepository _clientTokenRepository;

        public ClientTokenService(IClientTokenRepository clientTokenRepository)
        {
            _clientTokenRepository = clientTokenRepository ?? throw new ArgumentNullException(nameof(clientTokenRepository));
        }

        public async Task<ClientToken> Get(long clientId)
        {
            return await _clientTokenRepository.FindByIdAsync(clientId);
        }
    }
}

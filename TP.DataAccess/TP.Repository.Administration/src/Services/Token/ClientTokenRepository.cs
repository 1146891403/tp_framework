using System;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class ClientTokenRepository : IClientTokenRepository
    {
        private readonly IRepositoryOfLong<ClientToken> _tokenRepository;

        public ClientTokenRepository(IRepositoryOfLong<ClientToken> tokenRepository)
        {
            _tokenRepository = tokenRepository ?? throw new ArgumentNullException(nameof(tokenRepository));
        }
        
        public async Task<ClientToken> FindByIdAsync(long id)
        {
            return await _tokenRepository.GetAsync(id);
        }
    }
}
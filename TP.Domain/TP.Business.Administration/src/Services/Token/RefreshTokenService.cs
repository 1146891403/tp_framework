using System;
using System.Threading.Tasks;
using TP.Business.Administration.Interfaces;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Repository.Administration.Interfaces;

namespace TP.Business.Administration.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private IRefreshTokenRepository _refreshTokenRepository;

        public RefreshTokenService(IRefreshTokenRepository refreshTokenRepository)
        {
            _refreshTokenRepository = refreshTokenRepository ?? throw new ArgumentNullException(nameof(refreshTokenRepository));
        }
        
        public async Task<RefreshToken> Get(long id)
        {
            return await _refreshTokenRepository.FindByIdAsync(id);
        }

        public async Task<bool> Add(RefreshToken refreshToken)
        {
            return await _refreshTokenRepository.InsertAsync(refreshToken);
        }

        public async Task<bool> Remove(long id)
        {
            return await _refreshTokenRepository.DeleteAsync(id);
        }
    }
}

using System;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly IRepositoryOfLong<RefreshToken> _tokenRepository;

        public RefreshTokenRepository(IRepositoryOfLong<RefreshToken> tokenRepository)
        {
            _tokenRepository = tokenRepository ?? throw new ArgumentNullException(nameof(tokenRepository));
        }
        
        public async Task<RefreshToken> FindByIdAsync(long id)
        {
            return await _tokenRepository.GetAsync(id);
        }

        public async Task<bool> InsertAsync(RefreshToken refreshToken)
        {
            var existingToken = _tokenRepository.FirstOrDefaultAsync(x => x.UserName == refreshToken.UserName);

            if (existingToken != null)
                await DeleteAsync(existingToken.Id);

            await _tokenRepository.InsertAsync(refreshToken);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var refreshToken = await FindByIdAsync(id);

            if (refreshToken == null)
                return false;

            await _tokenRepository.DeleteAsync(refreshToken);

            return await Task.FromResult(true);
        }
    }
}

using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Threading.Tasks;
using System.Security.Cryptography;
using TP.Business.Administration.Interfaces;

namespace TP.WL.ERP.WebApi.Provider
{
    public class WebApiRefreshTokenProvider : AuthenticationTokenProvider
    {
        //private IRefreshTokenService _refreshTokenService;

        //public WebApiRefreshTokenProvider(IRefreshTokenService refreshTokenService)
        //{
        //    _refreshTokenService = refreshTokenService ?? throw new ArgumentNullException(nameof(refreshTokenService));
        //}

        //public override async Task CreateAsync(AuthenticationTokenCreateContext context)
        //{
        //    var clientId = context.OwinContext.Get<string>("as:client_id");
        //    if (string.IsNullOrWhiteSpace(clientId)) return;

        //    var refreshTokenLifeTime = context.OwinContext.Get<string>("as:clientRefreshTokenLifeTime");
        //    if (string.IsNullOrWhiteSpace(refreshTokenLifeTime)) return;

        //    RandomNumberGenerator cryptoRandomDataGenerator = new RNGCryptoServiceProvider();
        //    byte[] buffer = new byte[50];
        //    cryptoRandomDataGenerator.GetBytes(buffer);
        //    var refreshTokenId = Convert.ToBase64String(buffer).TrimEnd('=').Replace('+', '-').Replace('/', '_');

        //    var refreshToken = new RefreshToken()
        //    {
        //        Id = refreshTokenId,
        //        ClientId = new Guid(clientId),
        //        UserName = context.Ticket.Identity.Name,
        //        IssuedUtc = DateTime.UtcNow,
        //        ExpiresUtc = DateTime.UtcNow.AddSeconds(Convert.ToDouble(refreshTokenLifeTime)),
        //        ProtectedTicket = context.SerializeTicket()
        //    };

        //    context.Ticket.Properties.IssuedUtc = refreshToken.IssuedUtc;
        //    context.Ticket.Properties.ExpiresUtc = refreshToken.ExpiresUtc;

        //    if (await _refreshTokenService.Add(refreshToken))
        //        context.SetToken(refreshTokenId);
        //}

        //public override async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        //{
        //    var refreshToken = await _refreshTokenService.Get(context.Token);

        //    if (refreshToken != null)
        //    {
        //        context.DeserializeTicket(refreshToken.ProtectedTicket);
        //        var result = await _refreshTokenService.Remove(context.Token);
        //    }
        //}
    }
}
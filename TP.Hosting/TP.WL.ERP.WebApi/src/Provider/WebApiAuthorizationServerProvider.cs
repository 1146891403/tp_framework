using Microsoft.Owin.Security.OAuth;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using TP.AspNet.Identity.EntityFramework;
using TP.Business.Administration.Interfaces;
using System;

namespace TP.WL.ERP.WebApi.Provider
{
    public class WebApiAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private IClientTokenService _clientTokenService;

        public WebApiAuthorizationServerProvider(IClientTokenService clientTokenService)
        {
            _clientTokenService = clientTokenService ?? throw new ArgumentNullException(nameof(clientTokenService));
        }

        /// <summary>
        /// 用来对第三方应用认证
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            System.Diagnostics.Debug.WriteLine("用来对第三方应用认证");
            string clientId;
            string clientSecret;
            context.TryGetBasicCredentials(out clientId, out clientSecret);

            System.Diagnostics.Debug.WriteLine(clientId);
            System.Diagnostics.Debug.WriteLine(clientSecret);
            if (context.ClientId == null)
            {
                context.Validated();
            }

            return Task.FromResult<object>(null);

            //string clientId; string clientSecret;

            //if (!context.TryGetBasicCredentials(out clientId, out clientSecret)) { return; }

            //var client = await _clientTokenService.Get(clientId);
            //if (client == null) { return; }
            //if (client.Secret != clientSecret) { return; }

            //context.OwinContext.Set<string>("as:client_id", clientId);
            //context.OwinContext.Set<string>("as:clientRefreshTokenLifeTime", client.RefreshTokenLifeTime.ToString());

            //context.Validated(clientId);
        }

        /// <summary>
        /// 授权方式是只验证客户端（Client），不验证用户
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        {
            System.Diagnostics.Debug.WriteLine("授权方式是只验证客户端（Client），不验证用户");
            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            var ticket = new AuthenticationTicket(oAuthIdentity, new AuthenticationProperties());

            context.Validated(ticket);
        }

        /// <summary>
        /// 客户端用户名、密码验证
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            System.Diagnostics.Debug.WriteLine(" 客户端用户名、密码验证");
            //System.Diagnostics.Debug.WriteLine(context.UserName);
            //System.Diagnostics.Debug.WriteLine(context.Password);

            var signInManager = context.OwinContext.Get<ApplicationSignInManager>();
            var result = await signInManager.PasswordSignInAsync(context.UserName, context.Password, false, false);
            if (result != SignInStatus.Success)
            {
                context.SetError("invalid_grant", "用户名或密码错误。");
                return;
            }

            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            oAuthIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, signInManager.AuthenticationManager.AuthenticationResponseGrant.Identity.GetUserId()));
            //oAuthIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, "5"));

            AuthenticationProperties properties = CreateProperties(context.UserName);
            var ticket = new AuthenticationTicket(oAuthIdentity, new AuthenticationProperties());
            context.Validated(ticket);
        }

        public override async Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            var identity = new ClaimsIdentity(context.Ticket.Identity);
            
            identity.AddClaim(new Claim("newClaim", "refreshToken"));
            var newTicket = new AuthenticationTicket(identity, context.Ticket.Properties);

            context.Validated(newTicket);
        }
        
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        public override Task MatchEndpoint(OAuthMatchEndpointContext context)
        {
            if (context.OwinContext.Request.Method == "OPTIONS" && context.IsTokenEndpoint)
            {
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Methods", new[] { "POST" });
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "accept", "authorization", "content-type" });
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
                context.OwinContext.Response.StatusCode = 200;
                context.RequestCompleted();

                return Task.FromResult<object>(null);
            }

            return base.MatchEndpoint(context);
        }

        public static AuthenticationProperties CreateProperties(string userName)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName }
            };
            return new AuthenticationProperties(data);
        }
    }
}
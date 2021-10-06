using Autofac;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;
using TP.AspNet.Identity.EntityFramework;
using TP.WL.ERP.Data;
using TP.WL.ERP.WebApi.Provider;

namespace TP.WL.ERP.WebApi
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app, IContainer container)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);
            app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);

            var oAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = container.Resolve<WebApiAuthorizationServerProvider>(),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(2),
                AllowInsecureHttp = true,
                RefreshTokenProvider = container.Resolve<WebApiRefreshTokenProvider>()
            };

            app.UseOAuthAuthorizationServer(oAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
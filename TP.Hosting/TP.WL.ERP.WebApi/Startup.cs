using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using TP.Data.Repository.EntityFramework;
using TP.Infrastructure.Common.Dependency;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data;
using TP.WL.ERP.WebApi.Provider;

[assembly: OwinStartup(typeof(TP.WL.ERP.WebApi.Startup))]

namespace TP.WL.ERP.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>()
                .Where(x => x.FullName.StartsWith("TP.")).ToArray();

            // STANDARD WEB API SETUP:

            // Get your HttpConfiguration. In OWIN, you'll create one
            // rather than using GlobalConfiguration.
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);

            // builder.RegisterAssemblyTypes(assemblies).Where(t => t.Name.EndsWith("Provider")).AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(AppRepositoryBase<>)).As(typeof(IRepository<>)).InstancePerDependency();
            builder.RegisterGeneric(typeof(AppRepositoryOfLongBase<>)).As(typeof(IRepositoryOfLong<>)).InstancePerDependency();
            builder.RegisterGeneric(typeof(AppRepositoryBase<,>)).As(typeof(IRepository<,>)).InstancePerDependency();
            builder.RegisterGeneric(typeof(EfDbContextProvider<>)).As(typeof(IDbContextProvider<>)).InstancePerDependency();

            builder.RegisterAssemblyTypes(assemblies).Where(t => typeof(ITransientDependency).IsAssignableFrom(t) && !t.IsAbstract).AsImplementedInterfaces().InstancePerLifetimeScope();

            //builder.RegisterType(typeof(ApplicationDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();

            builder.RegisterType(typeof(ApplicationDbContext)).AsSelf().InstancePerLifetimeScope();
            builder.RegisterType(typeof(WebApiAuthorizationServerProvider)).AsSelf();
            builder.RegisterType(typeof(WebApiRefreshTokenProvider)).AsSelf();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            RegisterWebTypes(builder);

            // Register your Web API controllers.
            builder.RegisterApiControllers(typeof(WebApiConfig).Assembly).PropertiesAutowired();
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Run other optional steps, like registering filters,
            // per-controller-type services, etc., then set the dependency resolver
            // to be Autofac.
            var container = builder.Build();

            var apiResolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = apiResolver;
            GlobalConfiguration.Configuration.DependencyResolver = apiResolver;

            // OWIN WEB API SETUP:

            // Register the Autofac middleware FIRST, then the Autofac Web API middleware,
            // and finally the standard Web API middleware.
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);

            ConfigureAuth(app, container);

            app.UseWebApi(config);
            

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, TP.WL.ERP.Data.Migrations.Configuration>());
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public void RegisterWebTypes(ContainerBuilder builder)
        {
            builder.Register(c => new HttpContextWrapper(HttpContext.Current))
                .As<HttpContextBase>()
                .InstancePerRequest();

            // HttpContext properties
            builder.Register(c => c.Resolve<HttpContextBase>().Request)
                .As<HttpRequestBase>()
                .InstancePerRequest();

            builder.Register(c => c.Resolve<HttpContextBase>().Response)
                .As<HttpResponseBase>()
                .InstancePerRequest();

            builder.Register(c => c.Resolve<HttpContextBase>().Server)
                .As<HttpServerUtilityBase>()
                .InstancePerRequest();

            builder.Register(c => c.Resolve<HttpContextBase>().Session)
                .As<HttpSessionStateBase>()
                .InstancePerRequest();

            builder.Register(c => c.Resolve<HttpContextBase>().Application)
                .As<HttpApplicationStateBase>()
                .InstancePerRequest();

            // HttpRequest properties
            builder.Register(c => c.Resolve<HttpRequestBase>().Browser)
                .As<HttpBrowserCapabilitiesBase>()
                .InstancePerRequest();

            builder.Register(c => c.Resolve<HttpRequestBase>().Files)
                .As<HttpFileCollectionBase>()
                .InstancePerRequest();

            builder.Register(c => c.Resolve<HttpRequestBase>().RequestContext)
                .As<RequestContext>()
                .InstancePerRequest();

            // HttpResponse properties
            builder.Register(c => c.Resolve<HttpResponseBase>().Cache)
                .As<HttpCachePolicyBase>()
                .InstancePerRequest();

            // HostingEnvironment properties
            builder.Register(c => HostingEnvironment.VirtualPathProvider)
                .As<VirtualPathProvider>()
                .InstancePerRequest();

            // MVC types
            //builder.Register(c => new UrlHelper(c.Resolve<RequestContext>()))
            //    .As<UrlHelper>()
            //    .InstancePerRequest();
        }
    }
}

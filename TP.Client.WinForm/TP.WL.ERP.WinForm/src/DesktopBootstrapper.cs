using Autofac;
using Autofac.Integration.Mef;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using TP.Client.WinForm.Common;
using TP.Infrastructure.Autofac;
using static TP.WL.ERP.WinForm.ssMain;

namespace TP.WL.ERP.WinForm
{
    public class DesktopBootstrapper : AutofacBootstrapper
    {
        protected override void ConfigureOthers()
        {
            base.ConfigureOthers();

            RegisterType<DataService, IDataService>();
        }

        protected override void ConfigureApplication()
        {
            base.ConfigureApplication();

            DirectoryCatalog catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "TP.WL.ERP.WinForm.*.dll");
            CurrentBuilder.RegisterComposablePartCatalog(catalog);
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            using (var scope = CurrentContainer.BeginLifetimeScope())
            {
                var modules = CurrentContainer.Resolve<IEnumerable<IModule>>();
                foreach (var m in modules)
                {
                    SplashScreenManager.Default.SendCommand(SplashScreenCommand.Running, $"正在註冊{m.ModuleName}模塊...");

                    m.Initialize();
                }
            }
        }
    }
}

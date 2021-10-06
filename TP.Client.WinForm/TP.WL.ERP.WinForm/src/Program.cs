using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using static TP.WL.ERP.WinForm.ssMain;
using TP.Client.WinForm.Common;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Dependency;

namespace TP.WL.ERP.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(skinName: "Visual Studio 2013 Blue");

            StartUp();
        }

        private static void StartUp(string username = "", string error = "")
        {
            FrmLogin login = new FrmLogin(username, error);
            if (login.ShowDialog() == DialogResult.OK)
            {
                SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false);

                SplashScreenManager.Default.SendCommand(SplashScreenCommand.Running, "正在初始化...");

                Task task = DesktopStartUp.InitializeAsync(login.UserName, login.Password);
                task.Wait();

                if (UserLoginInfo.Current.Succeeded)
                {
                    ApplicationActivator.Run(() => new DesktopBootstrapper());
                    Application.Run(new FrmMain());
                }
                else
                {
                    SplashScreenManager.Default.SendCommand(SplashScreenCommand.Completed, "");

                    StartUp(login.UserName, "用戶名或密碼輸入錯誤！");
                }
            }
        }
    }
}

using System;
using DevExpress.XtraSplashScreen;

namespace TP.WL.ERP.WinForm
{
    public partial class ssMain : SplashScreen
    {
        public ssMain()
        {
            InitializeComponent();

            CopyrightDataUpdate();
        }

        protected virtual void CopyrightDataUpdate()
        {
            lcCopyright.Text = string.Format("Copyright © 2016-{0}\r\nAll Rights Reserved", DateTime.Now.Year);
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);

            if (cmd.GetType() != typeof(SplashScreenCommand)) return;
            SplashScreenCommand ssCommand = (SplashScreenCommand)cmd;

            if (ssCommand == SplashScreenCommand.Running)
                lcStatus.Text = arg.ToString();

            if (ssCommand == SplashScreenCommand.Completed)
                SplashScreenManager.CloseForm();
        }

        #endregion

        public enum SplashScreenCommand
        {
            Start,
            Running,
            Completed
        }
    }
}
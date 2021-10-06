using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using System;
using TP.Client.WinForm.Common;
using static TP.WL.ERP.WinForm.ssMain;

namespace TP.WL.ERP.WinForm
{
    public partial class FrmMain : RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();

            ModulesInfo.FillRibbon(rcMain, UserLoginInfo.Current.Navigations);
            
            rcMain.ItemClick += new ItemClickEventHandler(RcMain_ItemClick);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SplashScreenManager.Default.SendCommand(SplashScreenCommand.Running, "初始化完成...");
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            SplashScreenManager.Default.SendCommand(SplashScreenCommand.Completed, "");
        }
        
        private void RcMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowModule(e.Item.Name, e.Item.Caption, tabbedView);
        }

        public void ShowModule(string key, string name, DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tableView)
        {
            var item = ModulesInfo.GetItem(key);
            if (item != null)
                ModulesInfo.ShowModule(item, name, this, tableView);
        }
    }
}

using System.ComponentModel.Composition;
using TP.Client.WinForm.Common;

namespace TP.WL.ERP.WinForm.Crm
{
    [Export(typeof(IModule))]
    public class CrmModule : IModule
    {
        public string Number => "Crm";

        public string ModuleName => "客戶關係管理";

        public void Initialize()
        {
            ModulesInfo.Add("ClientGridView", typeof(Controls.ClientGridView), "", "bocustomer");
            ModulesInfo.Add("CertificateGridView", typeof(Controls.CertificateGridView), "", "engineering");
        }
    }
}

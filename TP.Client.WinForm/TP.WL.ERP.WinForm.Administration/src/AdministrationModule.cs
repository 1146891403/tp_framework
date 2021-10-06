using System.ComponentModel.Composition;
using TP.Client.WinForm.Common;

namespace TP.WL.ERP.WinForm.Administration
{
    [Export(typeof(IModule))]
    public class AdministrationModule : IModule
    {
        public string Number => "Administration";

        public string ModuleName => "系統設置";
        
        public void Initialize()
        {
            ModulesInfo.Add("UserGridView", typeof(Controls.UserGridView), "", "user");
            ModulesInfo.Add("PermissionGridView", typeof(Controls.PermissionGridView), "", "role");
            ModulesInfo.Add("NavigationGridView", typeof(Controls.NavigationGridView), "", "navigationbar");
            ModulesInfo.Add("DictionaryGridView", typeof(Controls.DictionaryGridView), "", "text");
            ModulesInfo.Add("OrganizationGridView", typeof(Controls.OrganizationGridView), "", "usergroup");
            ModulesInfo.Add("FunctionGridView", typeof(Controls.FunctionGridView), "", "functionsmore");
        }
    }
}

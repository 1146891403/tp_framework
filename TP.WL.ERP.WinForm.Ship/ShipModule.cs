using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Client.WinForm.Common;

namespace TP.WL.ERP.WinForm.Ship
{
    [Export(typeof(IModule))]
    public class ShipModule : IModule
    {
        public string Number => "Ship";

        public string ModuleName => "纸箱管理";

        public void Initialize()
        {
            ModulesInfo.Add("CartonGridView", typeof(Controls.CartonGridView), "", "functionsmore");
        }
    }
}

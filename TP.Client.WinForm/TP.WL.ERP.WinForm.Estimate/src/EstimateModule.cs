using System.ComponentModel.Composition;
using TP.Client.WinForm.Common;

namespace TP.WL.ERP.WinForm.Estimate
{
    [Export(typeof(IModule))]
    public class EstimateModule
    {
        public string Number => "Estimate";

        public string ModuleName => "估價管理";

        public void Initialize()
        {

        }
    }
}

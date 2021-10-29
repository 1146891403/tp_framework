using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Data.Entities.Ship;
using TP.WL.ERP.Model.Ship;

namespace TP.WL.ERP.Business.Ship.Interfaces
{
    public interface IShipCartonService : ITransientDependency
    {
        Task<WebApiResult<ShipCartonEditModel>> GetGetAllAsync();

        Task<WebApiResult<string>> DeleteAsync(long id);

        Task<WebApiResult<string>> UpdateListAsync(IEnumerable<ShipCartonEditModel> listModel,string userId);
    }
}

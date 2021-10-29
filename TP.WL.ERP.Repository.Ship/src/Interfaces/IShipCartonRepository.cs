using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data.Entities.Ship;

namespace TP.WL.ERP.Repository.Ship.Interfaces
{
    public interface IShipCartonRepository : IRepository
    {
        Task<IEnumerable<ShipCarton>> GetAllAsync();

        Task<ShipCarton> FindByIdAsync(long id);

        Task<bool> DeleteAsync(long id);

        Task<bool> UpdateListAsync(IEnumerable<ShipCarton> shipCarton);

    }
}

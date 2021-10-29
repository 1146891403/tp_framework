using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Data.Repository.EntityFramework;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data;
using TP.WL.ERP.Data.Entities.Ship;
using TP.WL.ERP.Repository.Ship.Interfaces;

namespace TP.WL.ERP.Repository.Ship.Services
{
    public class ShipCartonRepository : IShipCartonRepository
    {
        private readonly IRepositoryOfLong<ShipCarton> _shipCartonRepository;

        public ShipCartonRepository(IRepositoryOfLong<ShipCarton> shipCartonRepository)
        {
            _shipCartonRepository = shipCartonRepository ?? throw new ArgumentNullException(nameof(shipCartonRepository));
        }

        public async Task<IEnumerable<ShipCarton>> GetAllAsync()
        {
            return await _shipCartonRepository.GetAllListAsync();
        }

        public async Task<ShipCarton> FindByIdAsync(long id)
        {
            return await _shipCartonRepository.GetAsync(id);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            await _shipCartonRepository.DeleteAsync(id);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateListAsync(IEnumerable<ShipCarton> listModel)
        {
            //using (var context = ApplicationDbContext.Create())
            //{
            //    using (var transaction = context.Database.BeginTransaction())
            //    {
            //        try
            //        {

            //            transaction.Commit();
            //        }
            //        catch (Exception ex)
            //        {
            //            transaction.Rollback();

            //            throw new ApplicationException($"保存失败,已回滚数据!错误代码:{ex.ToString()}");
            //        }
            //    }
            //}
            //foreach (var model in listModel)
            //{
            //    await _shipCartonRepository.UpdateAsync(model);
            //}

            await _shipCartonRepository.BulkUpdateAsync(listModel);

            return await Task.FromResult(true);
        }

   
    }
}

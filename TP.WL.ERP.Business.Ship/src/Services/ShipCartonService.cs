using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TP.Data.Repository.EntityFramework;
using TP.Infrastructure.Common;
using TP.WL.ERP.Business.Ship.Interfaces;
using TP.WL.ERP.Data;
using TP.WL.ERP.Data.Entities.Ship;
using TP.WL.ERP.Model.Ship;
using TP.WL.ERP.Repository.Ship.Interfaces;

namespace TP.WL.ERP.Business.Ship.Services
{
    public class ShipCartonService : IShipCartonService
    {
        public IShipCartonRepository _shipCartonRepository;

        public ShipCartonService(IShipCartonRepository shipCartonRepository)
        {
            _shipCartonRepository = shipCartonRepository ?? throw new ArgumentNullException(nameof(shipCartonRepository)); ;
        }

        public async Task<WebApiResult<ShipCartonEditModel>> GetGetAllAsync()
        {
            return await Guard.TryCatch<ShipCartonEditModel>(
                async () =>
                {
                    var result = await _shipCartonRepository.GetAllAsync();

                    return ConventShipCartonToListModel(result);
                });
        }

        public async Task<WebApiResult<string>> DeleteAsync(long id)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    await _shipCartonRepository.DeleteAsync(id);
                });
        }

        public async Task<WebApiResult<string>> UpdateListAsync(IEnumerable<ShipCartonEditModel> listModel,string userId)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    List<ShipCarton> shipCartonsList = new List<ShipCarton>();
                    foreach (var model in listModel)
                    {
                        ShipCarton shipCarton = await _shipCartonRepository.FindByIdAsync(model.Id);

                        //shipCarton.Id = model.Id;
                        shipCarton.JobNumber = model.JobNumber;
                        shipCarton.DescriptiveName = model.DescriptiveName;
                        shipCarton.Edition = model.Edition;
                        shipCarton.CopyRight = model.CopyRight;
                        shipCarton.Delivery_Date = model.DeliveryDate;
                        shipCarton.Consignee = model.Consignee;
                        shipCarton.Notify = model.Notify;
                        shipCarton.Notify1 = model.Notify1;
                        shipCarton.WaehouseAddr = model.WaehouseAddr;
                        shipCarton.Country = model.Country;
                        shipCarton.Terms = model.Terms;
                        shipCarton.ModificatorId = userId;
                        shipCarton.ModifyDate = DateTime.Now;

                        shipCartonsList.Add(shipCarton);
                    }

                    await _shipCartonRepository.UpdateListAsync(shipCartonsList);
                });
                
        }

        private IEnumerable<ShipCartonEditModel> ConventShipCartonToListModel(IEnumerable<ShipCarton> shipCarton)
        {
            var list = new List<ShipCartonEditModel>();
            foreach (var item in shipCarton)
            {
                list.Add(new ShipCartonEditModel()
                {
                    Id = item.Id,
                    JobNumber = item.JobNumber,
                    DescriptiveName = item.DescriptiveName,
                    Edition = item.Edition,
                    CopyRight = item.CopyRight,
                    DeliveryDate = item.Delivery_Date,
                    Consignee = item.Consignee,
                    Notify = item.Notify,
                    Notify1 = item.Notify1,
                    WaehouseAddr = item.WaehouseAddr,
                    Country = item.Country,
                    Terms = item.Terms
                });
            }

            return list;
        }
    }
}

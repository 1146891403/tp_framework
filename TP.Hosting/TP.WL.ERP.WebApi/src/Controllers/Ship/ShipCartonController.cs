using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Infrastructure.Common;
using TP.WL.ERP.Business.Ship.Interfaces;
using TP.WL.ERP.Model.Ship;

namespace TP.WL.ERP.WebApi.Controllers.Ship
{
    [RoutePrefix("Api/carton")]
    public class ShipCartonController : ApiController
    {
        private readonly IShipCartonService _shipCartonService;

        public ShipCartonController(IShipCartonService shipCartonService)
        {
            _shipCartonService = shipCartonService ?? throw new ArgumentNullException(nameof(shipCartonService));
        }

        [Route("get_all"), HttpGet]
        public async Task<WebApiResult<ShipCartonEditModel>> GetAllAsync()
        {
            return await _shipCartonService.GetGetAllAsync();
        }

        [Route("update_list"),HttpPut]
        public async Task<WebApiResult<string>> UpdateListAsync([FromBody]IEnumerable<ShipCartonEditModel> listModel)
        {
            return await _shipCartonService.UpdateListAsync(listModel, User.Identity.GetUserId());
        }

    }
}

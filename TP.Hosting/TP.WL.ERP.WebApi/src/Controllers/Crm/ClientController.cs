using System;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Infrastructure.Common;
using TP.WL.ERP.Business.Crm.Interfaces;
using TP.WL.ERP.Model.Crm;

namespace TP.WL.ERP.WebApi.Controllers.Crm
{
    public class ClientController : ApiController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
        }
        
        public async Task<WebApiResult<ClientEditModel>> GetAsync(string number)
        {
            return await _clientService.GetClientAsync(number);
        }
    }
}
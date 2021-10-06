using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.WL.ERP.Business.Crm.Interfaces;
using TP.WL.ERP.Model.Crm;
using TP.WL.ERP.Repository.Crm.Interfaces;

namespace TP.WL.ERP.Business.Crm.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        public async Task<WebApiResult<ClientEditModel>> GetClientAsync(string number)
        {
            return await Guard.TryCatch<ClientEditModel>(
                async () =>
                {
                    var result = await _clientRepository.FindByNumberAsync(number);

                    var result2 = new List<ClientEditModel>();

                    result2.Add(new ClientEditModel()
                    {
                        Number = result.EnglishName,
                        ShortName = result.ChineseName + result.EnglishName
                    });

                    return result2;
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Crm;

namespace TP.WL.ERP.Business.Crm.Interfaces
{
    public interface IClientService : ITransientDependency
    {
        Task<WebApiResult<ClientEditModel>> GetClientAsync(string number);
    }
}

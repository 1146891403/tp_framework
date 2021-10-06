using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data.Entities.Crm;

namespace TP.WL.ERP.Repository.Crm.Interfaces
{
    public interface IClientRepository : IRepository
    {
        Task<Client> FindByNumberAsync(string number);

        Task<IEnumerable<Client>> GetClientsAsync(string userId);

        Task<IEnumerable<ClientBrand>> GetBrandsAsync(long clientId);

        Task<IEnumerable<ClientCertificateGroup>> GetCertificateGroupsAsync(long clientId);

        //Task<IEnumerable<Certificate>> GetCertificatesAsync(long groupId);

        Task<IEnumerable<ClientSignFile>> GetSignFilesAsync(long clientId);

        Task<IEnumerable<ClientContact>> GetContactsAsync(long clientId);

        Task<IEnumerable<ClientExpress>> GetExpressesAsync(long clientId);

        Task<bool> InsertClientAsync(Client client);

        Task<bool> UpdateClientAsync(Client client);
    }
}

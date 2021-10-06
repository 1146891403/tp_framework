using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Repository;
using TP.WL.ERP.Data.Entities.Crm;

namespace TP.WL.ERP.Repository.Crm.Interfaces
{
    public interface ICertificateRepository : IRepository
    {
        Task<Certificate> FindByIdAsync(long id);

        Task<IEnumerable<Certificate>> GetAllAsync();

        Task<bool> InsertAsync(Certificate certificate);

        Task<bool> UpdateAsync(Certificate certificate);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IOrganizationRepository : IRepository
    {
        Task<IEnumerable<Subsidiary>> FindOrganizationsAsync();

        Task<IEnumerable<Subsidiary>> FindSubsidiariesAsync();

        Task<IEnumerable<Department>> FindDepartmentsAsync();

        Task<Subsidiary> FindSubsidiaryByIdAsync(long id);

        Task<Department> FindDepartmentByIdAsync(long id);

        Task<bool> InsertSubsidiaryAsync(Subsidiary subsidiary);

        Task<bool> InsertDepartmentAsync(Department department);

        Task<bool> UpdateSubsidiaryAsync(Subsidiary subsidiary);

        Task<bool> UpdateDepartmentAsync(Department department);
    }
}

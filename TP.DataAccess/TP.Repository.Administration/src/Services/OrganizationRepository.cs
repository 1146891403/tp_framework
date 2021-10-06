using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TP.Repository.Administration.Interfaces;
using TP.Infrastructure.Common.Repository;
using TP.Data.EntityFramework.Entities.Administration;
using System.Linq;

namespace TP.Repository.Administration.Services
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly IRepositoryOfLong<Subsidiary> _subsidiaryRepository;
        private readonly IRepositoryOfLong<Department> _departmentRepository;

        public OrganizationRepository(IRepositoryOfLong<Subsidiary> subsidiaryRepository, IRepositoryOfLong<Department> departmentRepository)
        {
            _subsidiaryRepository = subsidiaryRepository ?? throw new ArgumentNullException(nameof(subsidiaryRepository));
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
        }

        public async Task<IEnumerable<Subsidiary>> FindOrganizationsAsync()
        {
            return await _subsidiaryRepository.GetAll().Include(x => x.Departments)
                .Where(x => x.IsEnabled)
                .OrderBy(x => x.ListOrder).ToListAsync();
        }

        public async Task<IEnumerable<Subsidiary>> FindSubsidiariesAsync()
        {
            return await _subsidiaryRepository.GetAllListAsync(x => x.IsEnabled);
        }

        public async Task<IEnumerable<Department>> FindDepartmentsAsync()
        {
            return await _departmentRepository.GetAllListAsync();
        }

        public async Task<Subsidiary> FindSubsidiaryByIdAsync(long id)
        {
            return await _subsidiaryRepository.GetAsync(id);
        }

        public async Task<Department> FindDepartmentByIdAsync(long id)
        {
            return await _departmentRepository.GetAsync(id);
        }

        public async Task<bool> InsertSubsidiaryAsync(Subsidiary subsidiary)
        {
            await _subsidiaryRepository.InsertAsync(subsidiary);

            return await Task.FromResult(true);
        }

        public async Task<bool> InsertDepartmentAsync(Department department)
        {
            await _departmentRepository.InsertAsync(department);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateSubsidiaryAsync(Subsidiary subsidiary)
        {
            await _subsidiaryRepository.UpdateAsync(subsidiary);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateDepartmentAsync(Department department)
        {
            await _departmentRepository.UpdateAsync(department);

            return await Task.FromResult(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Business.Administration.Interfaces;
using TP.WL.ERP.Model.Administration;
using TP.Repository.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.Data.EntityFramework.Entities.Administration;

namespace TP.Business.Administration.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationService(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository ?? throw new ArgumentNullException(nameof(organizationRepository));
        }

        public async Task<WebApiResult<OrganizationListModel>> GetOrganizationsAsync()
        {
            return await Guard.TryCatch<OrganizationListModel>(
                async () =>
                {
                    var organizations = await _organizationRepository.FindOrganizationsAsync();

                    var listModel = new List<OrganizationListModel>();

                    foreach(var subsidiary in organizations)
                    {
                        listModel.Add(new OrganizationListModel()
                        {
                            Id = subsidiary.Id,
                            ParentId = subsidiary.ParentId ?? 0,
                            Number = subsidiary.Number,
                            DisplayName = subsidiary.LegalName,
                            SubsidiaryId = subsidiary.Id,
                            Category = subsidiary.Category,
                            ListOrder = subsidiary.ListOrder,
                            IsEnabled = subsidiary.IsEnabled
                        });
                    }

                    foreach (var department in organizations.SelectMany(x => x.Departments).Where(x => x.IsEnabled))
                    {
                        listModel.Insert(listModel.FindLastIndex(x => x.SubsidiaryId == department.SubsidiaryId) + 1,
                            new OrganizationListModel()
                            {
                                Id = department.Id,
                                ParentId = department.ParentId ?? department.SubsidiaryId,
                                Number = department.Number,
                                DisplayName = department.DisplayName,
                                SubsidiaryId = department.SubsidiaryId,
                                Category = department.Category,
                                ListOrder = department.ListOrder,
                                IsEnabled = department.IsEnabled
                            });
                    }

                    return listModel;
                });
        }

        public async Task<WebApiResult<SubsidiaryListModel>> GetSubsidiariesAsync()
        {
            return await Guard.TryCatch<SubsidiaryListModel>(
                async () =>
                {
                    var subsidiaries = await _organizationRepository.FindSubsidiariesAsync();

                    var listModel = new List<SubsidiaryListModel>();

                    foreach (var subsidiary in subsidiaries)
                    {
                        listModel.Add(new SubsidiaryListModel()
                        {
                            Id = subsidiary.Id,
                            ParentId = subsidiary.ParentId ?? 0,
                            DisplayName = subsidiary.LegalName,
                        });
                    }

                    return listModel;
                });
        }

        public Task<WebApiResult<DepartmentListModel>> GetDepartmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResult<SubsidiaryEditModel>> GetSubsidiaryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WebApiResult<DepartmentEditModel>> GetDepartmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<WebApiResult<string>> AddSubsidiaryAsync(SubsidiaryEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var subsidiary = new Subsidiary()
                    {
                        Number = model.Number,
                        LegalName = model.DisplayName,
                        ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>(),
                        Category = model.Category,
                        ListOrder = model.ListOrder,
                        IsEnabled = model.IsEnabled,
                        ModifyDate = DateTime.Now,
                    };

                    await _organizationRepository.InsertSubsidiaryAsync(subsidiary);
                });
        }

        public async Task<WebApiResult<string>> AddDepartmentAsync(DepartmentEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var department = new Department()
                    {
                        Number = model.Number,
                        DisplayName = model.DisplayName,
                        SubsidiaryId = model.SubsidiaryId,
                        ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>(),
                        Category = model.Category,
                        ListOrder = model.ListOrder,
                        IsEnabled = model.IsEnabled,
                        ModifyDate = DateTime.Now
                    };

                    await _organizationRepository.InsertDepartmentAsync(department);
                });
        }

        public async Task<WebApiResult<string>> UpdateSubsidiaryAsync(SubsidiaryEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var subsidiary = await _organizationRepository.FindSubsidiaryByIdAsync(model.Id);

                    subsidiary.LegalName = model.DisplayName;
                    subsidiary.ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>();
                    subsidiary.Category = model.Category;
                    subsidiary.ListOrder = model.ListOrder;
                    subsidiary.IsEnabled = model.IsEnabled;
                    subsidiary.ModifyDate = DateTime.Now;

                    await _organizationRepository.UpdateSubsidiaryAsync(subsidiary);
                });
        }

        public async Task<WebApiResult<string>> UpdateDepartmentAsync(DepartmentEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var department = await _organizationRepository.FindDepartmentByIdAsync(model.Id);

                    department.Number = model.Number;
                    department.DisplayName = model.DisplayName;
                    department.SubsidiaryId = model.SubsidiaryId;
                    department.ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>();
                    department.Category = model.Category;
                    department.ListOrder = model.ListOrder;
                    department.IsEnabled = model.IsEnabled;
                    department.ModifyDate = DateTime.Now;

                    await _organizationRepository.UpdateDepartmentAsync(department);
                });
        }
    }
}

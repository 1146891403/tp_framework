using System;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Business.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WebApi.Controllers.Administration
{
    //[Authorize]
    [RoutePrefix("api/organizations")]
    public class OrganizationController : ApiController
    {
        private IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService ?? throw new ArgumentNullException(nameof(organizationService));
        }

        [Route("get_all"), HttpGet]
        public async Task<WebApiResult<OrganizationListModel>> GetAllAsync()
        {
            return await _organizationService.GetOrganizationsAsync();
        }

        [Route("get_subsidiaries"), HttpGet]
        public async Task<WebApiResult<SubsidiaryListModel>> GetSubsidiariesAsync()
        {
            return await _organizationService.GetSubsidiariesAsync();
        }

        [Route("add_subsidiary"), HttpPost]
        public async Task<WebApiResult<string>> AddSubsidiaryAsync(SubsidiaryEditModel model)
        {
            return await _organizationService.AddSubsidiaryAsync(model);
        }

        [Route("add_department"), HttpPost]
        public async Task<WebApiResult<string>> AddDepartmentAsync(DepartmentEditModel model)
        {
            return await _organizationService.AddDepartmentAsync(model);
        }

        [Route("update_subsidiary"), HttpPut]
        public async Task<WebApiResult<string>> UpdateSubsidiaryAsync(SubsidiaryEditModel model)
        {
            return await _organizationService.UpdateSubsidiaryAsync(model);
        }

        [Route("update_department"), HttpPut]
        public async Task<WebApiResult<string>> UpdateDepartmentAsync(DepartmentEditModel model)
        {
            return await _organizationService.UpdateDepartmentAsync(model);
        }
    }
}

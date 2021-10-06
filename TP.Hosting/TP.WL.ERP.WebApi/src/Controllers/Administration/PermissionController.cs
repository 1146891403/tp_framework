using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Business.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WebApi.Controllers.Administration
{
    [RoutePrefix("api/permissions")]
    public class PermissionController : ApiController
    {
        private readonly IPermissionService _roleService;

        public PermissionController(IPermissionService roleService)
        {
            _roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
        }

        [Route("get_roles"), HttpGet]
        public async Task<WebApiResult<RoleListModel>> GetRolesAsync()
        {
            return await _roleService.GetRolesAsync();
        }

        [Route("get_views"), HttpGet]
        public async Task<WebApiResult<string>> GetViewsAsync(string roleId)
        {
            return await _roleService.GetViewsAsync(roleId);
        }

        [Route("get_functions"), HttpGet]
        public async Task<WebApiResult<string>> GetFunctionsAsync(string roleId)
        {
            return await _roleService.GetFunctionsAsync(roleId);
        }

        [Route("add_role"), HttpPost]
        public async Task<WebApiResult<string>> AddRoleAsync(RoleEditModel model)
        {
            return await _roleService.AddRoleAsync(model);
        }

        [Route("add_users_in_role"), HttpPost]
        public async Task<WebApiResult<string>> AddUsersAsync(UserRoleEditModel model)
        {
            return await _roleService.AddToUsersAsync(model);
        }

        [Route("add_views_in_role"), HttpPost]
        public async Task<WebApiResult<string>> AddViewsAsync(IDictionary<string, IEnumerable<long>> roleViews)
        {
            return await _roleService.AddToViewsAsync(roleViews);
        }

        [Route("add_functions_in_role"), HttpPost]
        public async Task<WebApiResult<string>> AddFunctionsAsync(IDictionary<string, IEnumerable<long>> roleFunctions)
        {
            return await _roleService.AddToFunctionsAsync(roleFunctions);
        }

        [Route("update_role"), HttpPut]
        public async Task<WebApiResult<string>> UpdateRoleAsync(RoleEditModel model)
        {
            return await _roleService.UpdateRoleAsync(model);
        }
    }
}
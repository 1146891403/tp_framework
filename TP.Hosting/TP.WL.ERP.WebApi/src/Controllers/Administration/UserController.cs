using Microsoft.AspNet.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Business.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WebApi.Controllers.Administration
{
    [Authorize]
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [Route("test"), HttpGet]
        public string Test()
        {
            return "test";
        }

        [Route("get_all"), HttpGet]
        public async Task<WebApiResult<UserListModel>> GetAllAsync()
        {
            return await _userService.GetAllAsync();
        }

        [Route("get_users_by_role"), HttpGet]
        public async Task<WebApiResult<UserListModel>> GetUsersInRoleAsync(long id)
        {
            return await _userService.GetUsersByRoleAsync(id);
        }

        [Route("get_users_by_subsidiary"), HttpGet]
        public async Task<WebApiResult<UserListModel>> GetUsersBySubsidiaryAsync(long id)
        {
            return await _userService.GetUsersBySubsidiaryAsync(id);
        }

        [Route("get_users_by_subsidiary"), HttpGet]
        public async Task<WebApiResult<UserListModel>> GetUsersBySubsidiaryAsync(long id, long roleId)
        {
            return await _userService.GetUsersBySubsidiaryAsync(id, roleId);
        }

        [Route("get_users_by_department"), HttpGet]
        public async Task<WebApiResult<UserListModel>> GetUsersByDepartmentAsync(long id)
        {
            return await _userService.GetUsersByDepartmentAsync(id);
        }

        [Route("get_users_by_department"), HttpGet]
        public async Task<WebApiResult<UserListModel>> GetUsersByDepartmentAsync(long id, long roleId)
        {
            return await _userService.GetUsersByDepartmentAsync(id, roleId);
        }

        [Route("get_single"), HttpGet]
        public async Task<WebApiResult<UserEditModel>> GetSingleAsync(string id)
        {
            return await _userService.GetAsync(id);
        }

        [Route("get_views"), HttpGet]
        public async Task<WebApiResult<NavigationListModel>> GetViewsAsync()
        {
            return await _userService.GetViewsAsync(User.Identity.GetUserId());
            //return await _userService.GetViewsAsync("5");
        }

        [Route("get_functions"), HttpGet]
        public async Task<WebApiResult<string>> GetFunctionsAsync()
        {
            //var user = (ClaimsIdentity)User.Identity;

            //System.Diagnostics.Debug.WriteLine(User.Identity.GetUserId());
            //System.Diagnostics.Debug.WriteLine(User.Identity.GetUserName());
            //System.Diagnostics.Debug.WriteLine(user.FindFirstValue("test"));
            
            return await _userService.GetFunctionsAsync(User.Identity.GetUserId());
            //return await _userService.GetFunctionsAsync("5");
        }

        [Route("add"), HttpPost]
        public async Task<WebApiResult<string>> AddAsync([FromBody]UserEditModel model)
        {
            return await _userService.AddAsync(model);
        }

        [Route("update"), HttpPut]
        public async Task<WebApiResult<string>> UpdateAsync([FromBody]UserEditModel model)
        {
            return await _userService.UpdateAsync(model);
        }

        [Route("update_password"),HttpPut]
        public async Task<WebApiResult<string>> UpdatePasswordAsync([FromBody]UserEditModel model)
        {
            var userid = User.Identity.GetUserId();
            return await _userService.UpdatePasswordAsync(userid, model.OldPassword, model.NewPassword);
        }
    }
}

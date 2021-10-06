using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using TP.Business.Administration.Interfaces;
using TP.WL.ERP.Model.Administration;
using TP.Repository.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.Data.EntityFramework.Entities;
using System.Linq;

namespace TP.Business.Administration.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _roleRepository;

        public PermissionService(IPermissionRepository roleRepository)
        {
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }

        public async Task<WebApiResult<RoleListModel>> GetRolesAsync()
        {
            return await Guard.TryCatch<RoleListModel>(
                async () =>
                {
                    var subsidiaries = await _roleRepository.FindRolesBySubsidiaryId(0);
                    
                    var result = new List<RoleListModel>();

                    foreach(var sub in subsidiaries)
                    {
                        result.Add(new RoleListModel()
                        {
                            Id = sub.Id,
                            DisplayName = sub.LegalName,
                            IsEnabled = sub.IsEnabled,
                            ParentId = sub.ParentId ?? 0,
                            SubsidiaryId = sub.Id
                        });

                        foreach(var role in sub.Roles)
                        {
                            result.Add(new RoleListModel()
                            {
                                Id = Convert.ToInt64(role.Id),
                                DisplayName = role.Name,
                                Description = role.Description,
                                IsEnabled = role.IsEnabled,
                                ParentId = role.SubsidiaryId,
                                SubsidiaryId = role.SubsidiaryId
                            });
                        }
                    }

                    return result;
                });

            //return await Guard.TryCatch<RoleListModel>(
            //    async () =>
            //    {
            //        var roles = await _roleRepository.FindRolesAsync();

            //        var result = new List<RoleListModel>();
            //        foreach(var role in roles)
            //        {
            //            result.Add(new RoleListModel()
            //            {
            //                Id = Convert.ToInt64(role.Id),
            //                DisplayName = role.Name,
            //                Description = role.Description,
            //                IsEnabled = role.IsEnabled,
            //                SubsidiaryId = role.SubsidiaryId
            //            });
            //        }

            //        return result;
            //    });
        }

        public Task<WebApiResult<RoleEditModel>> GetRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<WebApiResult<string>> GetViewsAsync(string roleId)
        {
            return await Guard.TryCatch<string>(
                async () =>
                {
                    var views = await _roleRepository.GetViewsInRoleAsync(roleId);

                    var result = new List<string>();
                    foreach (var v in views)
                    {
                        result.Add(v.ToString());
                    }

                    return result;
                });
        }

        public async Task<WebApiResult<string>> GetFunctionsAsync(string roleId)
        {
            return await Guard.TryCatch<string>(
                async () =>
                {
                    var functions = await _roleRepository.GetFunctionsInRoleAsync(roleId);

                    var result = new List<string>();
                    foreach(var func in functions)
                    {
                        result.Add(func.ToString());
                    }

                    return result;
                });
        }

        public async Task<WebApiResult<string>> AddRoleAsync(RoleEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var userId = HttpContext.Current.User.Identity.GetUserId();

                    var role = new ApplicationRole()
                    {
                        Name = model.DisplayName,
                        Description = model.Description,
                        IsEnabled = model.IsEnabled,
                        SubsidiaryId = model.SubsidiaryId,
                        CreatorId = userId,
                        ModificatorId = userId
                    };

                    await _roleRepository.InsertRoleAsync(role);
                });
        }

        public async Task<WebApiResult<string>> AddToUsersAsync(UserRoleEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var role = await _roleRepository.FindUsersByRoleIdAsync(model.Id.ToString());

                    var users = model.Users.Values;
                    var addUsers = new List<string>();
                    //var deleteUsers = new List<string>();

                    //deleteUsers.AddRange(role.Users.Select(x => x.UserId).Where(u => !users.Contains(u)));

                    addUsers.AddRange(users.Where(x => !role.Users.Select(u => u.UserId).Contains(x)));

                    //await _roleRepository.DeleteUserRolesAsync(role, deleteUsers);

                    await _roleRepository.BulkInsertUserRolesAsync(role, addUsers);
                });
        }

        public async Task<WebApiResult<string>> AddToViewsAsync(IDictionary<string, IEnumerable<long>> views)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    foreach (var rv in views)
                    {
                        var role = await _roleRepository.FindViewsByRoleIdAsync(rv.Key);

                        var addViews = new List<long>();
                        var deleteViews = new List<long>();

                        deleteViews.AddRange(role.ViewLinks.Select(x => x.ViewLinkId).Where(v => !rv.Value.Contains(v)));

                        addViews.AddRange(rv.Value.Where(x => !role.ViewLinks.Select(v => v.ViewLinkId).Contains(x)));
                        
                        await _roleRepository.DeleteRoleViewsAsync(role, deleteViews);

                        await _roleRepository.BulkInsertRoleViewsAsync(role, addViews);
                    }

                });
        }

        public async Task<WebApiResult<string>> AddToFunctionsAsync(IDictionary<string, IEnumerable<long>> functions)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    foreach (var rf in functions)
                    {
                        var role = await _roleRepository.FindFunctionsByRoleIdAsync(rf.Key);

                        var addFunctions = new List<long>();
                        var deleteFunctions = new List<long>();

                        deleteFunctions.AddRange(role.Functions.Select(x => x.FunctionId).Where(f => !rf.Value.Contains(f)));

                        addFunctions.AddRange(rf.Value.Where(x => !role.Functions.Select(f => f.FunctionId).Contains(x)));

                        await _roleRepository.DeleteRoleFunctionsAsync(role, deleteFunctions);

                        await _roleRepository.BulkInsertRoleFunctionsAsync(role, addFunctions);
                    }
                });
        }

        public async Task<WebApiResult<string>> UpdateRoleAsync(RoleEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var role = await _roleRepository.FindRoleByIdAsync(model.Id.ToString());

                    role.Name = model.DisplayName;
                    role.Description = model.Description;
                    role.SubsidiaryId = model.SubsidiaryId;
                    role.IsEnabled = model.IsEnabled;
                    role.ModificatorId = HttpContext.Current.User.Identity.GetUserId();
                    role.ModifyDate = DateTime.Now;

                    await _roleRepository.UpdateRoleAsync(role);
                });
        }
    }
}

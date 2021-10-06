using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TP.Business.Administration.Interfaces;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Enums;
using TP.Infrastructure.Common.Extensions;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;
using TP.WL.ERP.Model.Administration;

namespace TP.Business.Administration.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRepositoryOfLong<Subsidiary> _subsidiaryRepository;
        private readonly IRepositoryOfLong<Department> _departmentRepository;
        
        public UserService(IUserRepository userRepository, IRepositoryOfLong<Subsidiary> subsidiaryRepository, IRepositoryOfLong<Department> departmentRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _subsidiaryRepository = subsidiaryRepository ?? throw new ArgumentNullException(nameof(subsidiaryRepository));
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException(nameof(departmentRepository));
        }

        public async Task<WebApiResult<UserListModel>> GetAllAsync()
        {
            return await Guard.TryCatch<UserListModel>(
                async () =>
                {
                    var users = await _userRepository.FindUsersAsync();

                    return this.ConvertUserToListModel(users);
                });
        }

        public async Task<WebApiResult<UserEditModel>> GetAsync(string userId)
        {
            return await Guard.TryCatch<UserEditModel>(
                async () =>
                {
                    var user = await _userRepository.FindByIdAsync(userId);

                    var result = new List<UserEditModel>
                    {
                        new UserEditModel()
                        {
                            Id = 10000,
                            UserId = user.Id,
                            UserName = user.UserName,
                            Email = user.Email,
                            Mobile = user.PhoneNumber,
                            LockoutEnabled = user.LockoutEnabled,
                            FullName = user.Profile.FullName,
                            Alias = user.Profile.Alias,
                            Number = user.Profile.StaffNumber,
                            Gender = user.Profile.Gender.ToString(),
                            Designation = user.Profile.Designation,
                            JoinDate = user.Profile.JoinDate,
                            Phone = user.Profile.Tel,
                            SubsidiaryId = user.Profile.SubsidiaryId,
                            DepartmentId = user.Profile.DepartmentId,
                            Remark = user.Profile.Remark
                        }
                    };

                    return result;
                });
        }

        public async Task<WebApiResult<UserListModel>> GetUsersByRoleAsync(long roleId)
        {
            return await Guard.TryCatch<UserListModel>(
                async () =>
                {
                    var users = await _userRepository.GetUsersInRoleAsync(roleId.ToString());

                    return this.ConvertUserToListModel(users);
                });
        }

        public async Task<WebApiResult<UserListModel>> GetUsersBySubsidiaryAsync(long subsidiaryId)
        {
            return await Guard.TryCatch<UserListModel>(
                async () =>
                {
                    var users = await _userRepository.GetUsersInSubsidiaryAsync(subsidiaryId);

                    return this.ConvertProfileToListModel(users, false);
                });
        }

        public async Task<WebApiResult<UserListModel>> GetUsersBySubsidiaryAsync(long subsidiaryId, long roleId)
        {
            return await Guard.TryCatch<UserListModel>(
                async () =>
                {
                    var users = await _userRepository.GetUsersInSubsidiaryAsync(subsidiaryId, roleId.ToString());

                    return this.ConvertUserToListModel(users, false);
                });
        }

        public async Task<WebApiResult<UserListModel>> GetUsersByDepartmentAsync(long departmentId)
        {
            return await Guard.TryCatch<UserListModel>(
                async () =>
                {
                    var users = await _userRepository.GetUsersInDepartmentAsync(departmentId);

                    return this.ConvertProfileToListModel(users, false);
                });
        }

        public async Task<WebApiResult<UserListModel>> GetUsersByDepartmentAsync(long departmentId, long roleId)
        {
            return await Guard.TryCatch<UserListModel>(
                async () =>
                {
                    var users = await _userRepository.GetUsersInDepartmentAsync(departmentId, roleId.ToString());

                    return this.ConvertUserToListModel(users, false);
                });
        }

        public async Task<WebApiResult<NavigationListModel>> GetViewsAsync(string userId)
        {
            return await Guard.TryCatch<NavigationListModel>(
                async () =>
                {
                    var views = await _userRepository.GetViewsAsync(userId);

                    var result = new List<NavigationListModel>();

                    foreach (var vl in views)
                    {
                        var navBtn = this.ConvertViewLinkToModel(vl);

                        var navGroup = result.SelectMany(x => x.Children).FirstOrDefault(m => m.ViewName == vl.Parent.Number) ?? this.ConvertViewDirectoryToModel(vl.Parent, NavigationCategory.Group);
                        navGroup.Children.Add(navBtn);

                        var navPage = result.FirstOrDefault(x => x.ViewName == vl.Parent.Parent.Number);
                        
                        if(navPage != null && navPage.Children.Count(x=>x.ViewName == navGroup.ViewName) <= 0)
                            navPage.Children.Add(navGroup);

                        if (navPage == null)
                        {
                            navPage = this.ConvertViewDirectoryToModel(vl.Parent.Parent, NavigationCategory.Page);
                            navPage.Children.Add(navGroup);

                            result.Add(navPage);
                        }
                    }
                    
                    return result;
                });
        }

        public async Task<WebApiResult<string>> GetFunctionsAsync(string userId)
        {
            return await Guard.TryCatch<string>(
                async () =>
                {
                    var views = await _userRepository.GetFunctionsAsync(userId);
                    
                    return views.Select(x => x.Number);
                });
        }

        public async Task<WebApiResult<string>> AddAsync(UserEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var userId = HttpContext.Current.User.Identity.GetUserId();
                    var user = new ApplicationUser()
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        LockoutEnabled = model.LockoutEnabled
                    };

                    user.Profile = new UserProfile()
                    {
                        FullName = model.FullName,
                        Alias = model.Alias,
                        StaffNumber = model.StaffNumber,
                        Gender = model.Gender.ToEnum<Gender>(),
                        Designation = model.Designation,
                        JoinDate = model.JoinDate,
                        SubsidiaryId = model.SubsidiaryId,
                        DepartmentId = model.DepartmentId,
                        Tel = model.Phone,
                        Remark = model.Remark, 
                        CreatorId = userId,
                        ModificatorId = userId
                    };

                    await _userRepository.InsertAsync(user, model.UserName);
                });
        }

        public async Task<WebApiResult<string>> UpdateAsync(UserEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var userId = HttpContext.Current.User.Identity.GetUserId();
                    var user = await _userRepository.FindByIdAsync(model.UserId);

                    user.Email = model.Email;
                    user.PhoneNumber = model.Mobile;
                    user.LockoutEnabled = model.LockoutEnabled;
                    user.LockoutEndDateUtc = model.LockoutEnabled ? DateTime.Now : new Nullable<DateTime>();
                    user.Profile.FullName = model.FullName;
                    user.Profile.Alias = model.Alias;
                    user.Profile.StaffNumber = model.Number;
                    user.Profile.Gender = model.Gender.ToEnum<Gender>();
                    user.Profile.Designation = model.Designation;
                    user.Profile.JoinDate = model.JoinDate;
                    user.Profile.SubsidiaryId = model.SubsidiaryId <= 0 ? user.Profile.SubsidiaryId : model.SubsidiaryId;
                    user.Profile.DepartmentId = model.DepartmentId;
                    user.Profile.Tel = model.Phone;
                    user.Profile.Remark = model.Remark;
                    user.Profile.ModificatorId = userId;
                    user.Profile.ModifyDate = DateTime.Now;

                    await _userRepository.UpdateAsync(user);
                });
        }

        private IEnumerable<UserListModel> ConvertUserToListModel(IEnumerable<ApplicationUser> users, bool isShowDepartment = true)
        {
            var result = new List<UserListModel>();

            foreach (var user in users)
            {
                result.Add(new UserListModel()
                {
                    Id = 10000,
                    UserId = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FullName = user.Profile.FullName,
                    Alias = user.Profile.Alias,
                    Gender = user.Profile.Gender.ToString(),
                    Department = isShowDepartment ? user.Profile.Department.DisplayName : string.Empty,
                    Designation = user.Profile.Designation,
                    JoinDate = user.Profile.JoinDate,
                    Status = user.LockoutEnabled
                });
            }

            return result;
        }

        private IEnumerable<UserListModel> ConvertProfileToListModel(IEnumerable<UserProfile> profiles, bool isShowDepartment)
        {
            var result = new List<UserListModel>();

            foreach(var profile in profiles)
            {
                result.Add(new UserListModel()
                {
                    Id = 10000,
                    UserId = profile.Id,
                    UserName = profile.User.UserName,
                    Email = profile.User.Email,
                    FullName = profile.FullName,
                    Alias = profile.Alias,
                    Gender = profile.Gender.ToString(),
                    Department = isShowDepartment ? profile.Department.DisplayName : string.Empty,
                    Designation = profile.Designation,
                    JoinDate = profile.JoinDate,
                    Status = profile.User.LockoutEnabled
                });
            }

            return result;
        }

        private NavigationListModel ConvertViewLinkToModel(ViewLink link)
        {
            return new NavigationListModel()
            {
                DisplayName = link.DisplayName,
                ViewName = link.ViewName,
                Category = NavigationCategory.Button,
                ListOrder = link.ListOrder
            };
        }

        private NavigationListModel ConvertViewDirectoryToModel(ViewLinkDirectory directory, NavigationCategory category)
        {
            return new NavigationListModel()
            {
                DisplayName = directory.DisplayName,
                ViewName = directory.Number,
                Category = category,
                ListOrder = directory.ListOrder
            };
        }
    }
}

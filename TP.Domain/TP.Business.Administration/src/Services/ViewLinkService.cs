using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Business.Administration.Interfaces;
using TP.WL.ERP.Model.Administration;
using TP.Repository.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Extensions;

namespace TP.Business.Administration.Services
{
    public class ViewLinkService : IViewLinkService
    {
        private readonly IViewLinkRepository _linkRepository;

        public ViewLinkService(IViewLinkRepository linkRepository)
        {
            _linkRepository = linkRepository ?? throw new ArgumentNullException(nameof(linkRepository));
        }

        public async Task<WebApiResult<ViewLinkListModel>> GetAllAsync()
        {
            return await Guard.TryCatch<ViewLinkListModel>(
                async () =>
                {
                    var directories = await _linkRepository.FindAllAsync();

                    var result = new List<ViewLinkListModel>();

                    foreach (var directory in directories)
                    {
                        result.Add(this.ConvertDirectoryToLinkModel(directory));

                        foreach (var link in directory.Links)
                            result.Add(this.ConvertLinkToLinkModel(link));
                    }

                    return result;
                });
        }

        public async Task<WebApiResult<ViewLinkListModel>> GetAllEnabledAsync()
        {
            return await Guard.TryCatch<ViewLinkListModel>(
                async () =>
                {
                    var directories = await _linkRepository.FindAllEnabledAsync();

                    var result = new List<ViewLinkListModel>();

                    foreach (var directory in directories)
                    {
                        result.Add(this.ConvertDirectoryToLinkModel(directory));

                        foreach (var link in directory.Links.Where(x => x.IsEnabled))
                            result.Add(this.ConvertLinkToLinkModel(link));
                    }

                    return result;
                });
        }

        public async Task<WebApiResult<ViewLinkListModel>> GetDirectoriesAsync()
        {
            return await Guard.TryCatch<ViewLinkListModel>(
                async () =>
                {
                    var directories = await _linkRepository.FindDirectoriesAsync();

                    var result = new List<ViewLinkListModel>();

                    foreach (var directory in directories)
                        result.Add(this.ConvertDirectoryToLinkModel(directory));

                    return result;
                });
        }

        public async Task<WebApiResult<ViewLinkListModel>> GetLinksAsync(long directoryId)
        {
            return await Guard.TryCatch<ViewLinkListModel>(
                async () =>
                {
                    var links = await _linkRepository.FindLinksAsync(directoryId);

                    var result = new List<ViewLinkListModel>();

                    foreach (var link in links)
                        result.Add(this.ConvertLinkToLinkModel(link));

                    return result;
                });
        }

        public async Task<WebApiResult<FunctionListModel>> GetFunctionsAsync()
        {
            return await Guard.TryCatch<FunctionListModel>(
                async () =>
                {
                    var functions = await _linkRepository.FindFunctionsAsync();

                    var result = new List<FunctionListModel>();

                    foreach (var func in functions)
                        result.Add(this.ConvertFuncToFunctionModel(func));

                    foreach (var link in functions.Select(x => x.ViewLink).Where(x => x.IsEnabled).Distinct())
                        result.Insert(result.FindIndex(x => x.ParentId == link.Id), this.ConvertLinkToFunctionModel(link));

                    var parentDirectories = functions.Select(x => x.ViewLink.Parent).Where(x => x.IsEnabled).Distinct();

                    foreach (var directory in parentDirectories)
                        result.Insert(result.FindIndex(x => x.ParentId == directory.Id), this.ConvertDirectoryToFunctionModel(directory));

                    foreach (var dir in await GetParentDirectoryFuncitonsAsync(parentDirectories.Select(x => x.ParentId.Value)))
                        result.Insert(result.FindIndex(x => x.ParentId == dir.Id), this.ConvertDirectoryToFunctionModel(dir));

                    return result;
                });
        }

        public async Task<WebApiResult<FunctionListModel>> GetFunctionsAsync(long linkId)
        {
            return await Guard.TryCatch<FunctionListModel>(
                async () =>
                {
                    var functions = await _linkRepository.FindFunctionsAsync(linkId);

                    var result = new List<FunctionListModel>();

                    foreach (var func in functions)
                        result.Add(this.ConvertFuncToFunctionModel(func));

                    return result;
                });
        }

        public async Task<WebApiResult<FunctionListModel>> GetFunctionsAsync(string linkIds)
        {
            return await Guard.TryCatch<FunctionListModel>(
                async () =>
                {
                    var newLinks = linkIds.Split(',').ToListOfLong();

                    IEnumerable<ViewLinkFunction> functions = null;

                    if (newLinks.Count() > 0)
                        functions = await _linkRepository.FindFunctionsAsync(newLinks);
                    else
                        functions = await _linkRepository.FindFunctionsAsync();

                    var result = new List<FunctionListModel>();

                    foreach (var function in functions)
                        result.Add(this.ConvertFuncToFunctionModel(function));

                    foreach (var link in functions.Select(x => x.ViewLink).Where(x => x.IsEnabled).Distinct())
                        result.Insert(result.FindIndex(x => x.ParentId == link.Id), this.ConvertLinkToFunctionModel(link));

                    var parentDirectories = functions.Select(x => x.ViewLink.Parent).Where(x => x.IsEnabled).Distinct();

                    foreach (var directory in parentDirectories)
                        result.Insert(result.FindIndex(x => x.ParentId == directory.Id), this.ConvertDirectoryToFunctionModel(directory));

                    foreach (var dir in await GetParentDirectoryFuncitonsAsync(parentDirectories.Select(x => x.ParentId.Value)))
                        result.Insert(result.FindIndex(x => x.ParentId == dir.Id), this.ConvertDirectoryToFunctionModel(dir));

                    return result;
                });
        }

        public async Task<WebApiResult<string>> AddLinkAsync(ViewLinkEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    if (model.IsGroup)
                    {
                        var directory = new ViewLinkDirectory()
                        {
                            ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>(),
                            Number = model.Number,
                            DisplayName = model.DisplayName,
                            Description = model.Description,
                            IconSource = model.IconSource,
                            ListOrder = model.ListOrder,
                            IsEnabled = model.IsEnabled,
                            CreateDate = DateTime.Now
                        };

                        await _linkRepository.InsertDirectoryAsync(directory);
                    }
                    else
                    {
                        var link = new ViewLink()
                        {
                            ParentId = model.ParentId,
                            Number = model.Number,
                            DisplayName = model.DisplayName,
                            ViewName = model.ViewName,
                            Description = model.Description,
                            IconSource = model.IconSource,
                            ListOrder = model.ListOrder,
                            IsEnabled = model.IsEnabled,
                            CreateDate = DateTime.Now
                        };

                        await _linkRepository.InsertLinkAsync(link);
                    }
                });
        }

        public async Task<WebApiResult<string>> AddFunctionAsync(FunctionEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var function = new ViewLinkFunction()
                    {
                        Number = model.Number,
                        DisplayName = model.DisplayName,
                        ListOrder = model.ListOrder,
                        IsEnabled = model.IsEnabled,
                        ViewLinkId = model.ViewLinkId
                    };

                    await _linkRepository.InsertFunctionAsync(function);
                });
        }

        public async Task<WebApiResult<string>> AddFunctionsAsync(FunctionBatchEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var functions = new List<ViewLinkFunction>();
                    var listOrder = 0;

                    foreach (var category in model.Categories)
                    {
                        functions.Add(new ViewLinkFunction()
                        {
                            ViewLinkId = model.ViewLinkId,
                            Number = $"{model.Number}-{category.Key.ToString()}",
                            DisplayName = $"{category.Value}{model.DisplayName}",
                            ListOrder = listOrder,
                            IsEnabled = true,
                        });

                        listOrder++;
                    }

                    await _linkRepository.BulkInsertFunctionsAsync(functions);
                });
        }

        public async Task<WebApiResult<string>> UpdateLinkAsync(ViewLinkEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    if (model.IsGroup)
                    {
                        var directory = await _linkRepository.FindDirectoryByIdAsync(model.Id);

                        directory.ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>();
                        directory.Number = model.Number;
                        directory.DisplayName = model.DisplayName;
                        directory.Description = model.Description;
                        directory.IconSource = model.IconSource;
                        directory.ListOrder = model.ListOrder;
                        directory.IsEnabled = model.IsEnabled;

                        await _linkRepository.UpdateDirectoryAsync(directory);
                    }
                    else
                    {
                        var link = await _linkRepository.FindLinkByIdAsync(model.Id);

                        link.ParentId = model.ParentId;
                        link.Number = model.Number;
                        link.DisplayName = model.DisplayName;
                        link.ViewName = model.ViewName;
                        link.Description = model.Description;
                        link.IconSource = model.IconSource;
                        link.ListOrder = model.ListOrder;
                        link.IsEnabled = model.IsEnabled;

                        await _linkRepository.UpdateLinkAsync(link);
                    }
                });
        }

        public async Task<WebApiResult<string>> UpdateFunctionAsync(FunctionEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var function = await _linkRepository.FindFunctionByIdAsync(model.Id);

                    function.Number = model.Number;
                    function.DisplayName = model.DisplayName;
                    function.ViewLinkId = model.ViewLinkId;
                    function.ListOrder = model.ListOrder;
                    function.IsEnabled = model.IsEnabled;

                    await _linkRepository.UpdateFunctionAsync(function);
                });
        }

        private async Task<IEnumerable<ViewLinkDirectory>> GetParentDirectoryFuncitonsAsync(IEnumerable<long> parentIds)
        {
            var result = new List<ViewLinkDirectory>();

            var directories = await _linkRepository.FindDirectoriesAsync(parentIds);

            result.AddRange(directories);

            if (directories.Where(x => x.ParentId.HasValue).Count() > 0)
            {
                result.AddRange(await this.GetParentDirectoryFuncitonsAsync(directories.Select(x => x.ParentId.Value)));
            }

            return result;
        }

        private ViewLinkListModel ConvertDirectoryToLinkModel(ViewLinkDirectory directory)
        {
            return new ViewLinkListModel()
            {
                ParentId = directory.ParentId ?? 0,
                Id = directory.Id,
                Number = directory.Number,
                DisplayName = directory.DisplayName,
                IconSource = directory.IconSource,
                ListOrder = directory.ListOrder,
                IsEnabled = directory.IsEnabled,
                IsGroup = true
            };
        }

        private ViewLinkListModel ConvertLinkToLinkModel(ViewLink link)
        {
            return new ViewLinkListModel()
            {
                ParentId = link.ParentId,
                Id = link.Id,
                Number = link.Number,
                DisplayName = link.DisplayName,
                ViewName = link.ViewName,
                Description = link.Description,
                IconSource = link.IconSource,
                ListOrder = link.ListOrder,
                IsEnabled = link.IsEnabled
            };
        }

        private FunctionListModel ConvertDirectoryToFunctionModel(ViewLinkDirectory directory)
        {
            return new FunctionListModel()
            {
                Id = directory.Id,
                ParentId = directory.ParentId ?? 0,
                Number = directory.Number,
                DisplayName = directory.DisplayName,
                ListOrder = directory.ListOrder,
                IsEnabled = directory.IsEnabled
            };
        }

        private FunctionListModel ConvertLinkToFunctionModel(ViewLink link)
        {
            return new FunctionListModel()
            {
                Id = link.Id,
                ParentId = link.ParentId,
                Number = link.Number,
                DisplayName = link.DisplayName,
                ListOrder = link.ListOrder,
                IsEnabled = link.IsEnabled
            };
        }

        private FunctionListModel ConvertFuncToFunctionModel(ViewLinkFunction function)
        {
            return new FunctionListModel()
            {
                Id = function.Id,
                ParentId = function.ViewLinkId,
                Number = function.Number,
                DisplayName = function.DisplayName,
                ListOrder = function.ListOrder,
                IsEnabled = function.IsEnabled,
                IsFunction = true
            };
        }
    }
}

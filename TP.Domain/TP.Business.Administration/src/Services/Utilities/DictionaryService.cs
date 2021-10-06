using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using TP.Business.Administration.Interfaces;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Extensions;
using TP.Repository.Administration.Interfaces;
using TP.WL.ERP.Model.Utilities;

namespace TP.Business.Administration.Services
{
    public class DictionaryService : IDictionaryService
    {
        private readonly IDictionaryRepository _dictionaryRepository;

        public DictionaryService(IDictionaryRepository dictionaryRepository)
        {
            _dictionaryRepository = dictionaryRepository ?? throw new ArgumentNullException(nameof(dictionaryRepository));
        }

        public async Task<WebApiResult<DictionaryTypeListModel>> GetTypesAsync()
        {
            return await Guard.TryCatch<DictionaryTypeListModel>(
                async () =>
                {
                    var types = await _dictionaryRepository.FindTypesAsync();

                    return ConvertTypeToModel(types);
                });
        }

        public async Task<WebApiResult<DictionaryTypeListModel>> GetTypesAsync(long parentId)
        {
            return await Guard.TryCatch<DictionaryTypeListModel>(
                async () =>
                {
                    var newId = parentId > 0 ? parentId : new Nullable<long>();
                    var types = await _dictionaryRepository.FindTypesByParentAsync(newId);

                    return ConvertTypeToModel(types);
                });
        }

        public async Task<WebApiResult<DictionaryDataEditModel>> GetDataAsync(long id)
        {
            return await Guard.TryCatch<DictionaryDataEditModel>(
                async () =>
                {
                    var data = await _dictionaryRepository.FindDataByIdAsync(id);

                    var result = new List<DictionaryDataEditModel>
                    {
                        new DictionaryDataEditModel()
                        {
                            Id = data.Id,
                            TypeId = data.TypeId,
                            DisplayName = data.DisplayName,
                            Value = data.Value,
                            ListOrder = data.ListOrder,
                            Remark = data.Remark,
                            IsEnabled = data.IsEnabled
                        }
                    };

                    return result;
                });
        }

        public async Task<WebApiResult<DictionaryDataListModel>> GetDatasAsync(long typeId)
        {
            return await Guard.TryCatch<DictionaryDataListModel>(
                async () =>
                {
                    var datas = await _dictionaryRepository.FindDatasByTypeAsync(typeId);

                    var results = new List<DictionaryDataListModel>();

                    foreach (var data in datas)
                    {
                        results.Add(new DictionaryDataListModel()
                        {
                            Id = data.Id,
                            TypeId = data.TypeId,
                            DisplayName = data.DisplayName,
                            Value = data.Value,
                            ListOrder = data.ListOrder,
                            IsEnabled = data.IsEnabled,
                            Remark = data.Remark,
                        });
                    }

                    return results;
                });
        }

        public async Task<WebApiResult<DictionaryTypeEditModel>> GetTypeAsync(long id)
        {
            return await Guard.TryCatch<DictionaryTypeEditModel>(
                async () =>
                {
                    var type = await _dictionaryRepository.FindTypeByIdAsync(id);

                    var result = new List<DictionaryTypeEditModel>
                    {
                        new DictionaryTypeEditModel()
                        {
                            Id = type.Id,
                            ParentId = type.ParentId ?? 0,
                            DisplayName = type.DisplayName,
                            ListOrder = type.ListOrder,
                            Remark = type.Remark
                        }
                    };

                    return result;
                });
        }

        public async Task<WebApiResult<string>> AddTypeAsync(DictionaryTypeEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var type = new DictionaryType()
                    {
                        ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>(),
                        Number = model.Number,
                        DisplayName = model.DisplayName,
                        ListOrder = model.ListOrder,
                        Remark = model.Remark
                    };

                    await _dictionaryRepository.InsertTypeAsync(type);
                });
        }

        public async Task<WebApiResult<string>> AddDataAsync(DictionaryDataEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var userId = HttpContext.Current.User.Identity.GetUserId();

                    var data = new DictionaryData()
                    {
                        TypeId = model.TypeId,
                        DisplayName = model.DisplayName,
                        Value = model.Value,
                        ListOrder = model.ListOrder,
                        IsEnabled = model.IsEnabled,
                        Remark = model.Remark,
                        ModificatorId = userId,
                        ModifyDate = DateTime.Now
                    };

                    await _dictionaryRepository.InsertDataAsync(data);
                });
        }

        public async Task<WebApiResult<string>> AddDatasAsync(DictionaryDataBatchEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var strDatas = model.Mode.ToEnum<BulkMode>() == BulkMode.Delimiter ? model.Data.Split(new char[] { ',', '，', ';', '；', '/', '、' }, StringSplitOptions.RemoveEmptyEntries)
                        : model.Data.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    var level = model.ListOrder;
                    var datas = new List<DictionaryData>();

                    var userId = HttpContext.Current.User.Identity.GetUserId();

                    foreach (var item in strDatas)
                    {
                        var dd = new DictionaryData()
                        {
                            TypeId = model.TypeId,
                            DisplayName = item,
                            Value = item,
                            ListOrder = level,
                            IsEnabled = true,
                            ModificatorId = userId,
                            ModifyDate = DateTime.Now
                        };

                        datas.Add(dd);
                        level++;
                    }

                    await _dictionaryRepository.BulkInsertDatasAsync(datas);
                });
        }

        public async Task<WebApiResult<string>> UpdateTypeAsync(DictionaryTypeEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var type = await _dictionaryRepository.FindTypeByIdAsync(model.Id);

                    type.ParentId = model.ParentId > 0 ? model.ParentId : new Nullable<long>();
                    type.DisplayName = model.DisplayName;
                    type.ListOrder = model.ListOrder;
                    type.Remark = model.Remark;

                    await _dictionaryRepository.UpdateTypeAsync(type);
                });
        }

        public async Task<WebApiResult<string>> UpdateDataAsync(DictionaryDataEditModel model)
        {
            return await Guard.TryCatch(
                async () =>
                {
                    var userId = HttpContext.Current.User.Identity.GetUserId();
                    var data = await _dictionaryRepository.FindDataByIdAsync(model.Id);

                    data.TypeId = model.TypeId;
                    data.DisplayName = model.DisplayName;
                    data.Value = model.Value;
                    data.ListOrder = model.ListOrder;
                    data.IsEnabled = model.IsEnabled;
                    data.Remark = model.Remark;
                    data.ModificatorId = userId;
                    data.ModifyDate = DateTime.Now;

                    await _dictionaryRepository.UpdateDataAsync(data);
                });
        }

        private ICollection<DictionaryTypeListModel> ConvertTypeToModel(IEnumerable<DictionaryType> types)
        {
            var results = new List<DictionaryTypeListModel>();

            foreach (var type in types)
            {
                results.Add(new DictionaryTypeListModel()
                {
                    Id = type.Id,
                    ParentId = type.ParentId ?? 0,
                    DisplayName = type.DisplayName,
                    ListOrder = type.ListOrder
                });
            }

            return results;
        }
    }
}

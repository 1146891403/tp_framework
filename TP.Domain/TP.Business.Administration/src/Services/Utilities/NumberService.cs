using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Business.Administration.Interfaces;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Extensions;
using TP.Repository.Administration.Interfaces;
using TP.WL.ERP.Model.Utilities;

namespace TP.Business.Administration.Services
{
    public class NumberService : INumberService
    {
        private readonly INumberRepository _numberRepository;

        public NumberService(INumberRepository numberRepository)
        {
            _numberRepository = numberRepository ?? throw new ArgumentNullException(nameof(numberRepository));
        }

        public Task<WebApiResult<NumberTemplateListModel>> GetTemplatesAsync()
        {
            return Guard.TryCatch<NumberTemplateListModel>(
                async () =>
                {
                    var templates = await _numberRepository.FindTemplatesAsync();

                    var result = new List<NumberTemplateListModel>();
                    foreach(var temp in templates)
                    {
                        result.Add(new NumberTemplateListModel()
                        {
                            Id = temp.Id,
                            Number = temp.Number,
                            Description = temp.Description,
                            Body = temp.Body,
                            ResetCriterion = temp.ResetCriterion,
                            Seed = temp.Seed,
                            Format = temp.Format.ToString()
                        });
                    }

                    return result;
                });
        }

        public Task<WebApiResult<NumberInstanceListModel>> GetInstancesAsync()
        {
            return Guard.TryCatch<NumberInstanceListModel>(
                async () =>
                {
                    var instances = await _numberRepository.FindInstancesAsync();

                    var result = new List<NumberInstanceListModel>();
                    foreach(var inst in instances)
                    {
                        result.Add(new NumberInstanceListModel()
                        {
                            Id = inst.Id,
                            ApplicationName = inst.ApplicationName,
                            Prefix = inst.Prefix,
                            Seed = inst.Seed,
                            IsEnabled = inst.IsEnabled
                        });
                    }

                    return result;
                });
        }

        public Task<WebApiResult<string>> AddTemplateAsync(NumberTemplateEditModel model)
        {
            return Guard.TryCatch(
                async () =>
                {
                    var template = new DateFormattedNumberTemplate()
                    {
                        Number = model.Number,
                        Description = model.Description,
                        Body = model.Body,
                        ResetCriterion = model.ResetCriterion,
                        Seed = model.Seed,
                        Format = model.Format.ToEnum<NumberFormat>(),
                        Comment = model.Comment
                    };

                    await _numberRepository.InsertTemplateAsync(template);
                });
        }

        public Task<WebApiResult<string>> AddInstanceAsync(NumberInstanceEditModel model)
        {
            return Guard.TryCatch(
                async () =>
                {
                    var instance = new DateFormattedNumberInstance()
                    {
                        TemplateId = model.TemplateId,
                        ApplicationName = model.ApplicationName,
                        Prefix = model.Prefix,
                        Seed = model.Seed,
                        IsEnabled = model.IsEnabled,
                        SubsidiaryId = model.SubsidiaryId
                    };

                    await _numberRepository.InsertInstanceAsync(instance);
                });
        }
    }
}

using System;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Business.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.WL.ERP.Model.Utilities;

namespace TP.WL.ERP.WebApi.Controllers.Administration
{
    [Authorize]
    [RoutePrefix("api/dictionaries")]
    public class DictionaryController : ApiController
    {
        private readonly IDictionaryService _dictionaryService;

        public DictionaryController(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService ?? throw new ArgumentNullException(nameof(dictionaryService));
        }

        [Route("get_types"), HttpGet]
        public async Task<WebApiResult<DictionaryTypeListModel>> GetAllAsync()
        {
            return await _dictionaryService.GetTypesAsync();
        }

        [Route("get_types"), HttpGet]
        public async Task<WebApiResult<DictionaryTypeListModel>> GetTypeByParentIdAsync(long parentId)
        {
            return await _dictionaryService.GetTypesAsync(parentId);
        }

        [Route("get_datas"), HttpGet]
        public async Task<WebApiResult<DictionaryDataListModel>> GetDataByTypeIdAsync(long typeId)
        {
            return await _dictionaryService.GetDatasAsync(typeId);
        }

        [Route("add_type"), HttpPost]
        public async Task<WebApiResult<string>> AddTypeAsync(DictionaryTypeEditModel model)
        {
            return await _dictionaryService.AddTypeAsync(model);
        }

        [Route("update_type"), HttpPut]
        public async Task<WebApiResult<string>> UpdateTypeAsync(DictionaryTypeEditModel model)
        {
            return await _dictionaryService.UpdateTypeAsync(model);
        }

        [Route("add_data"), HttpPost]
        public async Task<WebApiResult<string>> AddDataAsync(DictionaryDataEditModel model)
        {
            return await _dictionaryService.AddDataAsync(model);
        }

        [Route("bulk_add_data"), HttpPost]
        public async Task<WebApiResult<string>> BatchAddDataAsync(DictionaryDataBatchEditModel model)
        {
            return await _dictionaryService.AddDatasAsync(model);
        }

        [Route("update_data"), HttpPut]
        public async Task<WebApiResult<string>> UpdateDataAsync(DictionaryDataEditModel model)
        {
            return await _dictionaryService.UpdateDataAsync(model);
        }
    }
}
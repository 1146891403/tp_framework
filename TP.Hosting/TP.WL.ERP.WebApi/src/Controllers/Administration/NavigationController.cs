using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Business.Administration.Interfaces;
using TP.Infrastructure.Common;
using TP.WL.ERP.Model.Administration;

namespace TP.WL.ERP.WebApi.Controllers.Administration
{
    //[Authorize]
    [RoutePrefix("api/navs")]
    public class NavigationController : ApiController
    {
        private readonly IViewLinkService _linkService;

        public NavigationController(IViewLinkService linkService)
        {
            _linkService = linkService ?? throw new ArgumentNullException(nameof(linkService));
        }

        [Route("get_all"), HttpGet]
        public async Task<WebApiResult<ViewLinkListModel>> GetAllAsync()
        {
            return await _linkService.GetAllAsync();
        }

        [Route("get_all_enabled"), HttpGet]
        public async Task<WebApiResult<ViewLinkListModel>> GetAllEnabledAsync()
        {
            return await _linkService.GetAllEnabledAsync();
        }

        [Route("get_directories"), HttpGet]
        public async Task<WebApiResult<ViewLinkListModel>> GetDirectoriesAsync()
        {
            return await _linkService.GetDirectoriesAsync();
        }

        [Route("get_links"), HttpGet]
        public async Task<WebApiResult<ViewLinkListModel>> GetLinksAsync(long directoryId)
        {
            return await _linkService.GetLinksAsync(directoryId);
        }

        [Route("get_functions"), HttpGet]
        public async Task<WebApiResult<FunctionListModel>> GetFunctionsAsync()
        {
            return await _linkService.GetFunctionsAsync();
        }

        [Route("get_functions"), HttpGet]
        public async Task<WebApiResult<FunctionListModel>> GetFunctionsAsync(long linkId)
        {
            return await _linkService.GetFunctionsAsync(linkId);
        }

        [Route("get_functions"), HttpGet]
        public async Task<WebApiResult<FunctionListModel>> GetFunctionsAsync(string linkIds)
        {
            return await _linkService.GetFunctionsAsync(linkIds);
        }

        [Route("add_link"), HttpPost]
        public async Task<WebApiResult<string>> AddLinkAsync(ViewLinkEditModel model)
        {
            return await _linkService.AddLinkAsync(model);
        }

        [Route("add_function"), HttpPost]
        public async Task<WebApiResult<string>> AddFunctionAsync(FunctionEditModel model)
        {
            return await _linkService.AddFunctionAsync(model);
        }

        [Route("bulk_add_function"), HttpPost]
        public async Task<WebApiResult<string>> BulkAddFunctionAsync(FunctionBatchEditModel model)
        {
            return await _linkService.AddFunctionsAsync(model);
        }

        [Route("update_link"), HttpPut]
        public async Task<WebApiResult<string>> UpdateLinkAsync(ViewLinkEditModel model)
        {
            return await _linkService.UpdateLinkAsync(model);
        }

        [Route("update_function"), HttpPut]
        public async Task<WebApiResult<string>> UpdateFunctionAsync(FunctionEditModel model)
        {
            return await _linkService.UpdateFunctionAsync(model);
        }
    }
}

using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using TP.Infrastructure.Common;
using TP.WL.ERP.Business.Crm.Interfaces;
using TP.WL.ERP.Model.Crm;

namespace TP.WL.ERP.WebApi.Controllers.Crm
{
    [RoutePrefix("api/certificates")]
    public class CertificateController : ApiController
    {
        private readonly ICertificateService _certificateService;

        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService ?? throw new ArgumentNullException(nameof(certificateService));
        }

        [Route("get_all"), HttpGet]
        public async Task<WebApiResult<CertificateListModel>> GetAllAsync()
        {
            return await _certificateService.GetAllAsync();
        }
    }
}

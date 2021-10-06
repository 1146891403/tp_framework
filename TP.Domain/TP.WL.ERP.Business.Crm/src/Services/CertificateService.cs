using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using TP.Infrastructure.Common;
using TP.WL.ERP.Business.Crm.Interfaces;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Model.Crm;
using TP.WL.ERP.Repository.Crm.Interfaces;

namespace TP.WL.ERP.Business.Crm.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;

        public CertificateService(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository ?? throw new ArgumentNullException(nameof(certificateRepository));
        }

        public Task<WebApiResult<CertificateListModel>> GetAllAsync()
        {
            return Guard.TryCatch<CertificateListModel>(
                async () =>
                {
                    var certificates = await _certificateRepository.GetAllAsync();

                    var result = new List<CertificateListModel>();

                    foreach(var cert in certificates)
                    {
                        result.Add(new CertificateListModel()
                        {
                            Id = cert.Id,
                            Number = cert.Number,
                            DisplayName = cert.DisplayName,
                            IsGuarantee = cert.IsGuarantee,
                            IsTestReport = cert.IsTestReport,
                            IsGuaranteeOrReport = cert.IsGuaranteeOrReport,
                            LifetimeScope = cert.LifetimeScope,
                            StartDate = cert.StartDate,
                            EndDate = cert.EndDate,
                            IsDefault = cert.IsDefault
                        });
                    }

                    return result;
                });
        }

        public Task<WebApiResult<CertificateEditModel>> GetAsync(long id)
        {
            return Guard.TryCatch<CertificateEditModel>(
                async () =>
                {
                    var certificate = await _certificateRepository.FindByIdAsync(id);

                    return new List<CertificateEditModel>()
                    {
                        new CertificateEditModel()
                        {
                            Id = certificate.Id,
                            Number = certificate.Number,
                            DisplayName = certificate.DisplayName,
                            IsGuarantee = certificate.IsGuarantee,
                            IsTestReport = certificate.IsTestReport,
                            IsGuaranteeOrReport = certificate.IsGuaranteeOrReport,
                            LifetimeScope = certificate.LifetimeScope,
                            StartDate = certificate.StartDate,
                            EndDate = certificate.EndDate,
                            IsDefault = certificate.IsDefault
                        }
                    };
                });
        }

        public Task<WebApiResult<string>> AddAsync(CertificateEditModel model, string userId)
        {
            return Guard.TryCatch(
                async () =>
                {
                    var certificate = new Certificate()
                    {
                        Number = model.Number,
                        DisplayName = model.DisplayName,
                        IsGuarantee = model.IsGuarantee,
                        IsTestReport = model.IsTestReport,
                        IsGuaranteeOrReport = model.IsGuaranteeOrReport,
                        LifetimeScope = model.LifetimeScope,
                        StartDate = model.StartDate,
                        EndDate = model.EndDate,
                        IsDefault = model.IsDefault,
                        CreatorId = userId,
                        ModificatorId = userId,
                    };

                    await _certificateRepository.InsertAsync(certificate);
                });
        }

        public Task<WebApiResult<string>> UpdateAsync(CertificateEditModel model, string userId)
        {
            return Guard.TryCatch(
                async () =>
                {
                    var certificate = await _certificateRepository.FindByIdAsync(model.Id);

                    certificate.IsGuarantee = model.IsGuarantee;
                    certificate.IsTestReport = model.IsTestReport;
                    certificate.IsGuaranteeOrReport = model.IsGuaranteeOrReport;
                    certificate.LifetimeScope = model.LifetimeScope;
                    certificate.StartDate = model.StartDate;
                    certificate.EndDate = model.EndDate;
                    certificate.IsDefault = model.IsDefault;
                    certificate.ModificatorId = userId;
                    certificate.ModifyDate = DateTime.Now;

                    await _certificateRepository.UpdateAsync(certificate);
                });
        }
    }
}

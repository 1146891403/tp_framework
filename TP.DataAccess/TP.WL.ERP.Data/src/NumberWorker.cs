using System;
using System.Linq;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Data.Repository.EntityFramework;

namespace TP.WL.ERP.Data.Extensions
{
    public class NumberWorker
    {
        public const string DefaultTemplate = "DefaultTemplate";

        private static IDbContextProvider<ApplicationDbContext> _dbContextProvider;
        private static object syncRoot = new object();

        public NumberWorker(IDbContextProvider<ApplicationDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider ?? throw new ArgumentNullException(nameof(dbContextProvider));
        }
        
        public static string Generate(string applicationName, long subsidiaryId)
        {
            return Generate(DefaultTemplate, applicationName, subsidiaryId);
        }

        public static string Generate(string templateNumber, string applicationName, long subsidiaryId)
        {
            lock (syncRoot)
            {
                var template = _dbContextProvider.GetDbContext().Set<DateFormattedNumberTemplate>().SingleOrDefault(x => x.Number == templateNumber);
                if (template == null)
                    throw new InvalidOperationException("單號模板沒有發現！請聯繫系統管理員添加！");

                var numberInstance = _dbContextProvider.GetDbContext().Set<DateFormattedNumberInstance>()
                    .SingleOrDefault(x => x.TemplateId == template.Id && x.ApplicationName == applicationName && x.SubsidiaryId == subsidiaryId && x.IsEnabled);
                if (numberInstance == null)
                    throw new InvalidOperationException("單號模板沒有發現！請聯繫系統管理員添加！");

                DateTime lastGeneratedDate = numberInstance.LastGenerateDate; numberInstance.LastGenerateDate = DateTime.Now;
                if (string.Format(template.ResetCriterion, numberInstance.LastGenerateDate) == string.Format(template.ResetCriterion, lastGeneratedDate))
                    numberInstance.Seed++;
                else
                    numberInstance.Seed = template.Seed;

                _dbContextProvider.GetDbContext().SaveChanges();

                return string.Format(template.Body, numberInstance.Prefix, numberInstance.LastGenerateDate, numberInstance.Seed);
            }
        }
    }
}

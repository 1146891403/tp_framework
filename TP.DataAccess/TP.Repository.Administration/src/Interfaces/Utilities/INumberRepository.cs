using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface INumberRepository : IRepository
    {
        Task<IEnumerable<DateFormattedNumberTemplate>> FindTemplatesAsync();

        Task<IEnumerable<DateFormattedNumberInstance>> FindInstancesAsync();

        Task<bool> InsertTemplateAsync(DateFormattedNumberTemplate template);

        Task<bool> InsertInstanceAsync(DateFormattedNumberInstance instance);
    }
}

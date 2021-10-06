using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP.Infrastructure.Common
{
    public static class Guard
    {
        /// <summary>
        /// result is IEnumerable
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static async Task<WebApiResult<TModel>> TryCatch<TModel>(Func<Task<IEnumerable<TModel>>> func) where TModel : class
        {
            try
            {
                var result = await func.Invoke();

                return await Task.FromResult(WebApiResult<TModel>.Success(result.ToArray()));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(WebApiResult<TModel>.Failed(ex.Message));
            }
        }

        /// <summary>
        /// result is string (default string.Empty)
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public static async Task<WebApiResult<string>> TryCatch(Func<Task> func)
        {
            try
            {
                await func.Invoke();

                return await Task.FromResult(WebApiResult<string>.Success());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(WebApiResult<string>.Failed(ex.Message));
            }
        }
    }
}

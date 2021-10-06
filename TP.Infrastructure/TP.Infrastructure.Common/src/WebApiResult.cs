using System.Collections.Generic;

namespace TP.Infrastructure.Common
{
    public class WebApiResult<TModel> where TModel : class
    {
        private static readonly WebApiResult<TModel> success = new WebApiResult<TModel>(true);

        public WebApiResult() { }
        //public WebApiResult() : this(string.Empty) { }

        public WebApiResult(params string[] errors) : this((IEnumerable<string>)errors) { }

        public WebApiResult(params TModel[] models) : this((IEnumerable<TModel>)models) { }

        public WebApiResult(IEnumerable<string> errors)
        {
            if(errors == null)
            {
                errors = new string[]
                {
                    "An unknown failure has occured."
                };
            }
            this.Succeeded = false;
            this.Errors = errors;
        }

        public WebApiResult(IEnumerable<TModel> models)
        {
            if (models != null)
            {
                this.Results = models;
            }
            this.Succeeded = true;
        }

        protected WebApiResult(bool success)
        {
            this.Succeeded = success;
            this.Errors = new string[0];
        }

        public bool Succeeded { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public IEnumerable<TModel> Results { get; set; }

        public static WebApiResult<TModel> Success(params TModel[] models)
        {
            return new WebApiResult<TModel>(models);
        }

        //public static WebApiResult<TModel> Success
        //{
        //    get { return WebApiResult<TModel>.success; }
        //}

        public static WebApiResult<TModel> Failed(params string[] errors)
        {
            return new WebApiResult<TModel>(errors);
        }
    }
}

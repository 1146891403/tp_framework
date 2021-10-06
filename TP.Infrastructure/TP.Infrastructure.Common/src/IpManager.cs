using System.Web;

namespace TP.Infrastructure.Common
{
    public class IpManager
    {
        public static string GetClientIp()
        {
            if ((HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == null) || (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].IndexOf("unknown") > 0))
            {
                return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].IndexOf(",") > 0)
            {
                return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Substring(1, HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].IndexOf(",") - 1);
            }
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].IndexOf(";") > 0)
            {
                return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Substring(1, HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].IndexOf(";") - 1);
            }
            return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        }
    }
}

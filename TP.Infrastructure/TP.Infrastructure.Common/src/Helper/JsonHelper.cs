using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TP.Infrastructure.Common.Helper
{
    public class JsonHelper
    {
        public static string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static object DeserializeObject(string value)
        {
            var jsonSetting = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            return JsonConvert.DeserializeObject(value, jsonSetting);
        }

        public static T DeserializeObject<T>(string value)
        {
            var jsonSetting = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            return JsonConvert.DeserializeObject<T>(value, jsonSetting);
        }

        public static JObject ToJObject(string json)
        {
            return JObject.Parse(json);
        }

        public static string GetJsonValue(string json, string key)
        {
            return ToJObject(json)[key].Value<string>();
        }
    }
}

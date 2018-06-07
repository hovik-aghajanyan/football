using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Football.Common
{
    public class Rest
    {
        public static string BaseUrl = "https://api.football-data.org/v1/competitions";
        public static string Token = null;

        public static async Task<T> Get<T>(string url) where T : class, new()
        {
            T result = null;
            using (var client = new HttpClient())
            {
                if(!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("X-Auth-Token", Token);
                }
                var res = await client.GetAsync(url);
                var resJson = await res.Content.ReadAsStringAsync();
                //var headers = res.Headers;
                result = JsonConvert.DeserializeObject<T>(resJson, Converter.Settings);
            }
            return result;
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

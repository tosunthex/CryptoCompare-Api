using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Services
{
    public class QueryStringService : BaseApiUrls
    {
        public static Uri AppendQueryString(string path, Dictionary<string, string> parameter)
        {
            return CreateUrl(path, parameter, true);
        }
        public static Uri AppendQueryString(string path, Dictionary<string, string> parameter, bool useMinApi)
        {
            return CreateUrl(path, parameter, useMinApi);
        }
        private static Uri CreateUrl(string path, Dictionary<string, string> parameter, bool useMinApi)
        {
            var urlParameters = new List<string>();
            if (!string.IsNullOrEmpty(BaseApiUrls.ApiKey))
            {
                parameter.Add("api_key",BaseApiUrls.ApiKey);
            }
            foreach (var par in parameter)
            {
                urlParameters.Add(string.IsNullOrWhiteSpace(par.Value) ? null : $"{par.Key}={par.Value}");
            }

            var encodedParams = urlParameters
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(WebUtility.HtmlEncode)
                .Select((x, i) => i > 0 ? $"&{x}" : $"?{x}")
                .ToArray();

            var url = encodedParams.Length > 0 ? $"{path}{string.Join(string.Empty, encodedParams)}" : path;
            
            return useMinApi ? new Uri(BaseMinApiEndPoint, url) : new Uri(SiteApiEndpoint, url);
        }
    }
}
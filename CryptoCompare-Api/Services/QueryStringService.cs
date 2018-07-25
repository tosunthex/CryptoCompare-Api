using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Services
{
    public class QueryStringService : BaseApiUrls
    {
        public static Uri AppendQueryString(string path, Dictionary<string, string> parameter, bool useMinApi = true)
        {
            var urlParameters = new List<string>();
            foreach (var par in parameter)
                urlParameters.Add(string.IsNullOrWhiteSpace(par.Value) ? null : $"{par.Key}={par.Value}");

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
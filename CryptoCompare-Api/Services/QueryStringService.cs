using System;
using System.Collections.Generic;
using System.Linq;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Services
{
    public class QueryStringService:BaseApiUrls
    {
        public static Uri AppendQueryString(string path,Dictionary<string,string> parameter)
        {
            var _urlParameters = new List<string>();
            foreach (var par in parameter)
            {
                _urlParameters.Add(string.IsNullOrWhiteSpace(par.Value) ? null : $"{par.Key}={par.Value}");    
            }
            
            var encodedParams = _urlParameters
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(System.Net.WebUtility.HtmlEncode)
                .Select((x, i) => i > 0 ? $"&{x}" : $"?{x}")
                .ToArray();

            var url = encodedParams.Length > 0 ? $"{path}{string.Join(string.Empty, encodedParams)}" : path;
            return new Uri(BaseMinApiEndPoint, url);
            }
    }
}
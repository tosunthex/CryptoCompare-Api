using System;
using System.Collections.Generic;
using System.Linq;
using CryptoCompare_Api.Parameters;

namespace CryptoCompare_Api.Services
{
    public class QueryStringService:BaseApiUrls
    {
        private static string _path;
        private static List<string> _urlParameters;

        public QueryStringService(string path)
        {
            _urlParameters = new List<string>();
            _path = path;
        }
        public Uri AppendQueryString(Dictionary<string,string> parameter)
        {
            foreach (var par in parameter)
            {
                _urlParameters.Add(string.IsNullOrWhiteSpace(par.Value) ? null : $"{par.Key}={par.Value}");    
            }
            
            var encodedParams = _urlParameters
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(System.Net.WebUtility.HtmlEncode)
                .Select((x, i) => i > 0 ? $"&{x}" : $"?{x}")
                .ToArray();

            var url = encodedParams.Length > 0 ? $"{_path}{string.Join(string.Empty, encodedParams)}" : _path;
            return new Uri(BaseMinApiEndPoint, url);
        }
    }
}
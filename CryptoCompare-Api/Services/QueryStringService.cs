﻿using System.Linq;

namespace CryptoCompare_Api.Services
{
    public class QueryStringService
    {
        public static string AppendQueryString(string segment, params string[] parameters)
        {
            var encodedParams = parameters
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(System.Net.WebUtility.HtmlEncode)
                .Select((x, i) => i > 0 ? $"&{x}" : $"?{x}")
                .ToArray();

            return encodedParams.Length > 0 ? $"{segment}{string.Join(string.Empty, encodedParams)}" : segment;
        }

        public static string CreateUriParameter(string urlKey,string[] urlValue)
        {   
            return urlValue.GetValue(0) == null ? null : $"{urlKey}={string.Join(",", urlValue)}";
        }
    }
}
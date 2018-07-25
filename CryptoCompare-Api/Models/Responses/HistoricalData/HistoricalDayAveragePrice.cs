using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public class HistoricalDayAveragePrice : Dictionary<string, object>
    {
        [JsonProperty("ConversionType")] public ConversionType ConversionType { get; set; }
    }
}
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CryptoCompare_Api.Models.Responses.HistoricalData
{
    public class HistoricalDayAveragePrice:Dictionary<string,object>
    {
        [JsonProperty("ConversionType")]
        public ConversionType ConversionType { get; set; }
    }
}
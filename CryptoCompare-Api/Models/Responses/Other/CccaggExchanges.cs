using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Other
{
    public class CccaggExchanges:ReadOnlyDictionary<string,MarketDetail>
    {
        public CccaggExchanges(IDictionary<string,MarketDetail> dictionary):base(dictionary)
        {
        }
    }
    public class MarketDetail
    {
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("excludePricing")]
        public Exclude ExcludePricing { get; set; }

        [JsonProperty("excludeVolume")]
        public Exclude ExcludeVolume { get; set; }
    }

    public class Exclude
    {
        [JsonProperty("all")]
        public bool All { get; set; }

        [JsonProperty("tosymbol")]
        public bool Tosymbol { get; set; }

        [JsonProperty("tosymbols")]
        public object[] Tosymbols { get; set; }

        [JsonProperty("pair")]
        public bool Pair { get; set; }

        [JsonProperty("pairs")]
        public object[] Pairs { get; set; }
    }
}
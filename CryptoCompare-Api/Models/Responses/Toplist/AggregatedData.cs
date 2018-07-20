using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public partial class AggregatedData
    {
        [JsonProperty("TYPE")]
        public string Type { get; set; }

        [JsonProperty("MARKET")]
        public string Market { get; set; }

        [JsonProperty("FROMSYMBOL")]
        public string Fromsymbol { get; set; }

        [JsonProperty("TOSYMBOL")]
        public string Tosymbol { get; set; }

        [JsonProperty("FLAGS")]
        public string Flags { get; set; }

        [JsonProperty("PRICE")]
        public double Price { get; set; }

        [JsonProperty("LASTUPDATE")]
        public long Lastupdate { get; set; }

        [JsonProperty("LASTVOLUME")]
        public double Lastvolume { get; set; }

        [JsonProperty("LASTVOLUMETO")]
        public double Lastvolumeto { get; set; }

        [JsonProperty("LASTTRADEID")]
        public string Lasttradeid { get; set; }

        [JsonProperty("VOLUMEDAY", NullValueHandling = NullValueHandling.Ignore)]
        public double? Volumeday { get; set; }

        [JsonProperty("VOLUMEDAYTO", NullValueHandling = NullValueHandling.Ignore)]
        public double? Volumedayto { get; set; }

        [JsonProperty("VOLUME24HOUR")]
        public double Volume24Hour { get; set; }

        [JsonProperty("VOLUME24HOURTO")]
        public double Volume24Hourto { get; set; }

        [JsonProperty("OPENDAY", NullValueHandling = NullValueHandling.Ignore)]
        public double? Openday { get; set; }

        [JsonProperty("HIGHDAY", NullValueHandling = NullValueHandling.Ignore)]
        public double? Highday { get; set; }

        [JsonProperty("LOWDAY", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lowday { get; set; }

        [JsonProperty("OPEN24HOUR")]
        public double Open24Hour { get; set; }

        [JsonProperty("HIGH24HOUR")]
        public double High24Hour { get; set; }

        [JsonProperty("LOW24HOUR")]
        public double Low24Hour { get; set; }

        [JsonProperty("LASTMARKET", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastmarket { get; set; }

        [JsonProperty("CHANGE24HOUR")]
        public double Change24Hour { get; set; }

        [JsonProperty("CHANGEPCT24HOUR")]
        public double Changepct24Hour { get; set; }

        [JsonProperty("CHANGEDAY")]
        public double Changeday { get; set; }

        [JsonProperty("CHANGEPCTDAY")]
        public double Changepctday { get; set; }

        [JsonProperty("SUPPLY", NullValueHandling = NullValueHandling.Ignore)]
        public long? Supply { get; set; }

        [JsonProperty("MKTCAP", NullValueHandling = NullValueHandling.Ignore)]
        public double? Mktcap { get; set; }

        [JsonProperty("TOTALVOLUME24H", NullValueHandling = NullValueHandling.Ignore)]
        public double? Totalvolume24H { get; set; }

        [JsonProperty("TOTALVOLUME24HTO", NullValueHandling = NullValueHandling.Ignore)]
        public double? Totalvolume24Hto { get; set; }
    }
}
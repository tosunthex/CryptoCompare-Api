using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class DisplayCryptoData    
    {
        [JsonProperty("MARKET")]
        public string Market { get; set; }
        [JsonProperty("FROMSYMBOL")]
        public string Fromsymbol { get; set; }
        [JsonProperty("TOSYMBOL")]
        public string Tosymbol { get; set; }
        [JsonProperty("PRICE")]
        public string Price { get; set; }
        [JsonProperty("LASTUPDATE")]
        public string Lastupdate { get; set; }
        [JsonProperty("LASTVOLUME")]
        public string Lastvolume { get; set; }
        [JsonProperty("LASTVOLUMETO")]
        public string Lastvolumeto { get; set; }
        [JsonProperty("LASTTRADEID")]
        public string Lasttradeid { get; set; }
        [JsonProperty("VOLUMEDAY")]
        public string Volumeday { get; set; }
        [JsonProperty("VOLUMEDAYTO")]
        public string Volumedayto { get; set; }
        [JsonProperty("VOLUME24HOUR")]
        public string Volume24Hour { get; set; }
        [JsonProperty("VOLUME24HOURTO")]
        public string Volume24Hourto { get; set; }
        [JsonProperty("OPENDAY")]
        public string Openday { get; set; }
        [JsonProperty("HIGHDAY")]
        public string Highday { get; set; }
        [JsonProperty("LOWDAY")]
        public string Lowday { get; set; }
        [JsonProperty("OPEN24HOUR")]
        public string Open24Hour { get; set; }
        [JsonProperty("HIGH24HOUR")]
        public string High24Hour { get; set; }
        [JsonProperty("LOW24HOUR")]
        public string Low24Hour { get; set; }
        [JsonProperty("LASTMARKET")]
        public string Lastmarket { get; set; }
        [JsonProperty("CHANGE24HOUR")]
        public string Change24Hour { get; set; }
        [JsonProperty("CHANGEPCT24HOUR")]
        public string Changepct24Hour { get; set; }
        [JsonProperty("CHANGEDAY")]
        public string Changeday { get; set; }
        [JsonProperty("CHANGEPCTDAY")]
        public string Changepctday { get; set; }
        [JsonProperty("SUPPLY")]
        public string Supply { get; set; }
        [JsonProperty("MKTCAP")]
        public string Mktcap { get; set; }
        [JsonProperty("TOTALVOLUME24H")]
        public string Totalvolume24H { get; set; }
        [JsonProperty("TOTALVOLUME24HTO")]
        public string Totalvolume24Hto { get; set; }
    }
}
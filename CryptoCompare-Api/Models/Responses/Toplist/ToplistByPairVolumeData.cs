using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class ToplistByPairVolumeData
    {
        [JsonProperty("SYMBOL")]
        public string Symbol { get; set; }

        [JsonProperty("SUPPLY")]
        public double Supply { get; set; }

        [JsonProperty("FULLNAME")]
        public string Fullname { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("VOLUME24HOURTO")]
        public double Volume24Hourto { get; set; }
    }
}
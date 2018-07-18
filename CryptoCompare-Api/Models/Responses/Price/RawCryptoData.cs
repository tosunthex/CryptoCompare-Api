using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class RawCryptoData:DisplayCryptoData
    {
        [JsonProperty("TYPE")]
        public string Type { get; set; }
        [JsonProperty("FLAGS")]
        public string Flags { get; set; }
    }
}
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Price
{
    public class GenerateCustomAverage
    {
        [JsonProperty("RAW")] public RawCryptoData Raw { get; set; }

        [JsonProperty("Display")] public DisplayCryptoData Display { get; set; }
    }
}
using CryptoCompare_Api.Models.Responses.Streaming;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Toplist
{
    public class ToplistByTotalVolumeData
    {
        [JsonProperty("CoinInfo")] public CoinInfo CoinInfo { get; set; }

        [JsonProperty("ConversionInfo")] public ConversionInfo ConversionInfo { get; set; }
    }
}
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Streaming
{
    public partial class CoinGeneralInfoData
    {
        [JsonProperty("CoinInfo")]
        public CoinInfo CoinInfo { get; set; }

        [JsonProperty("ConversionInfo")]
        public ConversionInfo ConversionInfo { get; set; }
    }
}
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Streaming
{
    public class SubsWatchlistCrypto
    {
        [JsonProperty("Conversion")] public string Conversion { get; set; }

        [JsonProperty("ConversionSymbol")] public string ConversionSymbol { get; set; }

        [JsonProperty("CurrencyFrom")] public string CurrencyFrom { get; set; }

        [JsonProperty("CurrencyTo")] public string CurrencyTo { get; set; }

        [JsonProperty("Market")] public string Market { get; set; }

        [JsonProperty("Supply")] public double Supply { get; set; }

        [JsonProperty("TotalVolume24H")] public double TotalVolume24H { get; set; }

        [JsonProperty("SubBase")] public string SubBase { get; set; }

        [JsonProperty("SubsNeeded")] public string[] SubsNeeded { get; set; }

        [JsonProperty("RAW")] public string[] Raw { get; set; }
    }
}
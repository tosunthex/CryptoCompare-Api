using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses
{
    public class ErrorResponse
    {
        [JsonProperty("Response")] public string Response { get; set; }

        [JsonProperty("Message")] public string Message { get; set; }

        [JsonProperty("Type")] public int Type { get; set; }

        [JsonProperty("Aggregated")] public bool Aggregated { get; set; }

        [JsonProperty("Path")] public string Path { get; set; }

        [JsonProperty("ErrorSummary")] public string ErrorSummary { get; set; }
    }
}
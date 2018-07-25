using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Streaming
{
    public class CoinInfo
    {
        [JsonProperty("Id")] public string Id { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("FullName")] public string FullName { get; set; }

        [JsonProperty("Internal")] public string Internal { get; set; }

        [JsonProperty("ImageUrl")] public string ImageUrl { get; set; }

        [JsonProperty("Url")] public string Url { get; set; }

        [JsonProperty("Algorithm")] public string Algorithm { get; set; }

        [JsonProperty("ProofType")] public string ProofType { get; set; }

        [JsonProperty("NetHashesPerSecond")] public double NetHashesPerSecond { get; set; }

        [JsonProperty("BlockNumber")] public long BlockNumber { get; set; }

        [JsonProperty("BlockTime")] public long BlockTime { get; set; }

        [JsonProperty("BlockReward")] public double BlockReward { get; set; }

        [JsonProperty("Type")] public long Type { get; set; }

        [JsonProperty("DocumentType")] public string DocumentType { get; set; }
    }
}
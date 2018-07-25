using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Other
{
    public class Miningequipment
    {
        [JsonProperty("Response")] public string Response { get; set; }

        [JsonProperty("Message")] public string Message { get; set; }

        [JsonProperty("MiningData")] public Dictionary<string, MiningEquipmentData> MiningData { get; set; }

        [JsonProperty("Type")] public long Type { get; set; }

        [JsonProperty("SymbolsNeeded")] public string[] SymbolsNeeded { get; set; }
    }
}
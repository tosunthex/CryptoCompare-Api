using Newtonsoft.Json;

namespace CryptoCompare_Api.Models.Responses.Other
{
    public class MiningEquipmentData
    {
        [JsonProperty("Id")] public long Id { get; set; }

        [JsonProperty("ParentId")] public long ParentId { get; set; }

        [JsonProperty("Company")] public string Company { get; set; }

        [JsonProperty("Url")] public string Url { get; set; }

        [JsonProperty("LogoUrl")] public string LogoUrl { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("Recommended")] public bool Recommended { get; set; }

        [JsonProperty("Sponsored")] public bool Sponsored { get; set; }

        [JsonProperty("AffiliateURL")] public string AffiliateUrl { get; set; }

        [JsonProperty("Algorithm")] public string Algorithm { get; set; }

        [JsonProperty("HashesPerSecond")] public string HashesPerSecond { get; set; }

        [JsonProperty("Cost")] public string Cost { get; set; }

        [JsonProperty("Currency")] public string Currency { get; set; }

        [JsonProperty("EquipmentType")] public string EquipmentType { get; set; }

        [JsonProperty("PowerConsumption")] public string PowerConsumption { get; set; }

        [JsonProperty("CurrenciesAvailable")] public string CurrenciesAvailable { get; set; }

        [JsonProperty("CurrenciesAvailableLogo")]
        public string CurrenciesAvailableLogo { get; set; }

        [JsonProperty("CurrenciesAvailableName")]
        public string CurrenciesAvailableName { get; set; }
    }
}
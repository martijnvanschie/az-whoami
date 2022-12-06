using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class SubscriptionPolicies
    {
        [JsonPropertyName("locationPlacementId")]
        public string LocationPlacementId { get; set; }

        [JsonPropertyName("quotaId")]
        public string QuotaId { get; set; }

        [JsonPropertyName("spendingLimit")]
        public string SpendingLimit { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class Tenant
    {
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("defaultDomain")]
        public string DefaultDomain { get; set; }

        [JsonPropertyName("displayName")]
        public string Name { get; set; }
    }
}
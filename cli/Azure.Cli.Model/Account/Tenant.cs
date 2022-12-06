using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class Tenant
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class Tenant
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class Account
    {
        [JsonPropertyName("environmentName")]
        public string EnvironmentName { get; set; }

        [JsonPropertyName("homeTenantId")]
        public string HomeTenantId { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("isDefault")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("managedByTenants")]
        public List<Tenant> ManagedByTenants { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}
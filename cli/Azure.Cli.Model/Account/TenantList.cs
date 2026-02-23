using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class TenantList
    {
        [JsonPropertyName("value")]
        public List<Tenant> Tenants { get; set; }
    }
}

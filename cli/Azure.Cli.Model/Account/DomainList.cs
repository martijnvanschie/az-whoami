using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class DomainList
    {
        [JsonPropertyName("@odata.context")]
        public string OdataContext { get; set; }

        [JsonPropertyName("value")]
        public List<Domain> Domains { get; set; }
    }
}

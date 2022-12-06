using System.Text.Json.Serialization;

namespace Azure.Cli.Model.Account
{
    public class User
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
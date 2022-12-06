using System.Text.Json.Serialization;

namespace Azure.Cli.Model.ActiveDirectory
{
    public class VerifiedPublisher
    {
        [JsonPropertyName("addedDateTime")]
        public object AddedDateTime { get; set; }

        [JsonPropertyName("displayName")]
        public object DisplayName { get; set; }

        [JsonPropertyName("verifiedPublisherId")]
        public object VerifiedPublisherId { get; set; }
    }
}

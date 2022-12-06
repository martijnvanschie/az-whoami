using System.Text.Json.Serialization;

namespace Azure.Cli.Model.ActiveDirectory
{
    public class Info
    {
        [JsonPropertyName("logoUrl")]
        public object LogoUrl { get; set; }

        [JsonPropertyName("marketingUrl")]
        public object MarketingUrl { get; set; }

        [JsonPropertyName("privacyStatementUrl")]
        public object PrivacyStatementUrl { get; set; }

        [JsonPropertyName("supportUrl")]
        public object SupportUrl { get; set; }

        [JsonPropertyName("termsOfServiceUrl")]
        public object TermsOfServiceUrl { get; set; }
    }
}

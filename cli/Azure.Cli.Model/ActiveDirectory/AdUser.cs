using System.Text.Json.Serialization;

namespace Azure.Cli.Model.ActiveDirectory
{
    public class AdUser
    {
        [JsonPropertyName("@odata.context")]
        public string OdataContext { get; set; }

        [JsonPropertyName("businessPhones")]
        public List<object> BusinessPhones { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("jobTitle")]
        public object JobTitle { get; set; }

        [JsonPropertyName("mail")]
        public string Mail { get; set; }

        [JsonPropertyName("mobilePhone")]
        public object MobilePhone { get; set; }

        [JsonPropertyName("officeLocation")]
        public object OfficeLocation { get; set; }

        [JsonPropertyName("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }
}
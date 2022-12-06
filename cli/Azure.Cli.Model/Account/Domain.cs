using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Azure.Cli.Model.Account
{
    public class Domain
    {
        [JsonPropertyName("authenticationType")]
        public string AuthenticationType { get; set; }

        [JsonPropertyName("availabilityStatus")]
        public object AvailabilityStatus { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("isAdminManaged")]
        public bool IsAdminManaged { get; set; }

        [JsonPropertyName("isDefault")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("isInitial")]
        public bool IsInitial { get; set; }

        [JsonPropertyName("isRoot")]
        public bool IsRoot { get; set; }

        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("passwordNotificationWindowInDays")]
        public int? PasswordNotificationWindowInDays { get; set; }

        [JsonPropertyName("passwordValidityPeriodInDays")]
        public int? PasswordValidityPeriodInDays { get; set; }

        [JsonPropertyName("state")]
        public object State { get; set; }

        [JsonPropertyName("supportedServices")]
        public List<string> SupportedServices { get; set; }
    }
}

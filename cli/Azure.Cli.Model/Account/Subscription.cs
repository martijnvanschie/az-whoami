using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Azure.Cli.Model.Account
{
    public class Subscription
    {
        [JsonPropertyName("authorizationSource")]
        public string AuthorizationSource { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonPropertyName("subscriptionPolicies")]
        public SubscriptionPolicies SubscriptionPolicies { get; set; }
    }
}

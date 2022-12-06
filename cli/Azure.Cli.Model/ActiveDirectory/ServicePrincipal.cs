using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Azure.Cli.Model.ActiveDirectory
{
    public class ServicePrincipal
    {
        [JsonPropertyName("@odata.context")]
        public string OdataContext { get; set; }

        [JsonPropertyName("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonPropertyName("addIns")]
        public List<object> AddIns { get; set; }

        [JsonPropertyName("alternativeNames")]
        public List<object> AlternativeNames { get; set; }

        [JsonPropertyName("appDescription")]
        public object AppDescription { get; set; }

        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }

        [JsonPropertyName("appId")]
        public string AppId { get; set; }

        [JsonPropertyName("appOwnerOrganizationId")]
        public string AppOwnerOrganizationId { get; set; }

        [JsonPropertyName("appRoleAssignmentRequired")]
        public bool AppRoleAssignmentRequired { get; set; }

        [JsonPropertyName("appRoles")]
        public List<object> AppRoles { get; set; }

        [JsonPropertyName("applicationTemplateId")]
        public object ApplicationTemplateId { get; set; }

        [JsonPropertyName("createdDateTime")]
        public DateTime CreatedDateTime { get; set; }

        [JsonPropertyName("deletedDateTime")]
        public object DeletedDateTime { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("disabledByMicrosoftStatus")]
        public object DisabledByMicrosoftStatus { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("homepage")]
        public object Homepage { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("info")]
        public Info Info { get; set; }

        [JsonPropertyName("keyCredentials")]
        public List<object> KeyCredentials { get; set; }

        [JsonPropertyName("loginUrl")]
        public object LoginUrl { get; set; }

        [JsonPropertyName("logoutUrl")]
        public object LogoutUrl { get; set; }

        [JsonPropertyName("notes")]
        public object Notes { get; set; }

        [JsonPropertyName("notificationEmailAddresses")]
        public List<object> NotificationEmailAddresses { get; set; }

        [JsonPropertyName("oauth2PermissionScopes")]
        public List<object> Oauth2PermissionScopes { get; set; }

        [JsonPropertyName("passwordCredentials")]
        public List<object> PasswordCredentials { get; set; }

        [JsonPropertyName("preferredSingleSignOnMode")]
        public object PreferredSingleSignOnMode { get; set; }

        [JsonPropertyName("preferredTokenSigningKeyThumbprint")]
        public object PreferredTokenSigningKeyThumbprint { get; set; }

        [JsonPropertyName("replyUrls")]
        public List<object> ReplyUrls { get; set; }

        [JsonPropertyName("resourceSpecificApplicationPermissions")]
        public List<object> ResourceSpecificApplicationPermissions { get; set; }

        [JsonPropertyName("samlSingleSignOnSettings")]
        public object SamlSingleSignOnSettings { get; set; }

        [JsonPropertyName("servicePrincipalNames")]
        public List<string> ServicePrincipalNames { get; set; }

        [JsonPropertyName("servicePrincipalType")]
        public string ServicePrincipalType { get; set; }

        [JsonPropertyName("signInAudience")]
        public string SignInAudience { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("tokenEncryptionKeyId")]
        public object TokenEncryptionKeyId { get; set; }

        [JsonPropertyName("verifiedPublisher")]
        public VerifiedPublisher VerifiedPublisher { get; set; }
    }
}

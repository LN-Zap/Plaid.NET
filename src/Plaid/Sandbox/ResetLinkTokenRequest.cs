using Newtonsoft.Json;
using System.Collections.Generic;

namespace Acklann.Plaid.Sandbox
{
    /// <summary>
    /// Represents a request for plaid's '/sandbox/item/reset_login' endpoint. Reset a link_token.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class ResetLinkTokenRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the access_token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}

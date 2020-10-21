using Newtonsoft.Json;

namespace Acklann.Plaid.Sandbox
{
    /// <summary>
    /// Represents a response from plaid's '/sandbox/item/reset_login' endpoint. Reset a link_token.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class ResetLinkTokenResponse : ResponseBase
    {
        /// <summary>
        /// True if the call succeeded
        /// </summary>
        /// <value>The link token.</value>
        [JsonProperty("reset_login")]
        public bool ResetLogin { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Acklann.Plaid.Sandbox
{
	/// <summary>
	/// Represents a request for plaid's '/server/sandbox_force_auto_deposit' endpoint. Forces an Auto Deposit.
	/// </summary>
	/// <seealso cref="Acklann.Plaid.SerializableContent" />
	public class SetVerificationStateRequest : SerializableContent
	{
		/// <summary>
		/// Gets or sets the client identifier.
		/// </summary>
		/// <value>The client identifier.</value>
		[JsonProperty("client_id")]
		public string ClientId { get; set; }

		/// <summary>
		/// Gets or sets the secret.
		/// </summary>
		/// <value>The secret.</value>
		[JsonProperty("secret")]
		public string Secret { get; set; }

		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		/// <value>The access token.</value>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		/// <summary>
		/// Gets or sets the account id.
		/// </summary>
		/// <value>The secret.</value>
		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		/// <summary>
		/// Gets or sets the verification status.
		/// </summary>
		/// <value>The verification status.</value>
		[JsonProperty("verification_status")]
		public string VerificationStatus { get; set; }
	}
}

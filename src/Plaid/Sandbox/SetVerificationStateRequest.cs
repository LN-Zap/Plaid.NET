using Newtonsoft.Json;
using System.Collections.Generic;

namespace Acklann.Plaid.Sandbox
{
	/// <summary>
	/// Represents a request for plaid's '/server/sandbox_force_auto_deposit' endpoint. Forces an Auto Deposit.
	/// </summary>
	/// <seealso cref="Acklann.Plaid.SerializableContent" />
	public class SetVerificationStateRequest : BaseRequest
	{
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

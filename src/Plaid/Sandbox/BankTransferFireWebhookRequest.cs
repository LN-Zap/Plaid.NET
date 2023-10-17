using Newtonsoft.Json;
using System.Collections.Generic;

namespace Acklann.Plaid.Sandbox
{
	/// <summary>
	/// Represents a request for plaid's '/sandbox/bank_transfer/fire_webhook' endpoint. Fire bank transfer webhook.
	/// </summary>
	/// <seealso cref="Acklann.Plaid.SerializableContent" />
	public class BankTransferFireWebhookRequest : BaseRequest
	{
		/// <summary>
		/// Gets or sets the webhook url.
		/// </summary>
		/// <value>The webhook url.</value>
		[JsonProperty("webhook")]
		public string Webhook { get; set; }
	}
}

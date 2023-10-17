using Newtonsoft.Json;
using System.Collections.Generic;

namespace Acklann.Plaid.Sandbox
{
	/// <summary>
	/// Represents a request for plaid's '/sandbox/bank_transfer/simulate' endpoint. Simulate a bank transfer.
	/// </summary>
	/// <seealso cref="Acklann.Plaid.SerializableContent" />
	public class SimulateBankTransferRequest : BaseRequest
	{
		/// <summary>
		/// Gets or sets the bank transfer id.
		/// </summary>
		/// <value>The bank transfer id.</value>
		[JsonProperty("bank_transfer_id")]
		public string BankTransferId { get; set; }

		/// <summary>
		/// Gets or sets the event type.
		/// </summary>
		/// <value>The event type.</value>
		[JsonProperty("event_type")]
		public string EventType { get; set; }
	}
}

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Acklann.Plaid.BankTransfer
{
	public class BankTransferEventListResponse : ResponseBase
	{
		[JsonProperty("bank_transfer_events")]
		public BankTransferEvent[] BankTransferEvents { get; set; }
	}
}

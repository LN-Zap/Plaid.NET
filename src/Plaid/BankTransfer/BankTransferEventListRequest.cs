using Newtonsoft.Json;
using Acklann.Plaid.Sandbox;

namespace Acklann.Plaid.BankTransfer
{
	public class BankTransferEventListRequest : BaseRequest
	{
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		[JsonProperty("bank_transfer_id")]
		public string BankTransferId { get; set; }

		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		[JsonProperty("bank_transfer_type")]
		public string BankTransferType { get; set; }

		[JsonProperty("event_types")]
		public string EventTypes { get; set; }

		[JsonProperty("count")]
		public string Count { get; set; }

		[JsonProperty("offset")]
		public string Offset { get; set; }

		[JsonProperty("origination_account_id")]
		public string OriginationAccountId { get; set; }

		[JsonProperty("direction")]
		public string Direction { get; set; }
	}
}

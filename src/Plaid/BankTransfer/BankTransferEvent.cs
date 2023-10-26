using Newtonsoft.Json;

namespace Acklann.Plaid.BankTransfer
{
	public class BankTransferEvent
	{
		[JsonProperty("ach_return_code")]
		public string AchReturnCode { get; set; }

		[JsonProperty("event_id")]
		public string EventId { get; set; }

		[JsonProperty("timestamp")]
		public string Timestamp { get; set; }

		[JsonProperty("event_type")]
		public string EventType { get; set; }

		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		[JsonProperty("bank_transfer_id")]
		public string BankTransferId { get; set; }

		[JsonProperty("origination_account_id")]
		public string OriginationAccountId { get; set; }

		[JsonProperty("bank_transfer_type")]
		public string BankTransferType { get; set; }

		[JsonProperty("bank_transfer_amount")]
		public string BankTransferAmount { get; set; }

		[JsonProperty("bank_transfer_iso_currency_code")]
		public string BankTransferIsoCurrencyCode { get; set; }

		[JsonProperty("direction")]
		public string Direction { get; set; }

		[JsonProperty("failure_reason")]
		public BankTransferEventFailureReason FailureReason { get; set; }
	}
}

using Newtonsoft.Json;

namespace Acklann.Plaid.BankTransfer
{
	public class BankTransferEventFailureReason
	{
		[JsonProperty("ach_return_code")]
		public string AchReturnCode { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}

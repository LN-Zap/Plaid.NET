﻿using Newtonsoft.Json;

namespace Acklann.Plaid.Balance
{
    /// <summary>
    /// Represents a request for plaid's '/accounts/balance/get' endpoint. The POST /accounts/balance/get endpoint returns the real-time balance for each of an Item’s accounts. It can be used for existing Items that were added via any of Plaid’s other products.
    /// </summary>
    /// <remarks>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
    /// <seealso cref="Acklann.Plaid.RequestBase" />
    public class GetBalanceRequest : RequestBase
    {
        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>The options.</value>
        [JsonProperty("options")]
        public GetBalanceOptions Options { get; set; }
    }

    /// <summary>
    /// The container object for options associated with a GetBalanceRequest.
    /// </summary>
    /// <remarks>
    /// This is outside the GetBalanceRequest class because it is required to build the request.
    /// </remarks>
    public class GetBalanceOptions
    {
        /// <summary>
        /// Gets or sets the account ids. Note: An error will be returned if a provided account_id is not associated with the <see cref="Entity.Item"/>.
        /// </summary>
        /// <value>The account ids.</value>
        [JsonProperty("account_ids")]
        public string[] AccountIds { get; set; }
    }
}

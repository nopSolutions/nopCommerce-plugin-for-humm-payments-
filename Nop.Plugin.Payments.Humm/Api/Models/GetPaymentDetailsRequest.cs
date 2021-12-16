﻿using Newtonsoft.Json;

namespace Nop.Plugin.Payments.Humm.Api.Models
{
    /// <summary>
    /// Represents a model to get the payment details
    /// </summary>
    public class GetPaymentDetailsRequest
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Partner Tracking Id
        /// </summary>
        /// <remarks>
        /// Required parameter
        /// </remarks>
        [JsonProperty("trackingId")]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or sets the Unique Account Id
        /// </summary>
        /// <remarks>
        /// Required parameter
        /// </remarks>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        #endregion
    }
}

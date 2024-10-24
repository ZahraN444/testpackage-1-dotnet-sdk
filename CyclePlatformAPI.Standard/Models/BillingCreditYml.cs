// <copyright file="BillingCreditYml.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// BillingCreditYml.
    /// </summary>
    public class BillingCreditYml
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCreditYml"/> class.
        /// </summary>
        public BillingCreditYml()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCreditYml"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="description">description.</param>
        /// <param name="accountId">account_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="amountRemaining">amount_remaining.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="expires">expires.</param>
        public BillingCreditYml(
            string id,
            string hubId,
            string description,
            string accountId,
            int amount,
            int amountRemaining,
            Models.BillingCreditEvents events,
            Models.State5 state,
            Models.Expires expires = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Description = description;
            this.AccountId = accountId;
            this.Amount = amount;
            this.AmountRemaining = amountRemaining;
            this.Expires = expires;
            this.Events = events;
            this.State = state;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// Some extra information about the billing credit.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The account the credit was issued to.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The amount of credit.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The amount of the credit that remains after being applied to invoices.
        /// </summary>
        [JsonProperty("amount_remaining")]
        public int AmountRemaining { get; set; }

        /// <summary>
        /// Information on when the billing credit expires.
        /// </summary>
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Include)]
        public Models.Expires Expires { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the billing order's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.BillingCreditEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.State5 State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingCreditYml : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is BillingCreditYml other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                this.Amount.Equals(other.Amount) &&
                this.AmountRemaining.Equals(other.AmountRemaining) &&
                ((this.Expires == null && other.Expires == null) || (this.Expires?.Equals(other.Expires) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.AmountRemaining = {this.AmountRemaining}");
            toStringOutput.Add($"this.Expires = {(this.Expires == null ? "null" : this.Expires.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}
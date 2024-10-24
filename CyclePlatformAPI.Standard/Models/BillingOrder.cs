// <copyright file="BillingOrder.cs" company="APIMatic">
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
    /// BillingOrder.
    /// </summary>
    public class BillingOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOrder"/> class.
        /// </summary>
        public BillingOrder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOrder"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="term">term.</param>
        /// <param name="approved">approved.</param>
        /// <param name="items">items.</param>
        /// <param name="totalPrice">total_price.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="promoCodeId">promo_code_id.</param>
        public BillingOrder(
            string id,
            string hubId,
            Models.CreatorScope creator,
            Models.BillingTerm term,
            bool approved,
            List<Models.ItemPlan> items,
            int totalPrice,
            Models.BillingOrderEvents events,
            Models.State3 state,
            string promoCodeId = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Creator = creator;
            this.PromoCodeId = promoCodeId;
            this.Term = term;
            this.Approved = approved;
            this.Items = items;
            this.TotalPrice = totalPrice;
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
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// An ID associated with a promo code used with the order.
        /// </summary>
        [JsonProperty("promo_code_id", NullValueHandling = NullValueHandling.Include)]
        public string PromoCodeId { get; set; }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term")]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// A boolean where true represents the order is approved to be paid by the user.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.ItemPlan> Items { get; set; }

        /// <summary>
        /// 1/10th of a cent.
        /// </summary>
        [JsonProperty("total_price")]
        public int TotalPrice { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the billing order's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.BillingOrderEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.State3 State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingOrder : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingOrder other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.PromoCodeId == null && other.PromoCodeId == null) || (this.PromoCodeId?.Equals(other.PromoCodeId) == true)) &&
                ((this.Term == null && other.Term == null) || (this.Term?.Equals(other.Term) == true)) &&
                this.Approved.Equals(other.Approved) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                this.TotalPrice.Equals(other.TotalPrice) &&
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
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.PromoCodeId = {(this.PromoCodeId == null ? "null" : this.PromoCodeId)}");
            toStringOutput.Add($"this.Term = {(this.Term == null ? "null" : this.Term.ToString())}");
            toStringOutput.Add($"this.Approved = {this.Approved}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.TotalPrice = {this.TotalPrice}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}
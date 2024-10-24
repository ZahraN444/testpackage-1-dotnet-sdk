// <copyright file="Order.cs" company="APIMatic">
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
    /// Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="term">term.</param>
        /// <param name="approved">approved.</param>
        /// <param name="items">items.</param>
        /// <param name="totalPrice">total_price.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="promoCodeId">promo_code_id.</param>
        public Order(
            string hubId,
            Models.UserScope creator,
            Models.BillingTerm term,
            bool approved,
            List<Models.OrderItem> items,
            double totalPrice,
            Models.OrderEvents events,
            Models.OrderState state,
            string promoCodeId = null)
        {
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
        /// Gets or sets HubId.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// A type of creator and a matching identifier.
        /// </summary>
        [JsonProperty("creator")]
        public Models.UserScope Creator { get; set; }

        /// <summary>
        /// Gets or sets PromoCodeId.
        /// </summary>
        [JsonProperty("promo_code_id", NullValueHandling = NullValueHandling.Include)]
        public string PromoCodeId { get; set; }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term")]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// Gets or sets Approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets Items.
        /// </summary>
        [JsonProperty("items")]
        public List<Models.OrderItem> Items { get; set; }

        /// <summary>
        /// Gets or sets TotalPrice.
        /// </summary>
        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the orders lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.OrderEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.OrderState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Order : ({string.Join(", ", toStringOutput)})";
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
            return obj is Order other &&                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
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
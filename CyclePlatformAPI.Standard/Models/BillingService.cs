// <copyright file="BillingService.cs" company="APIMatic">
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
    /// BillingService.
    /// </summary>
    public class BillingService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingService"/> class.
        /// </summary>
        public BillingService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingService"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="title">title.</param>
        /// <param name="order">order.</param>
        /// <param name="item">item.</param>
        /// <param name="discount">discount.</param>
        /// <param name="price">price.</param>
        /// <param name="term">term.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        public BillingService(
            string id,
            string hubId,
            Models.CreatorScope creator,
            string title,
            Models.Order order,
            Models.ItemPlan item,
            Models.AssociatedDiscount discount,
            Models.BillingAmount price,
            Models.BillingTerm term,
            Models.BillingServiceEvents events,
            Models.BillingServiceState state)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Creator = creator;
            this.Title = title;
            this.Order = order;
            this.Item = item;
            this.Discount = discount;
            this.Price = price;
            this.Term = term;
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
        /// Billing service title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// An order is a resource that describes a billing order
        /// </summary>
        [JsonProperty("order")]
        public Models.Order Order { get; set; }

        /// <summary>
        /// Information for an item's plan.
        /// </summary>
        [JsonProperty("item")]
        public Models.ItemPlan Item { get; set; }

        /// <summary>
        /// Information about a billing discount.
        /// </summary>
        [JsonProperty("discount")]
        public Models.AssociatedDiscount Discount { get; set; }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("price")]
        public Models.BillingAmount Price { get; set; }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term")]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the billing service's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.BillingServiceEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.BillingServiceState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingService : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingService other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Order == null && other.Order == null) || (this.Order?.Equals(other.Order) == true)) &&
                ((this.Item == null && other.Item == null) || (this.Item?.Equals(other.Item) == true)) &&
                ((this.Discount == null && other.Discount == null) || (this.Discount?.Equals(other.Discount) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.Term == null && other.Term == null) || (this.Term?.Equals(other.Term) == true)) &&
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
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Order = {(this.Order == null ? "null" : this.Order.ToString())}");
            toStringOutput.Add($"this.Item = {(this.Item == null ? "null" : this.Item.ToString())}");
            toStringOutput.Add($"this.Discount = {(this.Discount == null ? "null" : this.Discount.ToString())}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.Term = {(this.Term == null ? "null" : this.Term.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}
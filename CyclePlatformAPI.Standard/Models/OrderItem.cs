// <copyright file="OrderItem.cs" company="APIMatic">
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
    /// OrderItem.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem"/> class.
        /// </summary>
        public OrderItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="service">service.</param>
        /// <param name="description">description.</param>
        /// <param name="price">price.</param>
        /// <param name="netPrice">net_price.</param>
        /// <param name="discount">discount.</param>
        public OrderItem(
            string id,
            Models.ItemPlan service,
            string description,
            Models.BillingAmount price,
            double netPrice,
            Models.Discount discount = null)
        {
            this.Id = id;
            this.Service = service;
            this.Description = description;
            this.Price = price;
            this.Discount = discount;
            this.NetPrice = netPrice;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Information for an item's plan.
        /// </summary>
        [JsonProperty("service")]
        public Models.ItemPlan Service { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("price")]
        public Models.BillingAmount Price { get; set; }

        /// <summary>
        /// Gets or sets Discount.
        /// </summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets NetPrice.
        /// </summary>
        [JsonProperty("net_price")]
        public double NetPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderItem other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.Discount == null && other.Discount == null) || (this.Discount?.Equals(other.Discount) == true)) &&
                this.NetPrice.Equals(other.NetPrice);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Service = {(this.Service == null ? "null" : this.Service.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.Discount = {(this.Discount == null ? "null" : this.Discount.ToString())}");
            toStringOutput.Add($"this.NetPrice = {this.NetPrice}");
        }
    }
}
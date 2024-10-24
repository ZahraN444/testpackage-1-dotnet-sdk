// <copyright file="BillingSummary.cs" company="APIMatic">
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
    /// BillingSummary.
    /// </summary>
    public class BillingSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSummary"/> class.
        /// </summary>
        public BillingSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSummary"/> class.
        /// </summary>
        /// <param name="serviceId">service_id.</param>
        /// <param name="title">title.</param>
        /// <param name="type">type.</param>
        /// <param name="term">term.</param>
        /// <param name="price">price.</param>
        /// <param name="discount">discount.</param>
        public BillingSummary(
            string serviceId,
            string title,
            Models.Type5Enum type,
            Models.BillingTerm term,
            string price,
            string discount)
        {
            this.ServiceId = serviceId;
            this.Title = title;
            this.Type = type;
            this.Term = term;
            this.Price = price;
            this.Discount = discount;
        }

        /// <summary>
        /// The ID of the billing service, the summary pertains to.
        /// </summary>
        [JsonProperty("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// The billing summary title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The plan type.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type5Enum Type { get; set; }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term")]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// 1/10th of a cent.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets Discount.
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingSummary other &&                ((this.ServiceId == null && other.ServiceId == null) || (this.ServiceId?.Equals(other.ServiceId) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Term == null && other.Term == null) || (this.Term?.Equals(other.Term) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.Discount == null && other.Discount == null) || (this.Discount?.Equals(other.Discount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceId = {(this.ServiceId == null ? "null" : this.ServiceId)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Term = {(this.Term == null ? "null" : this.Term.ToString())}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price)}");
            toStringOutput.Add($"this.Discount = {(this.Discount == null ? "null" : this.Discount)}");
        }
    }
}
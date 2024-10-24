// <copyright file="AssociatedDiscount.cs" company="APIMatic">
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
    /// AssociatedDiscount.
    /// </summary>
    public class AssociatedDiscount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedDiscount"/> class.
        /// </summary>
        public AssociatedDiscount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedDiscount"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="expires">expires.</param>
        public AssociatedDiscount(
            string id,
            Models.BillingAmount amount,
            DateTime expires)
        {
            this.Id = id;
            this.Amount = amount;
            this.Expires = expires;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("amount")]
        public Models.BillingAmount Amount { get; set; }

        /// <summary>
        /// A timestamp of when the discount expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociatedDiscount : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssociatedDiscount other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                this.Expires.Equals(other.Expires);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Expires = {this.Expires}");
        }
    }
}
// <copyright file="Credit.cs" company="APIMatic">
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
    /// Credit.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credit"/> class.
        /// </summary>
        public Credit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credit"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="expires">expires.</param>
        public Credit(
            Models.BillingAmount amount = null,
            DateTime? expires = null)
        {
            this.Amount = amount;
            this.Expires = expires;
        }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAmount Amount { get; set; }

        /// <summary>
        /// Gets or sets Expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Expires { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Credit : ({string.Join(", ", toStringOutput)})";
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
            return obj is Credit other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Expires == null && other.Expires == null) || (this.Expires?.Equals(other.Expires) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Expires = {(this.Expires == null ? "null" : this.Expires.ToString())}");
        }
    }
}
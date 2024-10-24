// <copyright file="BillingMethodAddress.cs" company="APIMatic">
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
    /// BillingMethodAddress.
    /// </summary>
    public class BillingMethodAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingMethodAddress"/> class.
        /// </summary>
        public BillingMethodAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingMethodAddress"/> class.
        /// </summary>
        /// <param name="country">country.</param>
        /// <param name="zip">zip.</param>
        public BillingMethodAddress(
            string country,
            string zip)
        {
            this.Country = country;
            this.Zip = zip;
        }

        /// <summary>
        /// The country this billing method is associated with.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The zip code this billing method is associated with.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingMethodAddress : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingMethodAddress other &&                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Zip == null && other.Zip == null) || (this.Zip?.Equals(other.Zip) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Zip = {(this.Zip == null ? "null" : this.Zip)}");
        }
    }
}
// <copyright file="CreditCard.cs" company="APIMatic">
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
    /// CreditCard.
    /// </summary>
    public class CreditCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard"/> class.
        /// </summary>
        public CreditCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="brand">brand.</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="last4">last_4.</param>
        public CreditCard(
            string name,
            string brand,
            Models.BillingMethodExpiration expiration,
            string last4)
        {
            this.Name = name;
            this.Brand = brand;
            this.Expiration = expiration;
            this.Last4 = last4;
        }

        /// <summary>
        /// A name associated with the credit cards usage.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The brand of card - ex VISA.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Expiration information for a billing method
        /// </summary>
        [JsonProperty("expiration")]
        public Models.BillingMethodExpiration Expiration { get; set; }

        /// <summary>
        /// The last 4 digits of the card.
        /// </summary>
        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreditCard : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreditCard other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Brand == null && other.Brand == null) || (this.Brand?.Equals(other.Brand) == true)) &&
                ((this.Expiration == null && other.Expiration == null) || (this.Expiration?.Equals(other.Expiration) == true)) &&
                ((this.Last4 == null && other.Last4 == null) || (this.Last4?.Equals(other.Last4) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Brand = {(this.Brand == null ? "null" : this.Brand)}");
            toStringOutput.Add($"this.Expiration = {(this.Expiration == null ? "null" : this.Expiration.ToString())}");
            toStringOutput.Add($"this.Last4 = {(this.Last4 == null ? "null" : this.Last4)}");
        }
    }
}
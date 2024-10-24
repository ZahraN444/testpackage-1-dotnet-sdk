// <copyright file="V1BillingMethodsRequest1.cs" company="APIMatic">
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
    /// V1BillingMethodsRequest1.
    /// </summary>
    public class V1BillingMethodsRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingMethodsRequest1"/> class.
        /// </summary>
        public V1BillingMethodsRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingMethodsRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="primary">primary.</param>
        /// <param name="address">address.</param>
        /// <param name="creditCard">credit_card.</param>
        public V1BillingMethodsRequest1(
            string name = null,
            bool? primary = null,
            Models.BillingMethodAddress address = null,
            Models.CreditCard creditCard = null)
        {
            this.Name = name;
            this.Primary = primary;
            this.Address = address;
            this.CreditCard = creditCard;
        }

        /// <summary>
        /// A name for the billing method.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A boolean where true represents a billing method being primary.
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <summary>
        /// Address information for a given billing method.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingMethodAddress Address { get; set; }

        /// <summary>
        /// Information about a credit card.
        /// </summary>
        [JsonProperty("credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreditCard CreditCard { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1BillingMethodsRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1BillingMethodsRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Primary == null && other.Primary == null) || (this.Primary?.Equals(other.Primary) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.CreditCard == null && other.CreditCard == null) || (this.CreditCard?.Equals(other.CreditCard) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Primary = {(this.Primary == null ? "null" : this.Primary.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
        }
    }
}
// <copyright file="V1BillingMethodsRequest.cs" company="APIMatic">
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
    /// V1BillingMethodsRequest.
    /// </summary>
    public class V1BillingMethodsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingMethodsRequest"/> class.
        /// </summary>
        public V1BillingMethodsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingMethodsRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="primary">primary.</param>
        /// <param name="address">address.</param>
        /// <param name="creditCard">credit_card.</param>
        public V1BillingMethodsRequest(
            string name,
            bool primary,
            Models.BillingMethodAddress address,
            Models.CreditCard1 creditCard)
        {
            this.Name = name;
            this.Primary = primary;
            this.Address = address;
            this.CreditCard = creditCard;
        }

        /// <summary>
        /// A name for the billing method.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A boolean where true represents a billing method being primary.
        /// </summary>
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        /// <summary>
        /// Address information for a given billing method.
        /// </summary>
        [JsonProperty("address")]
        public Models.BillingMethodAddress Address { get; set; }

        /// <summary>
        /// Gets or sets CreditCard.
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreditCard1 CreditCard { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1BillingMethodsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1BillingMethodsRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Primary.Equals(other.Primary) &&
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
            toStringOutput.Add($"this.Primary = {this.Primary}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
        }
    }
}
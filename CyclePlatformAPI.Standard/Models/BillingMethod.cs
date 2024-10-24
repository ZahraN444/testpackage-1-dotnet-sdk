// <copyright file="BillingMethod.cs" company="APIMatic">
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
    /// BillingMethod.
    /// </summary>
    public class BillingMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingMethod"/> class.
        /// </summary>
        public BillingMethod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingMethod"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="primary">primary.</param>
        /// <param name="address">address.</param>
        /// <param name="creator">creator.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        public BillingMethod(
            string id,
            string name,
            bool primary,
            Models.BillingMethodAddress address,
            Models.CreatorScope creator,
            Models.CreditCard creditCard,
            Models.State2 state,
            Models.CreditCardEvents events)
        {
            this.Id = id;
            this.Name = name;
            this.Primary = primary;
            this.Address = address;
            this.Creator = creator;
            this.CreditCard = creditCard;
            this.State = state;
            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// A name for the billing method.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// A boolean where true represents this billing method is set to primary for a given hub.
        /// </summary>
        [JsonProperty("primary")]
        [JsonRequired]
        public bool Primary { get; set; }

        /// <summary>
        /// Address information for a given billing method.
        /// </summary>
        [JsonProperty("address")]
        [JsonRequired]
        public Models.BillingMethodAddress Address { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// Information about a credit card.
        /// </summary>
        [JsonProperty("credit_card")]
        [JsonRequired]
        public Models.CreditCard CreditCard { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.State2 State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the credit card's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.CreditCardEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingMethod : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingMethod other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Primary.Equals(other.Primary) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.CreditCard == null && other.CreditCard == null) || (this.CreditCard?.Equals(other.CreditCard) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Primary = {this.Primary}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
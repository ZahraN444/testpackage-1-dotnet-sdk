// <copyright file="BillingRefund.cs" company="APIMatic">
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
    /// BillingRefund.
    /// </summary>
    public class BillingRefund
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingRefund"/> class.
        /// </summary>
        public BillingRefund()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingRefund"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="time">time.</param>
        /// <param name="description">description.</param>
        /// <param name="amount">amount.</param>
        /// <param name="gateway">gateway.</param>
        public BillingRefund(
            string id,
            DateTime time,
            string description,
            int amount,
            string gateway)
        {
            this.Id = id;
            this.Time = time;
            this.Description = description;
            this.Amount = amount;
            this.Gateway = gateway;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A timestamp for the payment.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Some information about the payment refund.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 1/10th of a cent.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The type of payment gateway used.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingRefund : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingRefund other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Time.Equals(other.Time) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Amount.Equals(other.Amount) &&
                ((this.Gateway == null && other.Gateway == null) || (this.Gateway?.Equals(other.Gateway) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Gateway = {(this.Gateway == null ? "null" : this.Gateway)}");
        }
    }
}
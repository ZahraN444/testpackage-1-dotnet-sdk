// <copyright file="BillingPayment.cs" company="APIMatic">
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
    /// BillingPayment.
    /// </summary>
    public class BillingPayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPayment"/> class.
        /// </summary>
        public BillingPayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPayment"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="time">time.</param>
        /// <param name="description">description.</param>
        /// <param name="amount">amount.</param>
        /// <param name="amountRefunded">amount_refunded.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="methodId">method_id.</param>
        /// <param name="result">result.</param>
        /// <param name="gateway">gateway.</param>
        public BillingPayment(
            string id,
            DateTime time,
            string description,
            int amount,
            int amountRefunded,
            List<Models.BillingRefund> refunds,
            string methodId,
            Models.PaymentResult result,
            string gateway)
        {
            this.Id = id;
            this.Time = time;
            this.Description = description;
            this.Amount = amount;
            this.AmountRefunded = amountRefunded;
            this.Refunds = refunds;
            this.MethodId = methodId;
            this.Result = result;
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
        /// Some information about the payment.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 1/10th of a cent.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 1/10th of a cent.
        /// </summary>
        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        /// <summary>
        /// Gets or sets Refunds.
        /// </summary>
        [JsonProperty("refunds")]
        public List<Models.BillingRefund> Refunds { get; set; }

        /// <summary>
        /// The ID associated with the billing method used.
        /// </summary>
        [JsonProperty("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// A billing payment result.
        /// </summary>
        [JsonProperty("result")]
        public Models.PaymentResult Result { get; set; }

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

            return $"BillingPayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingPayment other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Time.Equals(other.Time) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Amount.Equals(other.Amount) &&
                this.AmountRefunded.Equals(other.AmountRefunded) &&
                ((this.Refunds == null && other.Refunds == null) || (this.Refunds?.Equals(other.Refunds) == true)) &&
                ((this.MethodId == null && other.MethodId == null) || (this.MethodId?.Equals(other.MethodId) == true)) &&
                ((this.Result == null && other.Result == null) || (this.Result?.Equals(other.Result) == true)) &&
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
            toStringOutput.Add($"this.AmountRefunded = {this.AmountRefunded}");
            toStringOutput.Add($"this.Refunds = {(this.Refunds == null ? "null" : $"[{string.Join(", ", this.Refunds)} ]")}");
            toStringOutput.Add($"this.MethodId = {(this.MethodId == null ? "null" : this.MethodId)}");
            toStringOutput.Add($"this.Result = {(this.Result == null ? "null" : this.Result.ToString())}");
            toStringOutput.Add($"this.Gateway = {(this.Gateway == null ? "null" : this.Gateway)}");
        }
    }
}
// <copyright file="BillingOrderEvents1.cs" company="APIMatic">
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
    /// BillingOrderEvents1.
    /// </summary>
    public class BillingOrderEvents1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOrderEvents1"/> class.
        /// </summary>
        public BillingOrderEvents1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOrderEvents1"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="billed">billed.</param>
        /// <param name="paid">paid.</param>
        /// <param name="credited">credited.</param>
        /// <param name="voided">voided.</param>
        /// <param name="paymentAttempt">payment_attempt.</param>
        public BillingOrderEvents1(
            DateTime created,
            DateTime updated,
            DateTime deleted,
            DateTime billed,
            DateTime paid,
            DateTime credited,
            DateTime voided,
            DateTime? paymentAttempt = null)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.Billed = billed;
            this.Paid = paid;
            this.PaymentAttempt = paymentAttempt;
            this.Credited = credited;
            this.Voided = voided;
        }

        /// <summary>
        /// The timestamp of when the billing order was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the billing order was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The timestamp of when the billing order was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted")]
        public DateTime Deleted { get; set; }

        /// <summary>
        /// The timestamp of when the billing order billed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billed")]
        public DateTime Billed { get; set; }

        /// <summary>
        /// The timestamp of when the billing order paid.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid")]
        public DateTime Paid { get; set; }

        /// <summary>
        /// The timestamp of when the billing order payment was attempted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_attempt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PaymentAttempt { get; set; }

        /// <summary>
        /// The timestamp of when the billing order credited.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("credited")]
        public DateTime Credited { get; set; }

        /// <summary>
        /// The timestamp of when the billing order voided.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("voided")]
        public DateTime Voided { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingOrderEvents1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingOrderEvents1 other &&                this.Created.Equals(other.Created) &&
                this.Updated.Equals(other.Updated) &&
                this.Deleted.Equals(other.Deleted) &&
                this.Billed.Equals(other.Billed) &&
                this.Paid.Equals(other.Paid) &&
                ((this.PaymentAttempt == null && other.PaymentAttempt == null) || (this.PaymentAttempt?.Equals(other.PaymentAttempt) == true)) &&
                this.Credited.Equals(other.Credited) &&
                this.Voided.Equals(other.Voided);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Updated = {this.Updated}");
            toStringOutput.Add($"this.Deleted = {this.Deleted}");
            toStringOutput.Add($"this.Billed = {this.Billed}");
            toStringOutput.Add($"this.Paid = {this.Paid}");
            toStringOutput.Add($"this.PaymentAttempt = {(this.PaymentAttempt == null ? "null" : this.PaymentAttempt.ToString())}");
            toStringOutput.Add($"this.Credited = {this.Credited}");
            toStringOutput.Add($"this.Voided = {this.Voided}");
        }
    }
}
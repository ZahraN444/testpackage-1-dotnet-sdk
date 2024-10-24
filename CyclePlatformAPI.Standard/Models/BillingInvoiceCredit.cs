// <copyright file="BillingInvoiceCredit.cs" company="APIMatic">
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
    /// BillingInvoiceCredit.
    /// </summary>
    public class BillingInvoiceCredit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoiceCredit"/> class.
        /// </summary>
        public BillingInvoiceCredit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoiceCredit"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="associatedCredit">associated_credit.</param>
        /// <param name="time">time.</param>
        /// <param name="description">description.</param>
        /// <param name="amount">amount.</param>
        public BillingInvoiceCredit(
            string id,
            Models.AssociatedCredit associatedCredit,
            DateTime time,
            string description,
            int amount)
        {
            this.Id = id;
            this.AssociatedCredit = associatedCredit;
            this.Time = time;
            this.Description = description;
            this.Amount = amount;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Credit associated with an invoice.
        /// </summary>
        [JsonProperty("associated_credit")]
        public Models.AssociatedCredit AssociatedCredit { get; set; }

        /// <summary>
        /// A timestamp for when the invoice credit was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// A description of the invoice credit.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The amount of credit for the invoice.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingInvoiceCredit : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingInvoiceCredit other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AssociatedCredit == null && other.AssociatedCredit == null) || (this.AssociatedCredit?.Equals(other.AssociatedCredit) == true)) &&
                this.Time.Equals(other.Time) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Amount.Equals(other.Amount);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.AssociatedCredit = {(this.AssociatedCredit == null ? "null" : this.AssociatedCredit.ToString())}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
        }
    }
}
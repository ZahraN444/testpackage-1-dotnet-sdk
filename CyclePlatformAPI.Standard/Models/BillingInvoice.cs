// <copyright file="BillingInvoice.cs" company="APIMatic">
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
    /// BillingInvoice.
    /// </summary>
    public class BillingInvoice
    {
        private List<Models.BillingSummary> services;
        private List<Models.BillingPayment> payments;
        private List<Models.BillingInvoiceCredit> credits;
        private List<Models.LateFee> lateFees;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "services", false },
            { "payments", false },
            { "credits", false },
            { "late_fees", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoice"/> class.
        /// </summary>
        public BillingInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="approved">approved.</param>
        /// <param name="charges">charges.</param>
        /// <param name="failedPaymentAttempts">failed_payment_attempts.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="services">services.</param>
        /// <param name="payments">payments.</param>
        /// <param name="credits">credits.</param>
        /// <param name="lateFees">late_fees.</param>
        /// <param name="due">due.</param>
        /// <param name="overdue">overdue.</param>
        /// <param name="meta">meta.</param>
        public BillingInvoice(
            string id,
            string hubId,
            bool approved,
            int charges,
            int failedPaymentAttempts,
            Models.BillingOrderEvents1 events,
            Models.InvoiceState state,
            List<Models.BillingSummary> services = null,
            List<Models.BillingPayment> payments = null,
            List<Models.BillingInvoiceCredit> credits = null,
            List<Models.LateFee> lateFees = null,
            DateTime? due = null,
            DateTime? overdue = null,
            Models.InvoiceMeta meta = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Approved = approved;
            if (services != null)
            {
                this.Services = services;
            }

            if (payments != null)
            {
                this.Payments = payments;
            }

            if (credits != null)
            {
                this.Credits = credits;
            }

            if (lateFees != null)
            {
                this.LateFees = lateFees;
            }

            this.Charges = charges;
            this.Due = due;
            this.Overdue = overdue;
            this.FailedPaymentAttempts = failedPaymentAttempts;
            this.Events = events;
            this.State = state;
            this.Meta = meta;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A boolean where true represents the invoice is approved for collection.
        /// </summary>
        [JsonProperty("approved")]
        [JsonRequired]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets Services.
        /// </summary>
        [JsonProperty("services")]
        public List<Models.BillingSummary> Services
        {
            get
            {
                return this.services;
            }

            set
            {
                this.shouldSerialize["services"] = true;
                this.services = value;
            }
        }

        /// <summary>
        /// Gets or sets Payments.
        /// </summary>
        [JsonProperty("payments")]
        public List<Models.BillingPayment> Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                this.shouldSerialize["payments"] = true;
                this.payments = value;
            }
        }

        /// <summary>
        /// Gets or sets Credits.
        /// </summary>
        [JsonProperty("credits")]
        public List<Models.BillingInvoiceCredit> Credits
        {
            get
            {
                return this.credits;
            }

            set
            {
                this.shouldSerialize["credits"] = true;
                this.credits = value;
            }
        }

        /// <summary>
        /// Gets or sets LateFees.
        /// </summary>
        [JsonProperty("late_fees")]
        public List<Models.LateFee> LateFees
        {
            get
            {
                return this.lateFees;
            }

            set
            {
                this.shouldSerialize["late_fees"] = true;
                this.lateFees = value;
            }
        }

        /// <summary>
        /// The amount in charges generated through the licesnse agreement + overages for the billing period covered by the invoice.
        /// </summary>
        [JsonProperty("charges")]
        [JsonRequired]
        public int Charges { get; set; }

        /// <summary>
        /// A timestamp of when the invoice is due to be paid.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Due { get; set; }

        /// <summary>
        /// A timestamp of when the invoice is overdue.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("overdue", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Overdue { get; set; }

        /// <summary>
        /// The number of failed payment attempts for the invoice.
        /// </summary>
        [JsonProperty("failed_payment_attempts")]
        [JsonRequired]
        public int FailedPaymentAttempts { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the billing order's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.BillingOrderEvents1 Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.InvoiceState State { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to a invoice.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetServices()
        {
            this.shouldSerialize["services"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayments()
        {
            this.shouldSerialize["payments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCredits()
        {
            this.shouldSerialize["credits"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLateFees()
        {
            this.shouldSerialize["late_fees"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeServices()
        {
            return this.shouldSerialize["services"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayments()
        {
            return this.shouldSerialize["payments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCredits()
        {
            return this.shouldSerialize["credits"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLateFees()
        {
            return this.shouldSerialize["late_fees"];
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
            return obj is BillingInvoice other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                this.Approved.Equals(other.Approved) &&
                ((this.Services == null && other.Services == null) || (this.Services?.Equals(other.Services) == true)) &&
                ((this.Payments == null && other.Payments == null) || (this.Payments?.Equals(other.Payments) == true)) &&
                ((this.Credits == null && other.Credits == null) || (this.Credits?.Equals(other.Credits) == true)) &&
                ((this.LateFees == null && other.LateFees == null) || (this.LateFees?.Equals(other.LateFees) == true)) &&
                this.Charges.Equals(other.Charges) &&
                ((this.Due == null && other.Due == null) || (this.Due?.Equals(other.Due) == true)) &&
                ((this.Overdue == null && other.Overdue == null) || (this.Overdue?.Equals(other.Overdue) == true)) &&
                this.FailedPaymentAttempts.Equals(other.FailedPaymentAttempts) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Approved = {this.Approved}");
            toStringOutput.Add($"this.Services = {(this.Services == null ? "null" : $"[{string.Join(", ", this.Services)} ]")}");
            toStringOutput.Add($"this.Payments = {(this.Payments == null ? "null" : $"[{string.Join(", ", this.Payments)} ]")}");
            toStringOutput.Add($"this.Credits = {(this.Credits == null ? "null" : $"[{string.Join(", ", this.Credits)} ]")}");
            toStringOutput.Add($"this.LateFees = {(this.LateFees == null ? "null" : $"[{string.Join(", ", this.LateFees)} ]")}");
            toStringOutput.Add($"this.Charges = {this.Charges}");
            toStringOutput.Add($"this.Due = {(this.Due == null ? "null" : this.Due.ToString())}");
            toStringOutput.Add($"this.Overdue = {(this.Overdue == null ? "null" : this.Overdue.ToString())}");
            toStringOutput.Add($"this.FailedPaymentAttempts = {this.FailedPaymentAttempts}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}
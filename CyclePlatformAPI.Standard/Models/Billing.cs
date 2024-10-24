// <copyright file="Billing.cs" company="APIMatic">
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
    /// Billing.
    /// </summary>
    public class Billing
    {
        private List<string> emails;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "emails", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Billing"/> class.
        /// </summary>
        public Billing()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Billing"/> class.
        /// </summary>
        /// <param name="term">term.</param>
        /// <param name="allowPrepaid">allow_prepaid.</param>
        /// <param name="pauseInvoices">pause_invoices.</param>
        /// <param name="disable">disable.</param>
        /// <param name="plans">plans.</param>
        /// <param name="emails">emails.</param>
        public Billing(
            Models.BillingTerm term = null,
            bool? allowPrepaid = null,
            bool? pauseInvoices = null,
            bool? disable = null,
            Models.Plans plans = null,
            List<string> emails = null)
        {
            this.Term = term;
            this.AllowPrepaid = allowPrepaid;
            this.PauseInvoices = pauseInvoices;
            this.Disable = disable;
            this.Plans = plans;
            if (emails != null)
            {
                this.Emails = emails;
            }

        }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// A boolean where true represents this account being approved to use a prepaid card for billing transactions.
        /// </summary>
        [JsonProperty("allow_prepaid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPrepaid { get; set; }

        /// <summary>
        /// A boolean where true represents invoices have been paused on this hub for one reason or another.
        /// </summary>
        [JsonProperty("pause_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PauseInvoices { get; set; }

        /// <summary>
        /// A boolean where true means this billing is disabled on this hub.
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// Information about the plan associated with this hub.
        /// </summary>
        [JsonProperty("plans", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Plans Plans { get; set; }

        /// <summary>
        /// An array of email addresses to whom the billing invoices will be sent to. If left empty, they will be sent to the owner of this hub.
        /// </summary>
        [JsonProperty("emails")]
        public List<string> Emails
        {
            get
            {
                return this.emails;
            }

            set
            {
                this.shouldSerialize["emails"] = true;
                this.emails = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Billing : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmails()
        {
            this.shouldSerialize["emails"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmails()
        {
            return this.shouldSerialize["emails"];
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
            return obj is Billing other &&                ((this.Term == null && other.Term == null) || (this.Term?.Equals(other.Term) == true)) &&
                ((this.AllowPrepaid == null && other.AllowPrepaid == null) || (this.AllowPrepaid?.Equals(other.AllowPrepaid) == true)) &&
                ((this.PauseInvoices == null && other.PauseInvoices == null) || (this.PauseInvoices?.Equals(other.PauseInvoices) == true)) &&
                ((this.Disable == null && other.Disable == null) || (this.Disable?.Equals(other.Disable) == true)) &&
                ((this.Plans == null && other.Plans == null) || (this.Plans?.Equals(other.Plans) == true)) &&
                ((this.Emails == null && other.Emails == null) || (this.Emails?.Equals(other.Emails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Term = {(this.Term == null ? "null" : this.Term.ToString())}");
            toStringOutput.Add($"this.AllowPrepaid = {(this.AllowPrepaid == null ? "null" : this.AllowPrepaid.ToString())}");
            toStringOutput.Add($"this.PauseInvoices = {(this.PauseInvoices == null ? "null" : this.PauseInvoices.ToString())}");
            toStringOutput.Add($"this.Disable = {(this.Disable == null ? "null" : this.Disable.ToString())}");
            toStringOutput.Add($"this.Plans = {(this.Plans == null ? "null" : this.Plans.ToString())}");
            toStringOutput.Add($"this.Emails = {(this.Emails == null ? "null" : $"[{string.Join(", ", this.Emails)} ]")}");
        }
    }
}
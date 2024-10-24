// <copyright file="HubBillingProfile.cs" company="APIMatic">
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
    /// HubBillingProfile.
    /// </summary>
    public class HubBillingProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubBillingProfile"/> class.
        /// </summary>
        public HubBillingProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubBillingProfile"/> class.
        /// </summary>
        /// <param name="term">term.</param>
        /// <param name="pauseInvoices">pause_invoices.</param>
        /// <param name="plans">plans.</param>
        /// <param name="allowPrepaid">allow_prepaid.</param>
        /// <param name="disable">disable.</param>
        /// <param name="emails">emails.</param>
        public HubBillingProfile(
            Models.BillingTerm term,
            bool pauseInvoices,
            Models.Plans plans,
            bool? allowPrepaid = null,
            bool? disable = null,
            List<string> emails = null)
        {
            this.Term = term;
            this.AllowPrepaid = allowPrepaid;
            this.PauseInvoices = pauseInvoices;
            this.Disable = disable;
            this.Plans = plans;
            this.Emails = emails;
        }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term")]
        [JsonRequired]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// A boolean where true represents this account being approved to use a prepaid card for billing transactions.
        /// </summary>
        [JsonProperty("allow_prepaid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPrepaid { get; set; }

        /// <summary>
        /// A boolean where true represents invoices have been paused on this hub for one reason or another.
        /// </summary>
        [JsonProperty("pause_invoices")]
        [JsonRequired]
        public bool PauseInvoices { get; set; }

        /// <summary>
        /// A boolean where true means this billing is disabled on this hub.
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// Information about the plan associated with this hub.
        /// </summary>
        [JsonProperty("plans")]
        [JsonRequired]
        public Models.Plans Plans { get; set; }

        /// <summary>
        /// An array of email addresses to whom the billing invoices will be sent to. If left empty, they will be sent to the owner of this hub.
        /// </summary>
        [JsonConverter(typeof(CoreListConverter), typeof(JsonStringConverter))]
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Include)]
        public List<string> Emails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubBillingProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubBillingProfile other &&                ((this.Term == null && other.Term == null) || (this.Term?.Equals(other.Term) == true)) &&
                ((this.AllowPrepaid == null && other.AllowPrepaid == null) || (this.AllowPrepaid?.Equals(other.AllowPrepaid) == true)) &&
                this.PauseInvoices.Equals(other.PauseInvoices) &&
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
            toStringOutput.Add($"this.PauseInvoices = {this.PauseInvoices}");
            toStringOutput.Add($"this.Disable = {(this.Disable == null ? "null" : this.Disable.ToString())}");
            toStringOutput.Add($"this.Plans = {(this.Plans == null ? "null" : this.Plans.ToString())}");
            toStringOutput.Add($"this.Emails = {(this.Emails == null ? "null" : $"[{string.Join(", ", this.Emails)} ]")}");
        }
    }
}
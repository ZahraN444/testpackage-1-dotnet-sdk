// <copyright file="BillingTerm.cs" company="APIMatic">
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
    /// BillingTerm.
    /// </summary>
    public class BillingTerm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTerm"/> class.
        /// </summary>
        public BillingTerm()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingTerm"/> class.
        /// </summary>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        /// <param name="renew">renew.</param>
        public BillingTerm(
            DateTime start,
            DateTime end,
            Models.RenewEnum? renew = null)
        {
            this.Start = start;
            this.End = end;
            this.Renew = renew;
        }

        /// <summary>
        /// A timestamp describing the start of a billing term.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// A timestamp describing the end of a billing term.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end")]
        public DateTime End { get; set; }

        /// <summary>
        /// The term renewal period.
        /// </summary>
        [JsonProperty("renew", NullValueHandling = NullValueHandling.Include)]
        public Models.RenewEnum? Renew { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingTerm : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingTerm other &&                this.Start.Equals(other.Start) &&
                this.End.Equals(other.End) &&
                ((this.Renew == null && other.Renew == null) || (this.Renew?.Equals(other.Renew) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Start = {this.Start}");
            toStringOutput.Add($"this.End = {this.End}");
            toStringOutput.Add($"this.Renew = {(this.Renew == null ? "null" : this.Renew.ToString())}");
        }
    }
}
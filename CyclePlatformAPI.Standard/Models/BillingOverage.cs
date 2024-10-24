// <copyright file="BillingOverage.cs" company="APIMatic">
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
    /// BillingOverage.
    /// </summary>
    public class BillingOverage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOverage"/> class.
        /// </summary>
        public BillingOverage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOverage"/> class.
        /// </summary>
        /// <param name="term">term.</param>
        /// <param name="ram">ram.</param>
        public BillingOverage(
            Models.BillingTerm term,
            Models.Ram ram)
        {
            this.Term = term;
            this.Ram = ram;
        }

        /// <summary>
        /// Information about a billing term.
        /// </summary>
        [JsonProperty("term")]
        public Models.BillingTerm Term { get; set; }

        /// <summary>
        /// Used for gen 1 pricing.
        /// </summary>
        [JsonProperty("ram")]
        public Models.Ram Ram { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingOverage : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingOverage other &&                ((this.Term == null && other.Term == null) || (this.Term?.Equals(other.Term) == true)) &&
                ((this.Ram == null && other.Ram == null) || (this.Ram?.Equals(other.Ram) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Term = {(this.Term == null ? "null" : this.Term.ToString())}");
            toStringOutput.Add($"this.Ram = {(this.Ram == null ? "null" : this.Ram.ToString())}");
        }
    }
}
// <copyright file="BillingRam.cs" company="APIMatic">
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
    /// BillingRam.
    /// </summary>
    public class BillingRam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingRam"/> class.
        /// </summary>
        public BillingRam()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingRam"/> class.
        /// </summary>
        /// <param name="includedGb">included_gb.</param>
        /// <param name="additionalGb">additional_gb.</param>
        /// <param name="hardCap">hard_cap.</param>
        public BillingRam(
            double includedGb,
            Models.AdditionalGb additionalGb,
            bool hardCap)
        {
            this.IncludedGb = includedGb;
            this.AdditionalGb = additionalGb;
            this.HardCap = hardCap;
        }

        /// <summary>
        /// The GB of image storage included in tier
        /// </summary>
        [JsonProperty("included_gb")]
        public double IncludedGb { get; set; }

        /// <summary>
        /// Additional cost for image storage exceeding included_gb
        /// </summary>
        [JsonProperty("additional_gb")]
        public Models.AdditionalGb AdditionalGb { get; set; }

        /// <summary>
        /// A boolean indicating if there is a hard limit on the image storage
        /// </summary>
        [JsonProperty("hard_cap")]
        public bool HardCap { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingRam : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingRam other &&                this.IncludedGb.Equals(other.IncludedGb) &&
                ((this.AdditionalGb == null && other.AdditionalGb == null) || (this.AdditionalGb?.Equals(other.AdditionalGb) == true)) &&
                this.HardCap.Equals(other.HardCap);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IncludedGb = {this.IncludedGb}");
            toStringOutput.Add($"this.AdditionalGb = {(this.AdditionalGb == null ? "null" : this.AdditionalGb.ToString())}");
            toStringOutput.Add($"this.HardCap = {this.HardCap}");
        }
    }
}
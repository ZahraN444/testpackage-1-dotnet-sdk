// <copyright file="BillingServers.cs" company="APIMatic">
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
    /// BillingServers.
    /// </summary>
    public class BillingServers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingServers"/> class.
        /// </summary>
        public BillingServers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingServers"/> class.
        /// </summary>
        /// <param name="included">included.</param>
        /// <param name="hardCap">hard_cap.</param>
        /// <param name="additional">additional.</param>
        public BillingServers(
            double included,
            bool hardCap,
            Models.Additional additional)
        {
            this.Included = included;
            this.HardCap = hardCap;
            this.Additional = additional;
        }

        /// <summary>
        /// The number of servers included in the tier price
        /// </summary>
        [JsonProperty("included")]
        public double Included { get; set; }

        /// <summary>
        /// A boolean indicating if there is a hard server limit on the tier
        /// </summary>
        [JsonProperty("hard_cap")]
        public bool HardCap { get; set; }

        /// <summary>
        /// An object describing the additonal cost of servers exceeding the included server count
        /// </summary>
        [JsonProperty("additional")]
        public Models.Additional Additional { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingServers : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingServers other &&                this.Included.Equals(other.Included) &&
                this.HardCap.Equals(other.HardCap) &&
                ((this.Additional == null && other.Additional == null) || (this.Additional?.Equals(other.Additional) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Included = {this.Included}");
            toStringOutput.Add($"this.HardCap = {this.HardCap}");
            toStringOutput.Add($"this.Additional = {(this.Additional == null ? "null" : this.Additional.ToString())}");
        }
    }
}
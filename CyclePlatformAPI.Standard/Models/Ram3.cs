// <copyright file="Ram3.cs" company="APIMatic">
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
    /// Ram3.
    /// </summary>
    public class Ram3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ram3"/> class.
        /// </summary>
        public Ram3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ram3"/> class.
        /// </summary>
        /// <param name="totalMb">total_mb.</param>
        /// <param name="allocatedMb">allocated_mb.</param>
        /// <param name="usedMb">used_mb.</param>
        /// <param name="provisionedMb">provisioned_mb.</param>
        public Ram3(
            int totalMb,
            int allocatedMb,
            int usedMb,
            int? provisionedMb = null)
        {
            this.TotalMb = totalMb;
            this.AllocatedMb = allocatedMb;
            this.UsedMb = usedMb;
            this.ProvisionedMb = provisionedMb;
        }

        /// <summary>
        /// The total amount of RAM in MBsr.
        /// </summary>
        [JsonProperty("total_mb")]
        public int TotalMb { get; set; }

        /// <summary>
        /// The total amount of allocated RAM in MBs.
        /// </summary>
        [JsonProperty("allocated_mb")]
        public int AllocatedMb { get; set; }

        /// <summary>
        /// The total amount of used RAM in MBs.
        /// </summary>
        [JsonProperty("used_mb")]
        public int UsedMb { get; set; }

        /// <summary>
        /// The total amount of provisioned RAM in MBs.
        /// </summary>
        [JsonProperty("provisioned_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProvisionedMb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ram3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ram3 other &&                this.TotalMb.Equals(other.TotalMb) &&
                this.AllocatedMb.Equals(other.AllocatedMb) &&
                this.UsedMb.Equals(other.UsedMb) &&
                ((this.ProvisionedMb == null && other.ProvisionedMb == null) || (this.ProvisionedMb?.Equals(other.ProvisionedMb) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalMb = {this.TotalMb}");
            toStringOutput.Add($"this.AllocatedMb = {this.AllocatedMb}");
            toStringOutput.Add($"this.UsedMb = {this.UsedMb}");
            toStringOutput.Add($"this.ProvisionedMb = {(this.ProvisionedMb == null ? "null" : this.ProvisionedMb.ToString())}");
        }
    }
}
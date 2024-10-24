// <copyright file="Tier1.cs" company="APIMatic">
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
    /// Tier1.
    /// </summary>
    public class Tier1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tier1"/> class.
        /// </summary>
        public Tier1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tier1"/> class.
        /// </summary>
        /// <param name="totalMb">total_mb.</param>
        /// <param name="allocatedMb">allocated_mb.</param>
        /// <param name="usedMb">used_mb.</param>
        public Tier1(
            int totalMb,
            int allocatedMb,
            int usedMb)
        {
            this.TotalMb = totalMb;
            this.AllocatedMb = allocatedMb;
            this.UsedMb = usedMb;
        }

        /// <summary>
        /// A value in MB representing the total MB of space on the infrastructure available for images.
        /// </summary>
        [JsonProperty("total_mb")]
        public int TotalMb { get; set; }

        /// <summary>
        /// A value in MB representing the amount of allocated space for images.
        /// </summary>
        [JsonProperty("allocated_mb")]
        public int AllocatedMb { get; set; }

        /// <summary>
        /// A value in MB representing the total MB of space images are taking up out of the total megabytes available.
        /// </summary>
        [JsonProperty("used_mb")]
        public int UsedMb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Tier1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Tier1 other &&                this.TotalMb.Equals(other.TotalMb) &&
                this.AllocatedMb.Equals(other.AllocatedMb) &&
                this.UsedMb.Equals(other.UsedMb);
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
        }
    }
}
// <copyright file="InstanceTelemetryCPUSnapshot.cs" company="APIMatic">
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
    /// InstanceTelemetryCPUSnapshot.
    /// </summary>
    public class InstanceTelemetryCPUSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryCPUSnapshot"/> class.
        /// </summary>
        public InstanceTelemetryCPUSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryCPUSnapshot"/> class.
        /// </summary>
        /// <param name="usage">usage.</param>
        /// <param name="throttling">throttling.</param>
        public InstanceTelemetryCPUSnapshot(
            Models.Usage usage,
            Models.Throttling throttling)
        {
            this.Usage = usage;
            this.Throttling = throttling;
        }

        /// <summary>
        /// Usage statistics.
        /// </summary>
        [JsonProperty("usage")]
        public Models.Usage Usage { get; set; }

        /// <summary>
        /// Throttling statistics.
        /// </summary>
        [JsonProperty("throttling")]
        public Models.Throttling Throttling { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryCPUSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryCPUSnapshot other &&                ((this.Usage == null && other.Usage == null) || (this.Usage?.Equals(other.Usage) == true)) &&
                ((this.Throttling == null && other.Throttling == null) || (this.Throttling?.Equals(other.Throttling) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
            toStringOutput.Add($"this.Throttling = {(this.Throttling == null ? "null" : this.Throttling.ToString())}");
        }
    }
}
// <copyright file="InstanceTelemetryMemorySnapshot.cs" company="APIMatic">
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
    /// InstanceTelemetryMemorySnapshot.
    /// </summary>
    public class InstanceTelemetryMemorySnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryMemorySnapshot"/> class.
        /// </summary>
        public InstanceTelemetryMemorySnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryMemorySnapshot"/> class.
        /// </summary>
        /// <param name="cache">cache.</param>
        /// <param name="usage">usage.</param>
        /// <param name="swapUsage">swap_usage.</param>
        /// <param name="kernelUsage">kernel_usage.</param>
        /// <param name="kernelTcpUsage">kernel_tcp_usage.</param>
        public InstanceTelemetryMemorySnapshot(
            double? cache = null,
            Models.MemoryData1 usage = null,
            Models.MemoryData2 swapUsage = null,
            Models.MemoryData3 kernelUsage = null,
            Models.MemoryData4 kernelTcpUsage = null)
        {
            this.Cache = cache;
            this.Usage = usage;
            this.SwapUsage = swapUsage;
            this.KernelUsage = kernelUsage;
            this.KernelTcpUsage = kernelTcpUsage;
        }

        /// <summary>
        /// The number of bytes of page cache memory being used by this instance.
        /// </summary>
        [JsonProperty("cache", NullValueHandling = NullValueHandling.Ignore)]
        public double? Cache { get; set; }

        /// <summary>
        /// The memory usage data.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MemoryData1 Usage { get; set; }

        /// <summary>
        /// Memory swap usage data.
        /// </summary>
        [JsonProperty("swap_usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MemoryData2 SwapUsage { get; set; }

        /// <summary>
        /// Kernal memory usage.
        /// </summary>
        [JsonProperty("kernel_usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MemoryData3 KernelUsage { get; set; }

        /// <summary>
        /// Kernel TCP buffer usage.
        /// </summary>
        [JsonProperty("kernel_tcp_usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MemoryData4 KernelTcpUsage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryMemorySnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryMemorySnapshot other &&                ((this.Cache == null && other.Cache == null) || (this.Cache?.Equals(other.Cache) == true)) &&
                ((this.Usage == null && other.Usage == null) || (this.Usage?.Equals(other.Usage) == true)) &&
                ((this.SwapUsage == null && other.SwapUsage == null) || (this.SwapUsage?.Equals(other.SwapUsage) == true)) &&
                ((this.KernelUsage == null && other.KernelUsage == null) || (this.KernelUsage?.Equals(other.KernelUsage) == true)) &&
                ((this.KernelTcpUsage == null && other.KernelTcpUsage == null) || (this.KernelTcpUsage?.Equals(other.KernelTcpUsage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cache = {(this.Cache == null ? "null" : this.Cache.ToString())}");
            toStringOutput.Add($"this.Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
            toStringOutput.Add($"this.SwapUsage = {(this.SwapUsage == null ? "null" : this.SwapUsage.ToString())}");
            toStringOutput.Add($"this.KernelUsage = {(this.KernelUsage == null ? "null" : this.KernelUsage.ToString())}");
            toStringOutput.Add($"this.KernelTcpUsage = {(this.KernelTcpUsage == null ? "null" : this.KernelTcpUsage.ToString())}");
        }
    }
}
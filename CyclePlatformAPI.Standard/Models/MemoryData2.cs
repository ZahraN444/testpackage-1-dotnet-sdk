// <copyright file="MemoryData2.cs" company="APIMatic">
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
    /// MemoryData2.
    /// </summary>
    public class MemoryData2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryData2"/> class.
        /// </summary>
        public MemoryData2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryData2"/> class.
        /// </summary>
        /// <param name="usage">usage.</param>
        /// <param name="maxUsage">max_usage.</param>
        /// <param name="failCount">fail_count.</param>
        /// <param name="limit">limit.</param>
        public MemoryData2(
            double? usage = null,
            double? maxUsage = null,
            double? failCount = null,
            double? limit = null)
        {
            this.Usage = usage;
            this.MaxUsage = maxUsage;
            this.FailCount = failCount;
            this.Limit = limit;
        }

        /// <summary>
        /// The number in bytes of memory being used by the instance at the time of the snapshot.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Usage { get; set; }

        /// <summary>
        /// The highest amoun tof memory usage since the last restart.
        /// </summary>
        [JsonProperty("max_usage", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxUsage { get; set; }

        /// <summary>
        /// The number of times the memory liimit was exceeded for the instance.
        /// </summary>
        [JsonProperty("fail_count", NullValueHandling = NullValueHandling.Ignore)]
        public double? FailCount { get; set; }

        /// <summary>
        /// The maximum number of bytes of memory this instance has acess to.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MemoryData2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is MemoryData2 other &&                ((this.Usage == null && other.Usage == null) || (this.Usage?.Equals(other.Usage) == true)) &&
                ((this.MaxUsage == null && other.MaxUsage == null) || (this.MaxUsage?.Equals(other.MaxUsage) == true)) &&
                ((this.FailCount == null && other.FailCount == null) || (this.FailCount?.Equals(other.FailCount) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
            toStringOutput.Add($"this.MaxUsage = {(this.MaxUsage == null ? "null" : this.MaxUsage.ToString())}");
            toStringOutput.Add($"this.FailCount = {(this.FailCount == null ? "null" : this.FailCount.ToString())}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit.ToString())}");
        }
    }
}
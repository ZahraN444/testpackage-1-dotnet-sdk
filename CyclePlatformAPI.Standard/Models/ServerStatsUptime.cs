// <copyright file="ServerStatsUptime.cs" company="APIMatic">
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
    /// ServerStatsUptime.
    /// </summary>
    public class ServerStatsUptime
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsUptime"/> class.
        /// </summary>
        public ServerStatsUptime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsUptime"/> class.
        /// </summary>
        /// <param name="seconds">seconds.</param>
        /// <param name="cpuIdle">cpu_idle.</param>
        public ServerStatsUptime(
            double? seconds = null,
            double? cpuIdle = null)
        {
            this.Seconds = seconds;
            this.CpuIdle = cpuIdle;
        }

        /// <summary>
        /// The amount in seconds the server has been up (resets on restart).
        /// </summary>
        [JsonProperty("seconds", NullValueHandling = NullValueHandling.Ignore)]
        public double? Seconds { get; set; }

        /// <summary>
        /// CPU idle time.
        /// </summary>
        [JsonProperty("cpu_idle", NullValueHandling = NullValueHandling.Ignore)]
        public double? CpuIdle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsUptime : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsUptime other &&                ((this.Seconds == null && other.Seconds == null) || (this.Seconds?.Equals(other.Seconds) == true)) &&
                ((this.CpuIdle == null && other.CpuIdle == null) || (this.CpuIdle?.Equals(other.CpuIdle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Seconds = {(this.Seconds == null ? "null" : this.Seconds.ToString())}");
            toStringOutput.Add($"this.CpuIdle = {(this.CpuIdle == null ? "null" : this.CpuIdle.ToString())}");
        }
    }
}
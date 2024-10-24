// <copyright file="InstanceTelemetryProcessesSnapshot.cs" company="APIMatic">
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
    /// InstanceTelemetryProcessesSnapshot.
    /// </summary>
    public class InstanceTelemetryProcessesSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryProcessesSnapshot"/> class.
        /// </summary>
        public InstanceTelemetryProcessesSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryProcessesSnapshot"/> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="limit">limit.</param>
        public InstanceTelemetryProcessesSnapshot(
            double? current = null,
            double? limit = null)
        {
            this.Current = current;
            this.Limit = limit;
        }

        /// <summary>
        /// The current number of running processes in the instance.
        /// </summary>
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public double? Current { get; set; }

        /// <summary>
        /// The maximum number of running processes for the instance.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryProcessesSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryProcessesSnapshot other &&                ((this.Current == null && other.Current == null) || (this.Current?.Equals(other.Current) == true)) &&
                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Current = {(this.Current == null ? "null" : this.Current.ToString())}");
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit.ToString())}");
        }
    }
}
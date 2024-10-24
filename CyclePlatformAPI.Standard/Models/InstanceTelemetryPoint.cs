// <copyright file="InstanceTelemetryPoint.cs" company="APIMatic">
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
    /// InstanceTelemetryPoint.
    /// </summary>
    public class InstanceTelemetryPoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryPoint"/> class.
        /// </summary>
        public InstanceTelemetryPoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryPoint"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="instances">instances.</param>
        public InstanceTelemetryPoint(
            DateTime time,
            Dictionary<string, int> instances)
        {
            this.Time = time;
            this.Instances = instances;
        }

        /// <summary>
        /// A timestamp for when the data was collected.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Records for instance state and number of instances in that state.
        /// </summary>
        [JsonProperty("instances")]
        public Dictionary<string, int> Instances { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryPoint : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryPoint other &&                this.Time.Equals(other.Time) &&
                ((this.Instances == null && other.Instances == null) || (this.Instances?.Equals(other.Instances) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"Instances = {(this.Instances == null ? "null" : this.Instances.ToString())}");
        }
    }
}
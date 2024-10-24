// <copyright file="InstanceTelemetryReportRequest.cs" company="APIMatic">
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
    /// InstanceTelemetryReportRequest.
    /// </summary>
    public class InstanceTelemetryReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryReportRequest"/> class.
        /// </summary>
        public InstanceTelemetryReportRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryReportRequest"/> class.
        /// </summary>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        public InstanceTelemetryReportRequest(
            string instanceId,
            DateTime start,
            DateTime end)
        {
            this.InstanceId = instanceId;
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// The ID of the instance this telemetry reporting pertains to.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// A timestamp of when the snapshot began.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// A timestamp of when the snapshot ended.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end")]
        public DateTime End { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryReportRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryReportRequest other &&                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                this.Start.Equals(other.Start) &&
                this.End.Equals(other.End);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.Start = {this.Start}");
            toStringOutput.Add($"this.End = {this.End}");
        }
    }
}
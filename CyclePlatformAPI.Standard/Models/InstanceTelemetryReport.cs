// <copyright file="InstanceTelemetryReport.cs" company="APIMatic">
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
    /// InstanceTelemetryReport.
    /// </summary>
    public class InstanceTelemetryReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryReport"/> class.
        /// </summary>
        public InstanceTelemetryReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryReport"/> class.
        /// </summary>
        /// <param name="request">request.</param>
        /// <param name="snapshots">snapshots.</param>
        public InstanceTelemetryReport(
            Models.InstanceTelemetryReportRequest request,
            List<Models.InstanceTelemetryResourceSnapshot> snapshots)
        {
            this.Request = request;
            this.Snapshots = snapshots;
        }

        /// <summary>
        /// A summary of report requests and when they occured.
        /// </summary>
        [JsonProperty("request")]
        public Models.InstanceTelemetryReportRequest Request { get; set; }

        /// <summary>
        /// An array of telemetry snapshots.
        /// </summary>
        [JsonProperty("snapshots")]
        public List<Models.InstanceTelemetryResourceSnapshot> Snapshots { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryReport : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryReport other &&                ((this.Request == null && other.Request == null) || (this.Request?.Equals(other.Request) == true)) &&
                ((this.Snapshots == null && other.Snapshots == null) || (this.Snapshots?.Equals(other.Snapshots) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Request = {(this.Request == null ? "null" : this.Request.ToString())}");
            toStringOutput.Add($"this.Snapshots = {(this.Snapshots == null ? "null" : $"[{string.Join(", ", this.Snapshots)} ]")}");
        }
    }
}
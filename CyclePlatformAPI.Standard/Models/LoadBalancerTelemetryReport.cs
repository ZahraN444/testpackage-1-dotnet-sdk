// <copyright file="LoadBalancerTelemetryReport.cs" company="APIMatic">
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
    /// LoadBalancerTelemetryReport.
    /// </summary>
    public class LoadBalancerTelemetryReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryReport"/> class.
        /// </summary>
        public LoadBalancerTelemetryReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryReport"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="range">range.</param>
        /// <param name="snapshots">snapshots.</param>
        public LoadBalancerTelemetryReport(
            DateTime created,
            Models.Range range,
            List<Models.LoadBalancerTelemetryReportMergedSnapshot> snapshots = null)
        {
            this.Created = created;
            this.Range = range;
            this.Snapshots = snapshots;
        }

        /// <summary>
        /// Gets or sets Created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// A start and end date-time pair indicating a range of time
        /// </summary>
        [JsonProperty("range")]
        public Models.Range Range { get; set; }

        /// <summary>
        /// Gets or sets Snapshots.
        /// </summary>
        [JsonProperty("snapshots", NullValueHandling = NullValueHandling.Include)]
        public List<Models.LoadBalancerTelemetryReportMergedSnapshot> Snapshots { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetryReport : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetryReport other &&                this.Created.Equals(other.Created) &&
                ((this.Range == null && other.Range == null) || (this.Range?.Equals(other.Range) == true)) &&
                ((this.Snapshots == null && other.Snapshots == null) || (this.Snapshots?.Equals(other.Snapshots) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Range = {(this.Range == null ? "null" : this.Range.ToString())}");
            toStringOutput.Add($"this.Snapshots = {(this.Snapshots == null ? "null" : $"[{string.Join(", ", this.Snapshots)} ]")}");
        }
    }
}
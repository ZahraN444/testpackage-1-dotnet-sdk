// <copyright file="LoadBalancerTelemetryReportMergedSnapshot.cs" company="APIMatic">
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
    /// LoadBalancerTelemetryReportMergedSnapshot.
    /// </summary>
    public class LoadBalancerTelemetryReportMergedSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryReportMergedSnapshot"/> class.
        /// </summary>
        public LoadBalancerTelemetryReportMergedSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryReportMergedSnapshot"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="controller">controller.</param>
        /// <param name="metrics">metrics.</param>
        public LoadBalancerTelemetryReportMergedSnapshot(
            DateTime time,
            string controller,
            Models.LoadBalancerTelemetryControllerMetrics metrics)
        {
            this.Time = time;
            this.Controller = controller;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("controller")]
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets Metrics.
        /// </summary>
        [JsonProperty("metrics")]
        public Models.LoadBalancerTelemetryControllerMetrics Metrics { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetryReportMergedSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetryReportMergedSnapshot other &&                this.Time.Equals(other.Time) &&
                ((this.Controller == null && other.Controller == null) || (this.Controller?.Equals(other.Controller) == true)) &&
                ((this.Metrics == null && other.Metrics == null) || (this.Metrics?.Equals(other.Metrics) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Controller = {(this.Controller == null ? "null" : this.Controller)}");
            toStringOutput.Add($"this.Metrics = {(this.Metrics == null ? "null" : this.Metrics.ToString())}");
        }
    }
}
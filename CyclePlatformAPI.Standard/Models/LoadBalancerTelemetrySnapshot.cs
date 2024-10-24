// <copyright file="LoadBalancerTelemetrySnapshot.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// LoadBalancerTelemetrySnapshot.
    /// </summary>
    public class LoadBalancerTelemetrySnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetrySnapshot"/> class.
        /// </summary>
        public LoadBalancerTelemetrySnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetrySnapshot"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="started">started.</param>
        /// <param name="datasetId">dataset_id.</param>
        /// <param name="metrics">metrics.</param>
        /// <param name="version">version.</param>
        /// <param name="router">router.</param>
        /// <param name="urls">urls.</param>
        public LoadBalancerTelemetrySnapshot(
            DateTime time,
            DateTime started,
            int datasetId,
            Models.LoadBalancerTelemetryControllerMetrics metrics,
            string version = null,
            LoadBalancerTelemetrySnapshotRouter router = null,
            LoadBalancerTelemetrySnapshotUrls urls = null)
        {
            this.Time = time;
            this.Started = started;
            this.Version = version;
            this.DatasetId = datasetId;
            this.Router = router;
            this.Urls = urls;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        [JsonRequired]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets Started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started")]
        [JsonRequired]
        public DateTime Started { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets DatasetId.
        /// </summary>
        [JsonProperty("dataset_id")]
        [JsonRequired]
        public int DatasetId { get; set; }

        /// <summary>
        /// Gets or sets Router.
        /// </summary>
        [JsonProperty("router", NullValueHandling = NullValueHandling.Ignore)]
        public LoadBalancerTelemetrySnapshotRouter Router { get; set; }

        /// <summary>
        /// Gets or sets Urls.
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public LoadBalancerTelemetrySnapshotUrls Urls { get; set; }

        /// <summary>
        /// Gets or sets Metrics.
        /// </summary>
        [JsonProperty("metrics")]
        [JsonRequired]
        public Models.LoadBalancerTelemetryControllerMetrics Metrics { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetrySnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetrySnapshot other &&                this.Time.Equals(other.Time) &&
                this.Started.Equals(other.Started) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                this.DatasetId.Equals(other.DatasetId) &&
                ((this.Router == null && other.Router == null) || (this.Router?.Equals(other.Router) == true)) &&
                ((this.Urls == null && other.Urls == null) || (this.Urls?.Equals(other.Urls) == true)) &&
                ((this.Metrics == null && other.Metrics == null) || (this.Metrics?.Equals(other.Metrics) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Started = {this.Started}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.DatasetId = {this.DatasetId}");
            toStringOutput.Add($"Router = {(this.Router == null ? "null" : this.Router.ToString())}");
            toStringOutput.Add($"Urls = {(this.Urls == null ? "null" : this.Urls.ToString())}");
            toStringOutput.Add($"this.Metrics = {(this.Metrics == null ? "null" : this.Metrics.ToString())}");
        }
    }
}
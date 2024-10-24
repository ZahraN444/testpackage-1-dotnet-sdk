// <copyright file="Latest.cs" company="APIMatic">
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
    /// Latest.
    /// </summary>
    public class Latest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Latest"/> class.
        /// </summary>
        public Latest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Latest"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="started">started.</param>
        /// <param name="version">version.</param>
        /// <param name="datasetId">dataset_id.</param>
        /// <param name="router">router.</param>
        /// <param name="urls">urls.</param>
        /// <param name="metrics">metrics.</param>
        public Latest(
            DateTime? time = null,
            DateTime? started = null,
            string version = null,
            int? datasetId = null,
            LatestRouter router = null,
            LatestUrls urls = null,
            Models.LoadBalancerTelemetryControllerMetrics metrics = null)
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
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Gets or sets Started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Started { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets DatasetId.
        /// </summary>
        [JsonProperty("dataset_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DatasetId { get; set; }

        /// <summary>
        /// Gets or sets Router.
        /// </summary>
        [JsonProperty("router", NullValueHandling = NullValueHandling.Ignore)]
        public LatestRouter Router { get; set; }

        /// <summary>
        /// Gets or sets Urls.
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public LatestUrls Urls { get; set; }

        /// <summary>
        /// Gets or sets Metrics.
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LoadBalancerTelemetryControllerMetrics Metrics { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Latest : ({string.Join(", ", toStringOutput)})";
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
            return obj is Latest other &&                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.Started == null && other.Started == null) || (this.Started?.Equals(other.Started) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.DatasetId == null && other.DatasetId == null) || (this.DatasetId?.Equals(other.DatasetId) == true)) &&
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
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time.ToString())}");
            toStringOutput.Add($"this.Started = {(this.Started == null ? "null" : this.Started.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.DatasetId = {(this.DatasetId == null ? "null" : this.DatasetId.ToString())}");
            toStringOutput.Add($"Router = {(this.Router == null ? "null" : this.Router.ToString())}");
            toStringOutput.Add($"Urls = {(this.Urls == null ? "null" : this.Urls.ToString())}");
            toStringOutput.Add($"this.Metrics = {(this.Metrics == null ? "null" : this.Metrics.ToString())}");
        }
    }
}
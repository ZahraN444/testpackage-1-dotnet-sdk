// <copyright file="LoadBalancerTelemetryUrlRequestHandler2.cs" company="APIMatic">
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
    /// LoadBalancerTelemetryUrlRequestHandler2.
    /// </summary>
    public class LoadBalancerTelemetryUrlRequestHandler2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryUrlRequestHandler2"/> class.
        /// </summary>
        public LoadBalancerTelemetryUrlRequestHandler2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryUrlRequestHandler2"/> class.
        /// </summary>
        /// <param name="hits">hits.</param>
        /// <param name="timingMs">timing_ms.</param>
        public LoadBalancerTelemetryUrlRequestHandler2(
            int hits,
            int timingMs)
        {
            this.Hits = hits;
            this.TimingMs = timingMs;
        }

        /// <summary>
        /// The number of hits to a specific URL handler.
        /// </summary>
        [JsonProperty("hits")]
        public int Hits { get; set; }

        /// <summary>
        /// The cumulative ms of response time across all hits.
        /// </summary>
        [JsonProperty("timing_ms")]
        public int TimingMs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetryUrlRequestHandler2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetryUrlRequestHandler2 other &&                this.Hits.Equals(other.Hits) &&
                this.TimingMs.Equals(other.TimingMs);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hits = {this.Hits}");
            toStringOutput.Add($"this.TimingMs = {this.TimingMs}");
        }
    }
}
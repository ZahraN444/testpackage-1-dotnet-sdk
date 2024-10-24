// <copyright file="LoadBalancerTelemetryUrlMetrics.cs" company="APIMatic">
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
    /// LoadBalancerTelemetryUrlMetrics.
    /// </summary>
    public class LoadBalancerTelemetryUrlMetrics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryUrlMetrics"/> class.
        /// </summary>
        public LoadBalancerTelemetryUrlMetrics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryUrlMetrics"/> class.
        /// </summary>
        /// <param name="destinations">destinations.</param>
        public LoadBalancerTelemetryUrlMetrics(
            Dictionary<string, Models.Destinations1> destinations)
        {
            this.Destinations = destinations;
        }

        /// <summary>
        /// Gets or sets Destinations.
        /// </summary>
        [JsonProperty("destinations")]
        [JsonRequired]
        public Dictionary<string, Models.Destinations1> Destinations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetryUrlMetrics : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetryUrlMetrics other &&                ((this.Destinations == null && other.Destinations == null) || (this.Destinations?.Equals(other.Destinations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Destinations = {(this.Destinations == null ? "null" : this.Destinations.ToString())}");
        }
    }
}
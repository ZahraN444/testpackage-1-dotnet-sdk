// <copyright file="LoadBalancerTelemetryControllerMetrics.cs" company="APIMatic">
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
    /// LoadBalancerTelemetryControllerMetrics.
    /// </summary>
    public class LoadBalancerTelemetryControllerMetrics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryControllerMetrics"/> class.
        /// </summary>
        public LoadBalancerTelemetryControllerMetrics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryControllerMetrics"/> class.
        /// </summary>
        /// <param name="disconnects">disconnects.</param>
        /// <param name="connections">connections.</param>
        /// <param name="requests">requests.</param>
        /// <param name="bytesTransmitted">bytes_transmitted.</param>
        /// <param name="bytesReceived">bytes_received.</param>
        public LoadBalancerTelemetryControllerMetrics(
            Models.LoadBalancerTelemetryControllerDisconnectsMetrics disconnects,
            int connections,
            int requests,
            int bytesTransmitted,
            int bytesReceived)
        {
            this.Disconnects = disconnects;
            this.Connections = connections;
            this.Requests = requests;
            this.BytesTransmitted = bytesTransmitted;
            this.BytesReceived = bytesReceived;
        }

        /// <summary>
        /// Gets or sets Disconnects.
        /// </summary>
        [JsonProperty("disconnects")]
        public Models.LoadBalancerTelemetryControllerDisconnectsMetrics Disconnects { get; set; }

        /// <summary>
        /// Gets or sets Connections.
        /// </summary>
        [JsonProperty("connections")]
        public int Connections { get; set; }

        /// <summary>
        /// Gets or sets Requests.
        /// </summary>
        [JsonProperty("requests")]
        public int Requests { get; set; }

        /// <summary>
        /// Gets or sets BytesTransmitted.
        /// </summary>
        [JsonProperty("bytes_transmitted")]
        public int BytesTransmitted { get; set; }

        /// <summary>
        /// Gets or sets BytesReceived.
        /// </summary>
        [JsonProperty("bytes_received")]
        public int BytesReceived { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetryControllerMetrics : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetryControllerMetrics other &&                ((this.Disconnects == null && other.Disconnects == null) || (this.Disconnects?.Equals(other.Disconnects) == true)) &&
                this.Connections.Equals(other.Connections) &&
                this.Requests.Equals(other.Requests) &&
                this.BytesTransmitted.Equals(other.BytesTransmitted) &&
                this.BytesReceived.Equals(other.BytesReceived);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Disconnects = {(this.Disconnects == null ? "null" : this.Disconnects.ToString())}");
            toStringOutput.Add($"this.Connections = {this.Connections}");
            toStringOutput.Add($"this.Requests = {this.Requests}");
            toStringOutput.Add($"this.BytesTransmitted = {this.BytesTransmitted}");
            toStringOutput.Add($"this.BytesReceived = {this.BytesReceived}");
        }
    }
}
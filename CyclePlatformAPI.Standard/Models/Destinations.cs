// <copyright file="Destinations.cs" company="APIMatic">
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
    /// Destinations.
    /// </summary>
    public class Destinations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destinations"/> class.
        /// </summary>
        public Destinations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Destinations"/> class.
        /// </summary>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="connections">connections.</param>
        /// <param name="requests">requests.</param>
        /// <param name="latencyMs">latency_ms.</param>
        public Destinations(
            string instanceId,
            string containerId,
            Models.Connections1 connections = null,
            Models.Requests requests = null,
            List<int> latencyMs = null)
        {
            this.Connections = connections;
            this.Requests = requests;
            this.LatencyMs = latencyMs;
            this.InstanceId = instanceId;
            this.ContainerId = containerId;
        }

        /// <summary>
        /// Gets or sets Connections.
        /// </summary>
        [JsonProperty("connections", NullValueHandling = NullValueHandling.Include)]
        public Models.Connections1 Connections { get; set; }

        /// <summary>
        /// Gets or sets Requests.
        /// </summary>
        [JsonProperty("requests", NullValueHandling = NullValueHandling.Include)]
        public Models.Requests Requests { get; set; }

        /// <summary>
        /// Gets or sets LatencyMs.
        /// </summary>
        [JsonProperty("latency_ms", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> LatencyMs { get; set; }

        /// <summary>
        /// Gets or sets InstanceId.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or sets ContainerId.
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Destinations : ({string.Join(", ", toStringOutput)})";
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
            return obj is Destinations other &&                ((this.Connections == null && other.Connections == null) || (this.Connections?.Equals(other.Connections) == true)) &&
                ((this.Requests == null && other.Requests == null) || (this.Requests?.Equals(other.Requests) == true)) &&
                ((this.LatencyMs == null && other.LatencyMs == null) || (this.LatencyMs?.Equals(other.LatencyMs) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Connections = {(this.Connections == null ? "null" : this.Connections.ToString())}");
            toStringOutput.Add($"this.Requests = {(this.Requests == null ? "null" : this.Requests.ToString())}");
            toStringOutput.Add($"this.LatencyMs = {(this.LatencyMs == null ? "null" : $"[{string.Join(", ", this.LatencyMs)} ]")}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
        }
    }
}
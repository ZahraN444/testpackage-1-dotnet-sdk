// <copyright file="ClusterVersionServerCount.cs" company="APIMatic">
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
    /// ClusterVersionServerCount.
    /// </summary>
    public class ClusterVersionServerCount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterVersionServerCount"/> class.
        /// </summary>
        public ClusterVersionServerCount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterVersionServerCount"/> class.
        /// </summary>
        /// <param name="agent">agent.</param>
        /// <param name="agentSpawner">agent-spawner.</param>
        /// <param name="compute">compute.</param>
        /// <param name="computeSpawner">compute-spawner.</param>
        public ClusterVersionServerCount(
            Dictionary<string, double> agent,
            Dictionary<string, double> agentSpawner,
            Dictionary<string, double> compute,
            Dictionary<string, double> computeSpawner)
        {
            this.Agent = agent;
            this.AgentSpawner = agentSpawner;
            this.Compute = compute;
            this.ComputeSpawner = computeSpawner;
        }

        /// <summary>
        /// Gets or sets Agent.
        /// </summary>
        [JsonProperty("agent")]
        public Dictionary<string, double> Agent { get; set; }

        /// <summary>
        /// Gets or sets AgentSpawner.
        /// </summary>
        [JsonProperty("agent-spawner")]
        public Dictionary<string, double> AgentSpawner { get; set; }

        /// <summary>
        /// Gets or sets Compute.
        /// </summary>
        [JsonProperty("compute")]
        public Dictionary<string, double> Compute { get; set; }

        /// <summary>
        /// Gets or sets ComputeSpawner.
        /// </summary>
        [JsonProperty("compute-spawner")]
        public Dictionary<string, double> ComputeSpawner { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterVersionServerCount : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterVersionServerCount other &&                ((this.Agent == null && other.Agent == null) || (this.Agent?.Equals(other.Agent) == true)) &&
                ((this.AgentSpawner == null && other.AgentSpawner == null) || (this.AgentSpawner?.Equals(other.AgentSpawner) == true)) &&
                ((this.Compute == null && other.Compute == null) || (this.Compute?.Equals(other.Compute) == true)) &&
                ((this.ComputeSpawner == null && other.ComputeSpawner == null) || (this.ComputeSpawner?.Equals(other.ComputeSpawner) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Agent = {(this.Agent == null ? "null" : this.Agent.ToString())}");
            toStringOutput.Add($"AgentSpawner = {(this.AgentSpawner == null ? "null" : this.AgentSpawner.ToString())}");
            toStringOutput.Add($"Compute = {(this.Compute == null ? "null" : this.Compute.ToString())}");
            toStringOutput.Add($"ComputeSpawner = {(this.ComputeSpawner == null ? "null" : this.ComputeSpawner.ToString())}");
        }
    }
}
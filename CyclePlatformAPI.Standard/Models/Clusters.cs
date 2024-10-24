// <copyright file="Clusters.cs" company="APIMatic">
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
    /// Clusters.
    /// </summary>
    public class Clusters
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clusters"/> class.
        /// </summary>
        public Clusters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clusters"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="resources">resources.</param>
        /// <param name="healthy">healthy.</param>
        /// <param name="versions">versions.</param>
        /// <param name="instances">instances.</param>
        /// <param name="servers">servers.</param>
        public Clusters(
            string name,
            Models.InfrastructureResourceSummary1 resources,
            bool healthy,
            Models.ClusterVersionServerCount versions,
            Models.ResourceCountSummary instances,
            Models.Servers servers)
        {
            this.Name = name;
            this.Resources = resources;
            this.Healthy = healthy;
            this.Versions = versions;
            this.Instances = instances;
            this.Servers = servers;
        }

        /// <summary>
        /// The name of the cluster
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Information about the aggregate resources of the cluster.
        /// </summary>
        [JsonProperty("resources")]
        public Models.InfrastructureResourceSummary1 Resources { get; set; }

        /// <summary>
        /// Whether Cycle has determined this cluster to be healthy or not.
        /// </summary>
        [JsonProperty("healthy")]
        public bool Healthy { get; set; }

        /// <summary>
        /// A count of servers in a cluster with the given version of Cycle software
        /// </summary>
        [JsonProperty("versions")]
        public Models.ClusterVersionServerCount Versions { get; set; }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("instances")]
        public Models.ResourceCountSummary Instances { get; set; }

        /// <summary>
        /// Gets or sets Servers.
        /// </summary>
        [JsonProperty("servers")]
        public Models.Servers Servers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Clusters : ({string.Join(", ", toStringOutput)})";
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
            return obj is Clusters other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Resources == null && other.Resources == null) || (this.Resources?.Equals(other.Resources) == true)) &&
                this.Healthy.Equals(other.Healthy) &&
                ((this.Versions == null && other.Versions == null) || (this.Versions?.Equals(other.Versions) == true)) &&
                ((this.Instances == null && other.Instances == null) || (this.Instances?.Equals(other.Instances) == true)) &&
                ((this.Servers == null && other.Servers == null) || (this.Servers?.Equals(other.Servers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Resources = {(this.Resources == null ? "null" : this.Resources.ToString())}");
            toStringOutput.Add($"this.Healthy = {this.Healthy}");
            toStringOutput.Add($"this.Versions = {(this.Versions == null ? "null" : this.Versions.ToString())}");
            toStringOutput.Add($"this.Instances = {(this.Instances == null ? "null" : this.Instances.ToString())}");
            toStringOutput.Add($"this.Servers = {(this.Servers == null ? "null" : this.Servers.ToString())}");
        }
    }
}
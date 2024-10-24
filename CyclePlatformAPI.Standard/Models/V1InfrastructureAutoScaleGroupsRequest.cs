// <copyright file="V1InfrastructureAutoScaleGroupsRequest.cs" company="APIMatic">
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
    /// V1InfrastructureAutoScaleGroupsRequest.
    /// </summary>
    public class V1InfrastructureAutoScaleGroupsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureAutoScaleGroupsRequest"/> class.
        /// </summary>
        public V1InfrastructureAutoScaleGroupsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureAutoScaleGroupsRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="scale">scale.</param>
        /// <param name="infrastructure">infrastructure.</param>
        public V1InfrastructureAutoScaleGroupsRequest(
            string name,
            string identifier,
            string cluster,
            Models.AutoScaleGroupScale scale,
            Models.AutoScaleGroupInfrastructure infrastructure)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.Cluster = cluster;
            this.Scale = scale;
            this.Infrastructure = infrastructure;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Identifier.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// Gets or sets Scale.
        /// </summary>
        [JsonProperty("scale")]
        public Models.AutoScaleGroupScale Scale { get; set; }

        /// <summary>
        /// Gets or sets Infrastructure.
        /// </summary>
        [JsonProperty("infrastructure")]
        public Models.AutoScaleGroupInfrastructure Infrastructure { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1InfrastructureAutoScaleGroupsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1InfrastructureAutoScaleGroupsRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Scale == null && other.Scale == null) || (this.Scale?.Equals(other.Scale) == true)) &&
                ((this.Infrastructure == null && other.Infrastructure == null) || (this.Infrastructure?.Equals(other.Infrastructure) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Scale = {(this.Scale == null ? "null" : this.Scale.ToString())}");
            toStringOutput.Add($"this.Infrastructure = {(this.Infrastructure == null ? "null" : this.Infrastructure.ToString())}");
        }
    }
}
// <copyright file="ServerMeta.cs" company="APIMatic">
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
    /// ServerMeta.
    /// </summary>
    public class ServerMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMeta"/> class.
        /// </summary>
        public ServerMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMeta"/> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="instancesCount">instances_count.</param>
        public ServerMeta(
            Models.Node2 node = null,
            Models.ResourceCountSummary instancesCount = null)
        {
            this.Node = node;
            this.InstancesCount = instancesCount;
        }

        /// <summary>
        /// Infrormation about the status of the server.
        /// </summary>
        [JsonProperty("node", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Node2 Node { get; set; }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("instances_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary InstancesCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerMeta other &&                ((this.Node == null && other.Node == null) || (this.Node?.Equals(other.Node) == true)) &&
                ((this.InstancesCount == null && other.InstancesCount == null) || (this.InstancesCount?.Equals(other.InstancesCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Node = {(this.Node == null ? "null" : this.Node.ToString())}");
            toStringOutput.Add($"this.InstancesCount = {(this.InstancesCount == null ? "null" : this.InstancesCount.ToString())}");
        }
    }
}
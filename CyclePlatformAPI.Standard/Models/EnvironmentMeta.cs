// <copyright file="EnvironmentMeta.cs" company="APIMatic">
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
    /// EnvironmentMeta.
    /// </summary>
    public class EnvironmentMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentMeta"/> class.
        /// </summary>
        public EnvironmentMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentMeta"/> class.
        /// </summary>
        /// <param name="containersCount">containers_count.</param>
        /// <param name="instancesCount">instances_count.</param>
        /// <param name="containers">containers.</param>
        public EnvironmentMeta(
            Models.ResourceCountSummary containersCount = null,
            Models.ResourceCountSummary instancesCount = null,
            List<Models.Container2> containers = null)
        {
            this.ContainersCount = containersCount;
            this.InstancesCount = instancesCount;
            this.Containers = containers;
        }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("containers_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary ContainersCount { get; set; }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("instances_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary InstancesCount { get; set; }

        /// <summary>
        /// Gets or sets Containers.
        /// </summary>
        [JsonProperty("containers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Container2> Containers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentMeta other &&                ((this.ContainersCount == null && other.ContainersCount == null) || (this.ContainersCount?.Equals(other.ContainersCount) == true)) &&
                ((this.InstancesCount == null && other.InstancesCount == null) || (this.InstancesCount?.Equals(other.InstancesCount) == true)) &&
                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContainersCount = {(this.ContainersCount == null ? "null" : this.ContainersCount.ToString())}");
            toStringOutput.Add($"this.InstancesCount = {(this.InstancesCount == null ? "null" : this.InstancesCount.ToString())}");
            toStringOutput.Add($"this.Containers = {(this.Containers == null ? "null" : $"[{string.Join(", ", this.Containers)} ]")}");
        }
    }
}
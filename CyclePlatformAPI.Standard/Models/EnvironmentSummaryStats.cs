// <copyright file="EnvironmentSummaryStats.cs" company="APIMatic">
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
    /// EnvironmentSummaryStats.
    /// </summary>
    public class EnvironmentSummaryStats
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentSummaryStats"/> class.
        /// </summary>
        public EnvironmentSummaryStats()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentSummaryStats"/> class.
        /// </summary>
        /// <param name="containers">containers.</param>
        /// <param name="instances">instances.</param>
        public EnvironmentSummaryStats(
            Models.ResourceCountSummary containers,
            Models.ResourceCountSummary instances)
        {
            this.Containers = containers;
            this.Instances = instances;
        }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("containers")]
        public Models.ResourceCountSummary Containers { get; set; }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("instances")]
        public Models.ResourceCountSummary Instances { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentSummaryStats : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentSummaryStats other &&                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.Instances == null && other.Instances == null) || (this.Instances?.Equals(other.Instances) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"this.Instances = {(this.Instances == null ? "null" : this.Instances.ToString())}");
        }
    }
}
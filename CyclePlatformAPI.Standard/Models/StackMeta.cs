// <copyright file="StackMeta.cs" company="APIMatic">
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
    /// StackMeta.
    /// </summary>
    public class StackMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackMeta"/> class.
        /// </summary>
        public StackMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackMeta"/> class.
        /// </summary>
        /// <param name="containersCount">containers_count.</param>
        /// <param name="buildsCount">builds_count.</param>
        public StackMeta(
            Models.ResourceCountSummary containersCount = null,
            Models.ResourceCountSummary buildsCount = null)
        {
            this.ContainersCount = containersCount;
            this.BuildsCount = buildsCount;
        }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("containers_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary ContainersCount { get; set; }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("builds_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary BuildsCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackMeta other &&                ((this.ContainersCount == null && other.ContainersCount == null) || (this.ContainersCount?.Equals(other.ContainersCount) == true)) &&
                ((this.BuildsCount == null && other.BuildsCount == null) || (this.BuildsCount?.Equals(other.BuildsCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContainersCount = {(this.ContainersCount == null ? "null" : this.ContainersCount.ToString())}");
            toStringOutput.Add($"this.BuildsCount = {(this.BuildsCount == null ? "null" : this.BuildsCount.ToString())}");
        }
    }
}
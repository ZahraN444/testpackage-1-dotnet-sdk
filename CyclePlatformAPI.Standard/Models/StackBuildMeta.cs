// <copyright file="StackBuildMeta.cs" company="APIMatic">
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
    /// StackBuildMeta.
    /// </summary>
    public class StackBuildMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildMeta"/> class.
        /// </summary>
        public StackBuildMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildMeta"/> class.
        /// </summary>
        /// <param name="containersCount">containers_count.</param>
        public StackBuildMeta(
            Models.ResourceCountSummary containersCount = null)
        {
            this.ContainersCount = containersCount;
        }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("containers_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary ContainersCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackBuildMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackBuildMeta other &&                ((this.ContainersCount == null && other.ContainersCount == null) || (this.ContainersCount?.Equals(other.ContainersCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContainersCount = {(this.ContainersCount == null ? "null" : this.ContainersCount.ToString())}");
        }
    }
}
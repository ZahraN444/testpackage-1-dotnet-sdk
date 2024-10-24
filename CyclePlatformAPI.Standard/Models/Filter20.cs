// <copyright file="Filter20.cs" company="APIMatic">
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
    /// Filter20.
    /// </summary>
    public class Filter20
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter20"/> class.
        /// </summary>
        public Filter20()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter20"/> class.
        /// </summary>
        /// <param name="cluster">cluster.</param>
        public Filter20(
            string cluster = null)
        {
            this.Cluster = cluster;
        }

        /// <summary>
        /// `filter[cluster]=value` return an infrastructure summary only for the specified cluster.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public string Cluster { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter20 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter20 other &&                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
        }
    }
}
// <copyright file="Filter25.cs" company="APIMatic">
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
    /// Filter25.
    /// </summary>
    public class Filter25
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter25"/> class.
        /// </summary>
        public Filter25()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter25"/> class.
        /// </summary>
        /// <param name="cluster">cluster.</param>
        public Filter25(
            string cluster = null)
        {
            this.Cluster = cluster;
        }

        /// <summary>
        /// `filter[cluster]=clusterone,clustertwo` filtering by cluster.  Enter one or more clusters (commas separated) and the return will include tags from servers that match any cluster(s) in the list.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public string Cluster { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter25 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter25 other &&                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true));
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
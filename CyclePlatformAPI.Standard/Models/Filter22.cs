// <copyright file="Filter22.cs" company="APIMatic">
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
    /// Filter22.
    /// </summary>
    public class Filter22
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter22"/> class.
        /// </summary>
        public Filter22()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter22"/> class.
        /// </summary>
        /// <param name="search">search.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="state">state.</param>
        public Filter22(
            string search = null,
            string cluster = null,
            string identifier = null,
            string state = null)
        {
            this.Search = search;
            this.Cluster = cluster;
            this.Identifier = identifier;
            this.State = state;
        }

        /// <summary>
        /// `filter[search]=value` search for a value associated with a field on the given auto-scale group(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[cluster]=value` return a list of auto-scale groups that are associated with the specified cluster.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public string Cluster { get; set; }

        /// <summary>
        /// `filter[identifier]=value` list only those auto-scale groups matching this identifier. May return multiple results.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the provider's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter22 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter22 other &&                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
        }
    }
}
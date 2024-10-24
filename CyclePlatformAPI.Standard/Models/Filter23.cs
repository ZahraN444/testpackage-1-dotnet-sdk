// <copyright file="Filter23.cs" company="APIMatic">
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
    /// Filter23.
    /// </summary>
    public class Filter23
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter23"/> class.
        /// </summary>
        public Filter23()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter23"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="tags">tags.</param>
        /// <param name="clusters">clusters.</param>
        /// <param name="providers">providers.</param>
        public Filter23(
            string state = null,
            string tags = null,
            string clusters = null,
            string providers = null)
        {
            this.State = state;
            this.Tags = tags;
            this.Clusters = clusters;
            this.Providers = providers;
        }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the provider's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[tags]=tagone,tagtwo,tagthree` filtering by Server tag.  Enter one or more tags (comma separated) and the return will include servers that match any tags in the list.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// `filter[clusters]=clusterone,clustertwo` filtering by cluster.  Enter one or more clusters (commas separated) and the return will include servers that match any clusters in the list.
        /// </summary>
        [JsonProperty("clusters", NullValueHandling = NullValueHandling.Ignore)]
        public string Clusters { get; set; }

        /// <summary>
        /// `filter[providers]=providerone,providertwo` filtering by provider.  Enter one or more providers (commas separated) and the return will include servers that match any providers in the list.
        /// </summary>
        [JsonProperty("providers", NullValueHandling = NullValueHandling.Ignore)]
        public string Providers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter23 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter23 other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.Clusters == null && other.Clusters == null) || (this.Clusters?.Equals(other.Clusters) == true)) &&
                ((this.Providers == null && other.Providers == null) || (this.Providers?.Equals(other.Providers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags)}");
            toStringOutput.Add($"this.Clusters = {(this.Clusters == null ? "null" : this.Clusters)}");
            toStringOutput.Add($"this.Providers = {(this.Providers == null ? "null" : this.Providers)}");
        }
    }
}
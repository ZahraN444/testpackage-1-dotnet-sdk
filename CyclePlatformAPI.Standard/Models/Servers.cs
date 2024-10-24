// <copyright file="Servers.cs" company="APIMatic">
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
    /// Servers.
    /// </summary>
    public class Servers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Servers"/> class.
        /// </summary>
        public Servers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Servers"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="providers">providers.</param>
        /// <param name="serverIds">server_ids.</param>
        public Servers(
            double count,
            Dictionary<string, Models.Providers> providers,
            List<string> serverIds = null)
        {
            this.Count = count;
            this.Providers = providers;
            this.ServerIds = serverIds;
        }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count")]
        public double Count { get; set; }

        /// <summary>
        /// Gets or sets Providers.
        /// </summary>
        [JsonProperty("providers")]
        public Dictionary<string, Models.Providers> Providers { get; set; }

        /// <summary>
        /// IDs of all servers in this cluster.
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Servers : ({string.Join(", ", toStringOutput)})";
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
            return obj is Servers other &&                this.Count.Equals(other.Count) &&
                ((this.Providers == null && other.Providers == null) || (this.Providers?.Equals(other.Providers) == true)) &&
                ((this.ServerIds == null && other.ServerIds == null) || (this.ServerIds?.Equals(other.ServerIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {this.Count}");
            toStringOutput.Add($"Providers = {(this.Providers == null ? "null" : this.Providers.ToString())}");
            toStringOutput.Add($"this.ServerIds = {(this.ServerIds == null ? "null" : $"[{string.Join(", ", this.ServerIds)} ]")}");
        }
    }
}
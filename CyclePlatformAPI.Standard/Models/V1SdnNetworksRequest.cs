// <copyright file="V1SdnNetworksRequest.cs" company="APIMatic">
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
    /// V1SdnNetworksRequest.
    /// </summary>
    public class V1SdnNetworksRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1SdnNetworksRequest"/> class.
        /// </summary>
        public V1SdnNetworksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1SdnNetworksRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="environments">environments.</param>
        public V1SdnNetworksRequest(
            string name,
            string identifier,
            string cluster,
            List<string> environments)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.Cluster = cluster;
            this.Environments = environments;
        }

        /// <summary>
        /// The name of the Network.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A Network identifier used to construct http calls that specifically use this Network over another.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The infrastructure Cluster the Environments belonging to this Network belong to.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// An array of Environment Ids
        /// </summary>
        [JsonProperty("environments")]
        public List<string> Environments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1SdnNetworksRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1SdnNetworksRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Environments = {(this.Environments == null ? "null" : $"[{string.Join(", ", this.Environments)} ]")}");
        }
    }
}
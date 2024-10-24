// <copyright file="V1InfrastructureServersRequest.cs" company="APIMatic">
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
    /// V1InfrastructureServersRequest.
    /// </summary>
    public class V1InfrastructureServersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureServersRequest"/> class.
        /// </summary>
        public V1InfrastructureServersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureServersRequest"/> class.
        /// </summary>
        /// <param name="cluster">cluster.</param>
        /// <param name="servers">servers.</param>
        public V1InfrastructureServersRequest(
            string cluster,
            List<Models.Servers1> servers)
        {
            this.Cluster = cluster;
            this.Servers = servers;
        }

        /// <summary>
        /// The existing or new cluster this infrastructure should be provisioned in.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// An array of servers to provision.
        /// </summary>
        [JsonProperty("servers")]
        public List<Models.Servers1> Servers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1InfrastructureServersRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1InfrastructureServersRequest other &&                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Servers == null && other.Servers == null) || (this.Servers?.Equals(other.Servers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Servers = {(this.Servers == null ? "null" : $"[{string.Join(", ", this.Servers)} ]")}");
        }
    }
}
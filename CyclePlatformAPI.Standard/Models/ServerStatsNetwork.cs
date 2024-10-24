// <copyright file="ServerStatsNetwork.cs" company="APIMatic">
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
    /// ServerStatsNetwork.
    /// </summary>
    public class ServerStatsNetwork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsNetwork"/> class.
        /// </summary>
        public ServerStatsNetwork()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsNetwork"/> class.
        /// </summary>
        /// <param name="externalIpv4">external_ipv4.</param>
        /// <param name="externalIpv6">external_ipv6.</param>
        /// <param name="interfaces">interfaces.</param>
        public ServerStatsNetwork(
            string externalIpv4,
            string externalIpv6,
            Dictionary<string, Models.Interfaces> interfaces = null)
        {
            this.Interfaces = interfaces;
            this.ExternalIpv4 = externalIpv4;
            this.ExternalIpv6 = externalIpv6;
        }

        /// <summary>
        /// Network interfaces for a given server.
        /// </summary>
        [JsonProperty("interfaces", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Interfaces> Interfaces { get; set; }

        /// <summary>
        /// The public IPv4 address used to connect to this server.
        /// </summary>
        [JsonProperty("external_ipv4")]
        public string ExternalIpv4 { get; set; }

        /// <summary>
        /// The public IPv6 address used to connect to this server.
        /// </summary>
        [JsonProperty("external_ipv6")]
        public string ExternalIpv6 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsNetwork : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsNetwork other &&                ((this.Interfaces == null && other.Interfaces == null) || (this.Interfaces?.Equals(other.Interfaces) == true)) &&
                ((this.ExternalIpv4 == null && other.ExternalIpv4 == null) || (this.ExternalIpv4?.Equals(other.ExternalIpv4) == true)) &&
                ((this.ExternalIpv6 == null && other.ExternalIpv6 == null) || (this.ExternalIpv6?.Equals(other.ExternalIpv6) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Interfaces = {(this.Interfaces == null ? "null" : this.Interfaces.ToString())}");
            toStringOutput.Add($"this.ExternalIpv4 = {(this.ExternalIpv4 == null ? "null" : this.ExternalIpv4)}");
            toStringOutput.Add($"this.ExternalIpv6 = {(this.ExternalIpv6 == null ? "null" : this.ExternalIpv6)}");
        }
    }
}
// <copyright file="PrivateNetwork.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// PrivateNetwork.
    /// </summary>
    public class PrivateNetwork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork"/> class.
        /// </summary>
        public PrivateNetwork()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork"/> class.
        /// </summary>
        /// <param name="vxlanTag">vxlan_tag.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="legacy">legacy.</param>
        public PrivateNetwork(
            int vxlanTag,
            string subnet,
            Models.IPNet ipv6,
            PrivateNetworkLegacy legacy)
        {
            this.VxlanTag = vxlanTag;
            this.Subnet = subnet;
            this.Ipv6 = ipv6;
            this.Legacy = legacy;
        }

        /// <summary>
        /// The vxlan tag added to each packet to help identify the network.
        /// </summary>
        [JsonProperty("vxlan_tag")]
        [JsonRequired]
        public int VxlanTag { get; set; }

        /// <summary>
        /// The subnet ID.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("subnet")]
        [JsonRequired]
        public string Subnet { get; set; }

        /// <summary>
        /// Gets or sets Ipv6.
        /// </summary>
        [JsonProperty("ipv6")]
        [JsonRequired]
        public Models.IPNet Ipv6 { get; set; }

        /// <summary>
        /// Gets or sets Legacy.
        /// </summary>
        [JsonProperty("legacy")]
        [JsonRequired]
        public PrivateNetworkLegacy Legacy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrivateNetwork : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrivateNetwork other &&                this.VxlanTag.Equals(other.VxlanTag) &&
                ((this.Subnet == null && other.Subnet == null) || (this.Subnet?.Equals(other.Subnet) == true)) &&
                ((this.Ipv6 == null && other.Ipv6 == null) || (this.Ipv6?.Equals(other.Ipv6) == true)) &&
                ((this.Legacy == null && other.Legacy == null) || (this.Legacy?.Equals(other.Legacy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VxlanTag = {this.VxlanTag}");
            toStringOutput.Add($"this.Subnet = {(this.Subnet == null ? "null" : this.Subnet)}");
            toStringOutput.Add($"this.Ipv6 = {(this.Ipv6 == null ? "null" : this.Ipv6.ToString())}");
            toStringOutput.Add($"Legacy = {(this.Legacy == null ? "null" : this.Legacy.ToString())}");
        }
    }
}
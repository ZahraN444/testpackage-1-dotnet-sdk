// <copyright file="NetworkPrivacySettings.cs" company="APIMatic">
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
    /// NetworkPrivacySettings.
    /// </summary>
    public class NetworkPrivacySettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPrivacySettings"/> class.
        /// </summary>
        public NetworkPrivacySettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPrivacySettings"/> class.
        /// </summary>
        /// <param name="vxlanTag">vxlan_tag.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="macAddrSuffix">mac_addr_suffix.</param>
        /// <param name="ipv6">ipv6.</param>
        public NetworkPrivacySettings(
            int vxlanTag,
            string subnet,
            int macAddrSuffix,
            Models.Ipv63 ipv6)
        {
            this.VxlanTag = vxlanTag;
            this.Subnet = subnet;
            this.MacAddrSuffix = macAddrSuffix;
            this.Ipv6 = ipv6;
        }

        /// <summary>
        /// A tag used to ensure proper routing.
        /// </summary>
        [JsonProperty("vxlan_tag")]
        [JsonRequired]
        public int VxlanTag { get; set; }

        /// <summary>
        /// The subnet of the private network.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("subnet")]
        [JsonRequired]
        public string Subnet { get; set; }

        /// <summary>
        /// A number used to ensure a MAC address exists for each network.
        /// </summary>
        [JsonProperty("mac_addr_suffix")]
        [JsonRequired]
        public int MacAddrSuffix { get; set; }

        /// <summary>
        /// IPv6 infromation for the network.
        /// </summary>
        [JsonProperty("ipv6")]
        [JsonRequired]
        public Models.Ipv63 Ipv6 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkPrivacySettings : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkPrivacySettings other &&                this.VxlanTag.Equals(other.VxlanTag) &&
                ((this.Subnet == null && other.Subnet == null) || (this.Subnet?.Equals(other.Subnet) == true)) &&
                this.MacAddrSuffix.Equals(other.MacAddrSuffix) &&
                ((this.Ipv6 == null && other.Ipv6 == null) || (this.Ipv6?.Equals(other.Ipv6) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VxlanTag = {this.VxlanTag}");
            toStringOutput.Add($"this.Subnet = {(this.Subnet == null ? "null" : this.Subnet)}");
            toStringOutput.Add($"this.MacAddrSuffix = {this.MacAddrSuffix}");
            toStringOutput.Add($"this.Ipv6 = {(this.Ipv6 == null ? "null" : this.Ipv6.ToString())}");
        }
    }
}
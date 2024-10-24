// <copyright file="PrivateNetwork2.cs" company="APIMatic">
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
    /// PrivateNetwork2.
    /// </summary>
    public class PrivateNetwork2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork2"/> class.
        /// </summary>
        public PrivateNetwork2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork2"/> class.
        /// </summary>
        /// <param name="vxlanTag">vxlan_tag.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="macAddrSuffix">mac_addr_suffix.</param>
        /// <param name="ipv6">ipv6.</param>
        public PrivateNetwork2(
            int? vxlanTag = null,
            string subnet = null,
            int? macAddrSuffix = null,
            Models.Ipv63 ipv6 = null)
        {
            this.VxlanTag = vxlanTag;
            this.Subnet = subnet;
            this.MacAddrSuffix = macAddrSuffix;
            this.Ipv6 = ipv6;
        }

        /// <summary>
        /// A tag used to ensure proper routing.
        /// </summary>
        [JsonProperty("vxlan_tag", NullValueHandling = NullValueHandling.Ignore)]
        public int? VxlanTag { get; set; }

        /// <summary>
        /// The subnet of the private network.
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public string Subnet { get; set; }

        /// <summary>
        /// A number used to ensure a MAC address exists for each network.
        /// </summary>
        [JsonProperty("mac_addr_suffix", NullValueHandling = NullValueHandling.Ignore)]
        public int? MacAddrSuffix { get; set; }

        /// <summary>
        /// IPv6 infromation for the network.
        /// </summary>
        [JsonProperty("ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Ipv63 Ipv6 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrivateNetwork2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrivateNetwork2 other &&                ((this.VxlanTag == null && other.VxlanTag == null) || (this.VxlanTag?.Equals(other.VxlanTag) == true)) &&
                ((this.Subnet == null && other.Subnet == null) || (this.Subnet?.Equals(other.Subnet) == true)) &&
                ((this.MacAddrSuffix == null && other.MacAddrSuffix == null) || (this.MacAddrSuffix?.Equals(other.MacAddrSuffix) == true)) &&
                ((this.Ipv6 == null && other.Ipv6 == null) || (this.Ipv6?.Equals(other.Ipv6) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VxlanTag = {(this.VxlanTag == null ? "null" : this.VxlanTag.ToString())}");
            toStringOutput.Add($"this.Subnet = {(this.Subnet == null ? "null" : this.Subnet)}");
            toStringOutput.Add($"this.MacAddrSuffix = {(this.MacAddrSuffix == null ? "null" : this.MacAddrSuffix.ToString())}");
            toStringOutput.Add($"this.Ipv6 = {(this.Ipv6 == null ? "null" : this.Ipv6.ToString())}");
        }
    }
}
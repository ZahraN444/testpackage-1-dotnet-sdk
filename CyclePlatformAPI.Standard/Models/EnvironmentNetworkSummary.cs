// <copyright file="EnvironmentNetworkSummary.cs" company="APIMatic">
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
    /// EnvironmentNetworkSummary.
    /// </summary>
    public class EnvironmentNetworkSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkSummary"/> class.
        /// </summary>
        public EnvironmentNetworkSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNetworkSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="networkSubnet">network_subnet.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="macAddr">mac_addr.</param>
        /// <param name="vxlanTag">vxlan_tag.</param>
        /// <param name="legacy">legacy.</param>
        public EnvironmentNetworkSummary(
            string id,
            string networkSubnet,
            string subnet,
            EnvironmentNetworkSummaryIpv6 ipv6,
            string macAddr,
            int vxlanTag,
            Models.Legacy2 legacy = null)
        {
            this.Id = id;
            this.NetworkSubnet = networkSubnet;
            this.Subnet = subnet;
            this.Ipv6 = ipv6;
            this.Legacy = legacy;
            this.MacAddr = macAddr;
            this.VxlanTag = vxlanTag;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets NetworkSubnet.
        /// </summary>
        [JsonProperty("network_subnet")]
        public string NetworkSubnet { get; set; }

        /// <summary>
        /// Gets or sets Subnet.
        /// </summary>
        [JsonProperty("subnet")]
        public string Subnet { get; set; }

        /// <summary>
        /// Gets or sets Ipv6.
        /// </summary>
        [JsonProperty("ipv6")]
        public EnvironmentNetworkSummaryIpv6 Ipv6 { get; set; }

        /// <summary>
        /// Gets or sets Legacy.
        /// </summary>
        [JsonProperty("legacy", NullValueHandling = NullValueHandling.Include)]
        public Models.Legacy2 Legacy { get; set; }

        /// <summary>
        /// Gets or sets MacAddr.
        /// </summary>
        [JsonProperty("mac_addr")]
        public string MacAddr { get; set; }

        /// <summary>
        /// Gets or sets VxlanTag.
        /// </summary>
        [JsonProperty("vxlan_tag")]
        public int VxlanTag { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentNetworkSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentNetworkSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.NetworkSubnet == null && other.NetworkSubnet == null) || (this.NetworkSubnet?.Equals(other.NetworkSubnet) == true)) &&
                ((this.Subnet == null && other.Subnet == null) || (this.Subnet?.Equals(other.Subnet) == true)) &&
                ((this.Ipv6 == null && other.Ipv6 == null) || (this.Ipv6?.Equals(other.Ipv6) == true)) &&
                ((this.Legacy == null && other.Legacy == null) || (this.Legacy?.Equals(other.Legacy) == true)) &&
                ((this.MacAddr == null && other.MacAddr == null) || (this.MacAddr?.Equals(other.MacAddr) == true)) &&
                this.VxlanTag.Equals(other.VxlanTag);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.NetworkSubnet = {(this.NetworkSubnet == null ? "null" : this.NetworkSubnet)}");
            toStringOutput.Add($"this.Subnet = {(this.Subnet == null ? "null" : this.Subnet)}");
            toStringOutput.Add($"Ipv6 = {(this.Ipv6 == null ? "null" : this.Ipv6.ToString())}");
            toStringOutput.Add($"this.Legacy = {(this.Legacy == null ? "null" : this.Legacy.ToString())}");
            toStringOutput.Add($"this.MacAddr = {(this.MacAddr == null ? "null" : this.MacAddr)}");
            toStringOutput.Add($"this.VxlanTag = {this.VxlanTag}");
        }
    }
}
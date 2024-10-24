// <copyright file="PrivateNetwork1.cs" company="APIMatic">
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
    /// PrivateNetwork1.
    /// </summary>
    public class PrivateNetwork1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork1"/> class.
        /// </summary>
        public PrivateNetwork1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateNetwork1"/> class.
        /// </summary>
        /// <param name="vxlanTag">vxlan_tag.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="legacy">legacy.</param>
        public PrivateNetwork1(
            int? vxlanTag = null,
            string subnet = null,
            Models.IPNet ipv6 = null,
            PrivateNetwork1Legacy legacy = null)
        {
            this.VxlanTag = vxlanTag;
            this.Subnet = subnet;
            this.Ipv6 = ipv6;
            this.Legacy = legacy;
        }

        /// <summary>
        /// The vxlan tag added to each packet to help identify the network.
        /// </summary>
        [JsonProperty("vxlan_tag", NullValueHandling = NullValueHandling.Ignore)]
        public int? VxlanTag { get; set; }

        /// <summary>
        /// The subnet ID.
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public string Subnet { get; set; }

        /// <summary>
        /// Gets or sets Ipv6.
        /// </summary>
        [JsonProperty("ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IPNet Ipv6 { get; set; }

        /// <summary>
        /// Gets or sets Legacy.
        /// </summary>
        [JsonProperty("legacy", NullValueHandling = NullValueHandling.Ignore)]
        public PrivateNetwork1Legacy Legacy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrivateNetwork1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrivateNetwork1 other &&                ((this.VxlanTag == null && other.VxlanTag == null) || (this.VxlanTag?.Equals(other.VxlanTag) == true)) &&
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
            toStringOutput.Add($"this.VxlanTag = {(this.VxlanTag == null ? "null" : this.VxlanTag.ToString())}");
            toStringOutput.Add($"this.Subnet = {(this.Subnet == null ? "null" : this.Subnet)}");
            toStringOutput.Add($"this.Ipv6 = {(this.Ipv6 == null ? "null" : this.Ipv6.ToString())}");
            toStringOutput.Add($"Legacy = {(this.Legacy == null ? "null" : this.Legacy.ToString())}");
        }
    }
}
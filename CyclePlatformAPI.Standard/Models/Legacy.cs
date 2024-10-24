// <copyright file="Legacy.cs" company="APIMatic">
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
    /// Legacy.
    /// </summary>
    public class Legacy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Legacy"/> class.
        /// </summary>
        public Legacy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Legacy"/> class.
        /// </summary>
        /// <param name="subnet">subnet.</param>
        /// <param name="ipv4">ipv4.</param>
        public Legacy(
            int? subnet = null,
            LegacyIpv4 ipv4 = null)
        {
            this.Subnet = subnet;
            this.Ipv4 = ipv4;
        }

        /// <summary>
        /// The IPv4 subnet Id.
        /// </summary>
        [JsonProperty("subnet", NullValueHandling = NullValueHandling.Ignore)]
        public int? Subnet { get; set; }

        /// <summary>
        /// IPv4 information available from environments using legacy networking.
        /// </summary>
        [JsonProperty("ipv4", NullValueHandling = NullValueHandling.Ignore)]
        public LegacyIpv4 Ipv4 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Legacy : ({string.Join(", ", toStringOutput)})";
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
            return obj is Legacy other &&                ((this.Subnet == null && other.Subnet == null) || (this.Subnet?.Equals(other.Subnet) == true)) &&
                ((this.Ipv4 == null && other.Ipv4 == null) || (this.Ipv4?.Equals(other.Ipv4) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Subnet = {(this.Subnet == null ? "null" : this.Subnet.ToString())}");
            toStringOutput.Add($"Ipv4 = {(this.Ipv4 == null ? "null" : this.Ipv4.ToString())}");
        }
    }
}
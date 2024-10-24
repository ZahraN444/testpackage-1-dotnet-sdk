// <copyright file="Legacy2.cs" company="APIMatic">
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
    /// Legacy2.
    /// </summary>
    public class Legacy2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Legacy2"/> class.
        /// </summary>
        public Legacy2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Legacy2"/> class.
        /// </summary>
        /// <param name="host">host.</param>
        /// <param name="subnet">subnet.</param>
        /// <param name="ipv4">ipv4.</param>
        public Legacy2(
            int host,
            int subnet,
            Legacy2Ipv4 ipv4)
        {
            this.Host = host;
            this.Subnet = subnet;
            this.Ipv4 = ipv4;
        }

        /// <summary>
        /// Gets or sets Host.
        /// </summary>
        [JsonProperty("host")]
        public int Host { get; set; }

        /// <summary>
        /// Gets or sets Subnet.
        /// </summary>
        [JsonProperty("subnet")]
        public int Subnet { get; set; }

        /// <summary>
        /// Gets or sets Ipv4.
        /// </summary>
        [JsonProperty("ipv4")]
        public Legacy2Ipv4 Ipv4 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Legacy2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Legacy2 other &&                this.Host.Equals(other.Host) &&
                this.Subnet.Equals(other.Subnet) &&
                ((this.Ipv4 == null && other.Ipv4 == null) || (this.Ipv4?.Equals(other.Ipv4) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Host = {this.Host}");
            toStringOutput.Add($"this.Subnet = {this.Subnet}");
            toStringOutput.Add($"Ipv4 = {(this.Ipv4 == null ? "null" : this.Ipv4.ToString())}");
        }
    }
}
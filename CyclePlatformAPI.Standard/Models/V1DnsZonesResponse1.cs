// <copyright file="V1DnsZonesResponse1.cs" company="APIMatic">
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
    /// V1DnsZonesResponse1.
    /// </summary>
    public class V1DnsZonesResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesResponse1"/> class.
        /// </summary>
        public V1DnsZonesResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesResponse1"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1DnsZonesResponse1(
            Models.DNSZone data)
        {
            this.Data = data;
        }

        /// <summary>
        /// DNS (Domain Name System), in short, is a decentralized naming system for computers, services, or other resources connected to the internet or a private network. It is what allows the translation of a URL, such as http://example.com, to an IP address.
        /// </summary>
        [JsonProperty("data")]
        public Models.DNSZone Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1DnsZonesResponse1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1DnsZonesResponse1 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}
// <copyright file="IPNet.cs" company="APIMatic">
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
    /// IPNet.
    /// </summary>
    public class IPNet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPNet"/> class.
        /// </summary>
        public IPNet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPNet"/> class.
        /// </summary>
        /// <param name="ip">ip.</param>
        /// <param name="cidr">cidr.</param>
        public IPNet(
            string ip,
            string cidr)
        {
            this.Ip = ip;
            this.Cidr = cidr;
        }

        /// <summary>
        /// The IP address.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("ip")]
        [JsonRequired]
        public string Ip { get; set; }

        /// <summary>
        /// The CIDR notation, describing the range of IP addresses.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("cidr")]
        [JsonRequired]
        public string Cidr { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IPNet : ({string.Join(", ", toStringOutput)})";
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
            return obj is IPNet other &&                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
                ((this.Cidr == null && other.Cidr == null) || (this.Cidr?.Equals(other.Cidr) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip)}");
            toStringOutput.Add($"this.Cidr = {(this.Cidr == null ? "null" : this.Cidr)}");
        }
    }
}
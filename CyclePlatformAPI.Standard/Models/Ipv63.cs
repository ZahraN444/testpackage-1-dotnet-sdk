// <copyright file="Ipv63.cs" company="APIMatic">
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
    /// Ipv63.
    /// </summary>
    public class Ipv63
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ipv63"/> class.
        /// </summary>
        public Ipv63()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ipv63"/> class.
        /// </summary>
        /// <param name="ip">ip.</param>
        /// <param name="cidr">cidr.</param>
        public Ipv63(
            string ip,
            string cidr)
        {
            this.Ip = ip;
            this.Cidr = cidr;
        }

        /// <summary>
        /// The networks IPv6 base.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The private network CIDR.
        /// </summary>
        [JsonProperty("cidr")]
        public string Cidr { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ipv63 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ipv63 other &&                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
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
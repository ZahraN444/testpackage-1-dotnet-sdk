// <copyright file="Block.cs" company="APIMatic">
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
    /// Block.
    /// </summary>
    public class Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Block"/> class.
        /// </summary>
        public Block()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Block"/> class.
        /// </summary>
        /// <param name="cidr">cidr.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="netmask">netmask.</param>
        /// <param name="network">network.</param>
        public Block(
            string cidr,
            string gateway,
            string netmask,
            string network)
        {
            this.Cidr = cidr;
            this.Gateway = gateway;
            this.Netmask = netmask;
            this.Network = network;
        }

        /// <summary>
        /// A cidr for the pool.
        /// </summary>
        [JsonProperty("cidr")]
        public string Cidr { get; set; }

        /// <summary>
        /// A gateway for the pool.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// A netmask for the pool.
        /// </summary>
        [JsonProperty("netmask")]
        public string Netmask { get; set; }

        /// <summary>
        /// A network for the pool.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Block : ({string.Join(", ", toStringOutput)})";
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
            return obj is Block other &&                ((this.Cidr == null && other.Cidr == null) || (this.Cidr?.Equals(other.Cidr) == true)) &&
                ((this.Gateway == null && other.Gateway == null) || (this.Gateway?.Equals(other.Gateway) == true)) &&
                ((this.Netmask == null && other.Netmask == null) || (this.Netmask?.Equals(other.Netmask) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cidr = {(this.Cidr == null ? "null" : this.Cidr)}");
            toStringOutput.Add($"this.Gateway = {(this.Gateway == null ? "null" : this.Gateway)}");
            toStringOutput.Add($"this.Netmask = {(this.Netmask == null ? "null" : this.Netmask)}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network)}");
        }
    }
}
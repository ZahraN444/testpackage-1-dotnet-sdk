// <copyright file="ContainerNetwork.cs" company="APIMatic">
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
    /// ContainerNetwork.
    /// </summary>
    public class ContainerNetwork
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetwork"/> class.
        /// </summary>
        public ContainerNetwork()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerNetwork"/> class.
        /// </summary>
        /// <param name="mPublic">public.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="ports">ports.</param>
        public ContainerNetwork(
            Models.Public1Enum mPublic,
            string hostname,
            List<string> ports = null)
        {
            this.MPublic = mPublic;
            this.Hostname = hostname;
            this.Ports = ports;
        }

        /// <summary>
        /// The public network settings for the given container
        /// </summary>
        [JsonProperty("public")]
        public Models.Public1Enum MPublic { get; set; }

        /// <summary>
        /// The hostname for the given container.
        /// </summary>
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// An array of port mappings for the container.
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ports { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerNetwork : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerNetwork other &&                this.MPublic.Equals(other.MPublic) &&
                ((this.Hostname == null && other.Hostname == null) || (this.Hostname?.Equals(other.Hostname) == true)) &&
                ((this.Ports == null && other.Ports == null) || (this.Ports?.Equals(other.Ports) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MPublic = {this.MPublic}");
            toStringOutput.Add($"this.Hostname = {(this.Hostname == null ? "null" : this.Hostname)}");
            toStringOutput.Add($"this.Ports = {(this.Ports == null ? "null" : $"[{string.Join(", ", this.Ports)} ]")}");
        }
    }
}
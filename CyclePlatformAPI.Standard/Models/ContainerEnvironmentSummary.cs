// <copyright file="ContainerEnvironmentSummary.cs" company="APIMatic">
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
    /// ContainerEnvironmentSummary.
    /// </summary>
    public class ContainerEnvironmentSummary
    {
        private string containerSubnet;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "container_subnet", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerEnvironmentSummary"/> class.
        /// </summary>
        public ContainerEnvironmentSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerEnvironmentSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="legacy">legacy.</param>
        /// <param name="containerSubnet">container_subnet.</param>
        /// <param name="ipv6">ipv6.</param>
        public ContainerEnvironmentSummary(
            string id,
            string cluster,
            ContainerEnvironmentSummaryLegacy legacy,
            string containerSubnet = null,
            ContainerEnvironmentSummaryIpv6 ipv6 = null)
        {
            this.Id = id;
            this.Cluster = cluster;
            if (containerSubnet != null)
            {
                this.ContainerSubnet = containerSubnet;
            }

            this.Ipv6 = ipv6;
            this.Legacy = legacy;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The cluster this environment is associated with.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// The private network subnet ID for this container and its instances.
        /// </summary>
        [JsonProperty("container_subnet")]
        public string ContainerSubnet
        {
            get
            {
                return this.containerSubnet;
            }

            set
            {
                this.shouldSerialize["container_subnet"] = true;
                this.containerSubnet = value;
            }
        }

        /// <summary>
        /// Gets or sets Ipv6.
        /// </summary>
        [JsonProperty("ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerEnvironmentSummaryIpv6 Ipv6 { get; set; }

        /// <summary>
        /// Gets or sets Legacy.
        /// </summary>
        [JsonProperty("legacy")]
        public ContainerEnvironmentSummaryLegacy Legacy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerEnvironmentSummary : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContainerSubnet()
        {
            this.shouldSerialize["container_subnet"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContainerSubnet()
        {
            return this.shouldSerialize["container_subnet"];
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
            return obj is ContainerEnvironmentSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.ContainerSubnet == null && other.ContainerSubnet == null) || (this.ContainerSubnet?.Equals(other.ContainerSubnet) == true)) &&
                ((this.Ipv6 == null && other.Ipv6 == null) || (this.Ipv6?.Equals(other.Ipv6) == true)) &&
                ((this.Legacy == null && other.Legacy == null) || (this.Legacy?.Equals(other.Legacy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.ContainerSubnet = {(this.ContainerSubnet == null ? "null" : this.ContainerSubnet)}");
            toStringOutput.Add($"Ipv6 = {(this.Ipv6 == null ? "null" : this.Ipv6.ToString())}");
            toStringOutput.Add($"Legacy = {(this.Legacy == null ? "null" : this.Legacy.ToString())}");
        }
    }
}
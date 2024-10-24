// <copyright file="Index.cs" company="APIMatic">
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
    /// Index.
    /// </summary>
    public class Index
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Index"/> class.
        /// </summary>
        public Index()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Index"/> class.
        /// </summary>
        /// <param name="generated">generated.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="containers">containers.</param>
        /// <param name="environments">environments.</param>
        /// <param name="imageSources">image_sources.</param>
        /// <param name="dnsZones">dns_zones.</param>
        /// <param name="stacks">stacks.</param>
        /// <param name="servers">servers.</param>
        public Index(
            DateTime generated,
            string hubId,
            Dictionary<string, Models.IndexComponent> containers,
            Dictionary<string, Models.IndexComponent> environments,
            Dictionary<string, Models.IndexComponent> imageSources,
            Dictionary<string, Models.IndexComponent> dnsZones,
            Dictionary<string, Models.IndexComponent> stacks,
            Dictionary<string, Models.IndexComponent> servers)
        {
            this.Generated = generated;
            this.HubId = hubId;
            this.Containers = containers;
            this.Environments = environments;
            this.ImageSources = imageSources;
            this.DnsZones = dnsZones;
            this.Stacks = stacks;
            this.Servers = servers;
        }

        /// <summary>
        /// The timestampof when the index was generated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("generated")]
        public DateTime Generated { get; set; }

        /// <summary>
        /// Id describing the Hub
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// Gets or sets Containers.
        /// </summary>
        [JsonProperty("containers")]
        public Dictionary<string, Models.IndexComponent> Containers { get; set; }

        /// <summary>
        /// Gets or sets Environments.
        /// </summary>
        [JsonProperty("environments")]
        public Dictionary<string, Models.IndexComponent> Environments { get; set; }

        /// <summary>
        /// Gets or sets ImageSources.
        /// </summary>
        [JsonProperty("image_sources")]
        public Dictionary<string, Models.IndexComponent> ImageSources { get; set; }

        /// <summary>
        /// Gets or sets DnsZones.
        /// </summary>
        [JsonProperty("dns_zones")]
        public Dictionary<string, Models.IndexComponent> DnsZones { get; set; }

        /// <summary>
        /// Gets or sets Stacks.
        /// </summary>
        [JsonProperty("stacks")]
        public Dictionary<string, Models.IndexComponent> Stacks { get; set; }

        /// <summary>
        /// Gets or sets Servers.
        /// </summary>
        [JsonProperty("servers")]
        public Dictionary<string, Models.IndexComponent> Servers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Index : ({string.Join(", ", toStringOutput)})";
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
            return obj is Index other &&                this.Generated.Equals(other.Generated) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true)) &&
                ((this.ImageSources == null && other.ImageSources == null) || (this.ImageSources?.Equals(other.ImageSources) == true)) &&
                ((this.DnsZones == null && other.DnsZones == null) || (this.DnsZones?.Equals(other.DnsZones) == true)) &&
                ((this.Stacks == null && other.Stacks == null) || (this.Stacks?.Equals(other.Stacks) == true)) &&
                ((this.Servers == null && other.Servers == null) || (this.Servers?.Equals(other.Servers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Generated = {this.Generated}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"Environments = {(this.Environments == null ? "null" : this.Environments.ToString())}");
            toStringOutput.Add($"ImageSources = {(this.ImageSources == null ? "null" : this.ImageSources.ToString())}");
            toStringOutput.Add($"DnsZones = {(this.DnsZones == null ? "null" : this.DnsZones.ToString())}");
            toStringOutput.Add($"Stacks = {(this.Stacks == null ? "null" : this.Stacks.ToString())}");
            toStringOutput.Add($"Servers = {(this.Servers == null ? "null" : this.Servers.ToString())}");
        }
    }
}
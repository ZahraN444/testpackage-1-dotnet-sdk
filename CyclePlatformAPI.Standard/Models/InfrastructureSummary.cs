// <copyright file="InfrastructureSummary.cs" company="APIMatic">
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
    /// InfrastructureSummary.
    /// </summary>
    public class InfrastructureSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureSummary"/> class.
        /// </summary>
        public InfrastructureSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureSummary"/> class.
        /// </summary>
        /// <param name="hubId">hub_id.</param>
        /// <param name="servers">servers.</param>
        /// <param name="images">images.</param>
        /// <param name="clusters">clusters.</param>
        /// <param name="updated">updated.</param>
        public InfrastructureSummary(
            string hubId,
            double servers,
            Models.Images images,
            Dictionary<string, Models.Clusters> clusters,
            DateTime updated)
        {
            this.HubId = hubId;
            this.Servers = servers;
            this.Images = images;
            this.Clusters = clusters;
            this.Updated = updated;
        }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// The number of servers on the cluster
        /// </summary>
        [JsonProperty("servers")]
        public double Servers { get; set; }

        /// <summary>
        /// Statistics about image usage.
        /// </summary>
        [JsonProperty("images")]
        public Models.Images Images { get; set; }

        /// <summary>
        /// Records pointing to information about clusters that make up this hubs infrastructure.
        /// </summary>
        [JsonProperty("clusters")]
        public Dictionary<string, Models.Clusters> Clusters { get; set; }

        /// <summary>
        /// A timestamp of when the infrastructure was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InfrastructureSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is InfrastructureSummary other &&                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                this.Servers.Equals(other.Servers) &&
                ((this.Images == null && other.Images == null) || (this.Images?.Equals(other.Images) == true)) &&
                ((this.Clusters == null && other.Clusters == null) || (this.Clusters?.Equals(other.Clusters) == true)) &&
                this.Updated.Equals(other.Updated);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Servers = {this.Servers}");
            toStringOutput.Add($"this.Images = {(this.Images == null ? "null" : this.Images.ToString())}");
            toStringOutput.Add($"Clusters = {(this.Clusters == null ? "null" : this.Clusters.ToString())}");
            toStringOutput.Add($"this.Updated = {this.Updated}");
        }
    }
}
// <copyright file="AutoScaleGroup.cs" company="APIMatic">
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
    /// AutoScaleGroup.
    /// </summary>
    public class AutoScaleGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroup"/> class.
        /// </summary>
        public AutoScaleGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroup"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="infrastructure">infrastructure.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="scale">scale.</param>
        public AutoScaleGroup(
            string id,
            string name,
            string identifier,
            Models.CreatorScope creator,
            string hubId,
            string cluster,
            Models.AutoScaleGroupInfrastructure infrastructure,
            Models.AutoScaleGroupState state,
            Models.AutoScaleGroupEvents events,
            Models.AutoScaleGroupScale scale = null)
        {
            this.Id = id;
            this.Name = name;
            this.Identifier = identifier;
            this.Creator = creator;
            this.HubId = hubId;
            this.Cluster = cluster;
            this.Scale = scale;
            this.Infrastructure = infrastructure;
            this.State = state;
            this.Events = events;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// Gets or sets HubId.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("cluster")]
        [JsonRequired]
        public string Cluster { get; set; }

        /// <summary>
        /// Gets or sets Scale.
        /// </summary>
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AutoScaleGroupScale Scale { get; set; }

        /// <summary>
        /// Gets or sets Infrastructure.
        /// </summary>
        [JsonProperty("infrastructure")]
        [JsonRequired]
        public Models.AutoScaleGroupInfrastructure Infrastructure { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.AutoScaleGroupState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the auto-scale group's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.AutoScaleGroupEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoScaleGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoScaleGroup other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Scale == null && other.Scale == null) || (this.Scale?.Equals(other.Scale) == true)) &&
                ((this.Infrastructure == null && other.Infrastructure == null) || (this.Infrastructure?.Equals(other.Infrastructure) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Scale = {(this.Scale == null ? "null" : this.Scale.ToString())}");
            toStringOutput.Add($"this.Infrastructure = {(this.Infrastructure == null ? "null" : this.Infrastructure.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
// <copyright file="Server.cs" company="APIMatic">
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
    /// Server.
    /// </summary>
    public class Server
    {
        private Models.Autoscale1 autoscale;
        private Models.Evacuate evacuate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "autoscale", false },
            { "evacuate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="modelId">model_id.</param>
        /// <param name="nodeId">node_id.</param>
        /// <param name="sharedFileSystems">shared_file_systems.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="creator">creator.</param>
        /// <param name="provider">provider.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="features">features.</param>
        /// <param name="constraints">constraints.</param>
        /// <param name="ephemeral">ephemeral.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="autoscale">autoscale.</param>
        /// <param name="evacuate">evacuate.</param>
        /// <param name="meta">meta.</param>
        public Server(
            string id,
            string hubId,
            string locationId,
            string modelId,
            string nodeId,
            Models.ServerSharedFileSystems sharedFileSystems,
            string hostname,
            Models.CreatorScope creator,
            Models.ServerProvider provider,
            string cluster,
            Models.ServerFeatures features,
            Models.ServerConstraints constraints,
            bool ephemeral,
            Models.ServerState state,
            Models.ServerEvents events,
            Models.Autoscale1 autoscale = null,
            Models.Evacuate evacuate = null,
            Models.ServerMeta meta = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.LocationId = locationId;
            this.ModelId = modelId;
            this.NodeId = nodeId;
            this.SharedFileSystems = sharedFileSystems;
            this.Hostname = hostname;
            this.Creator = creator;
            this.Provider = provider;
            this.Cluster = cluster;
            this.Features = features;
            this.Constraints = constraints;
            if (autoscale != null)
            {
                this.Autoscale = autoscale;
            }

            this.Ephemeral = ephemeral;
            if (evacuate != null)
            {
                this.Evacuate = evacuate;
            }

            this.State = state;
            this.Events = events;
            this.Meta = meta;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// An identifier for the location this server is deployed to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("location_id")]
        [JsonRequired]
        public string LocationId { get; set; }

        /// <summary>
        /// An identifier for the model of server that is deployed.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("model_id")]
        [JsonRequired]
        public string ModelId { get; set; }

        /// <summary>
        /// An identifier for the node.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("node_id")]
        [JsonRequired]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets SharedFileSystems.
        /// </summary>
        [JsonProperty("shared_file_systems")]
        [JsonRequired]
        public Models.ServerSharedFileSystems SharedFileSystems { get; set; }

        /// <summary>
        /// The server hostname.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hostname")]
        [JsonRequired]
        public string Hostname { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// A resource regarding the provider a given server is deployed from.
        /// </summary>
        [JsonProperty("provider")]
        [JsonRequired]
        public Models.ServerProvider Provider { get; set; }

        /// <summary>
        /// The cluster the given server is deployed to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("cluster")]
        [JsonRequired]
        public string Cluster { get; set; }

        /// <summary>
        /// A set of features a given server can have and their information.
        /// </summary>
        [JsonProperty("features")]
        [JsonRequired]
        public Models.ServerFeatures Features { get; set; }

        /// <summary>
        /// Constraints to apply to the server.
        /// </summary>
        [JsonProperty("constraints")]
        [JsonRequired]
        public Models.ServerConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets Autoscale.
        /// </summary>
        [JsonProperty("autoscale")]
        public Models.Autoscale1 Autoscale
        {
            get
            {
                return this.autoscale;
            }

            set
            {
                this.shouldSerialize["autoscale"] = true;
                this.autoscale = value;
            }
        }

        /// <summary>
        /// Set to true when a server is created as part of an auto-scale event.
        /// </summary>
        [JsonProperty("ephemeral")]
        [JsonRequired]
        public bool Ephemeral { get; set; }

        /// <summary>
        /// Details about a server's evacuation status. When an evacuation is in progress, no new container instances will be permitted on the server.
        /// </summary>
        [JsonProperty("evacuate")]
        public Models.Evacuate Evacuate
        {
            get
            {
                return this.evacuate;
            }

            set
            {
                this.shouldSerialize["evacuate"] = true;
                this.evacuate = value;
            }
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ServerState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the server's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.ServerEvents Events { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to a server.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServerMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Server : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAutoscale()
        {
            this.shouldSerialize["autoscale"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEvacuate()
        {
            this.shouldSerialize["evacuate"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutoscale()
        {
            return this.shouldSerialize["autoscale"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEvacuate()
        {
            return this.shouldSerialize["evacuate"];
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
            return obj is Server other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.ModelId == null && other.ModelId == null) || (this.ModelId?.Equals(other.ModelId) == true)) &&
                ((this.NodeId == null && other.NodeId == null) || (this.NodeId?.Equals(other.NodeId) == true)) &&
                ((this.SharedFileSystems == null && other.SharedFileSystems == null) || (this.SharedFileSystems?.Equals(other.SharedFileSystems) == true)) &&
                ((this.Hostname == null && other.Hostname == null) || (this.Hostname?.Equals(other.Hostname) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.Constraints == null && other.Constraints == null) || (this.Constraints?.Equals(other.Constraints) == true)) &&
                ((this.Autoscale == null && other.Autoscale == null) || (this.Autoscale?.Equals(other.Autoscale) == true)) &&
                this.Ephemeral.Equals(other.Ephemeral) &&
                ((this.Evacuate == null && other.Evacuate == null) || (this.Evacuate?.Equals(other.Evacuate) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.ModelId = {(this.ModelId == null ? "null" : this.ModelId)}");
            toStringOutput.Add($"this.NodeId = {(this.NodeId == null ? "null" : this.NodeId)}");
            toStringOutput.Add($"this.SharedFileSystems = {(this.SharedFileSystems == null ? "null" : this.SharedFileSystems.ToString())}");
            toStringOutput.Add($"this.Hostname = {(this.Hostname == null ? "null" : this.Hostname)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
            toStringOutput.Add($"this.Constraints = {(this.Constraints == null ? "null" : this.Constraints.ToString())}");
            toStringOutput.Add($"this.Autoscale = {(this.Autoscale == null ? "null" : this.Autoscale.ToString())}");
            toStringOutput.Add($"this.Ephemeral = {this.Ephemeral}");
            toStringOutput.Add($"this.Evacuate = {(this.Evacuate == null ? "null" : this.Evacuate.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}
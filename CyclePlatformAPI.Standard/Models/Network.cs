// <copyright file="Network.cs" company="APIMatic">
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
    /// Network.
    /// </summary>
    public class Network
    {
        private List<Models.Environment3> environments;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "environments", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Network"/> class.
        /// </summary>
        public Network()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Network"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="privateNetwork">private_network.</param>
        /// <param name="environments">environments.</param>
        public Network(
            string id,
            string name,
            string identifier,
            string cluster,
            Models.CreatorScope creator,
            string hubId,
            Models.NetworkState state,
            Models.NetworkEvents events,
            NetworkPrivateNetwork privateNetwork = null,
            List<Models.Environment3> environments = null)
        {
            this.Id = id;
            this.Name = name;
            this.Identifier = identifier;
            this.Cluster = cluster;
            this.Creator = creator;
            this.HubId = hubId;
            this.State = state;
            this.PrivateNetwork = privateNetwork;
            if (environments != null)
            {
                this.Environments = environments;
            }

            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// The name of the network.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// A network identifier used to construct http calls that specifically use this network over another.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// The infrastructure cluster the environments belonging to this network belong to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("cluster")]
        [JsonRequired]
        public string Cluster { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.NetworkState State { get; set; }

        /// <summary>
        /// Gets or sets PrivateNetwork.
        /// </summary>
        [JsonProperty("private_network", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkPrivateNetwork PrivateNetwork { get; set; }

        /// <summary>
        /// An array of environments and timestamps.
        /// </summary>
        [JsonProperty("environments")]
        public List<Models.Environment3> Environments
        {
            get
            {
                return this.environments;
            }

            set
            {
                this.shouldSerialize["environments"] = true;
                this.environments = value;
            }
        }

        /// <summary>
        /// A collection of timestamps for each event in the network's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.NetworkEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Network : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEnvironments()
        {
            this.shouldSerialize["environments"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEnvironments()
        {
            return this.shouldSerialize["environments"];
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
            return obj is Network other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.PrivateNetwork == null && other.PrivateNetwork == null) || (this.PrivateNetwork?.Equals(other.PrivateNetwork) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true)) &&
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
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"PrivateNetwork = {(this.PrivateNetwork == null ? "null" : this.PrivateNetwork.ToString())}");
            toStringOutput.Add($"this.Environments = {(this.Environments == null ? "null" : $"[{string.Join(", ", this.Environments)} ]")}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
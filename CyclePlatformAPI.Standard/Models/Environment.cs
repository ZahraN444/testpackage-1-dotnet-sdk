// <copyright file="Environment.cs" company="APIMatic">
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
    /// Environment.
    /// </summary>
    public class Environment
    {
        private Models.Deployments deployments;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "deployments", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        public Environment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="name">name.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="about">about.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="features">features.</param>
        /// <param name="services">services.</param>
        /// <param name="privateNetwork">private_network.</param>
        /// <param name="deployments">deployments.</param>
        /// <param name="meta">meta.</param>
        public Environment(
            string id,
            string identifier,
            string name,
            string cluster,
            Models.EnvironmentAbout about,
            Models.CreatorScope creator,
            string hubId,
            Models.EnvironmentState state,
            Models.EnvironmentEvents events,
            Models.Features features,
            Models.EnvironmentServices services,
            EnvironmentPrivateNetwork privateNetwork = null,
            Models.Deployments deployments = null,
            Models.EnvironmentMeta meta = null)
        {
            this.Id = id;
            this.Identifier = identifier;
            this.Name = name;
            this.Cluster = cluster;
            this.About = about;
            this.Creator = creator;
            this.HubId = hubId;
            this.State = state;
            this.Events = events;
            this.Features = features;
            this.Services = services;
            this.PrivateNetwork = privateNetwork;
            if (deployments != null)
            {
                this.Deployments = deployments;
            }

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
        /// A human readable slugged identifier for this environment.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// A user defined name for the environment resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The cluster this environment is associated with.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("cluster")]
        [JsonRequired]
        public string Cluster { get; set; }

        /// <summary>
        /// Contains details regarding the environment.
        /// </summary>
        [JsonProperty("about")]
        [JsonRequired]
        public Models.EnvironmentAbout About { get; set; }

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
        public Models.EnvironmentState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the environment's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.EnvironmentEvents Events { get; set; }

        /// <summary>
        /// An object representing specialized features configured for this environment.
        /// </summary>
        [JsonProperty("features")]
        [JsonRequired]
        public Models.Features Features { get; set; }

        /// <summary>
        /// Service containers run by this environment and their configurations.
        /// </summary>
        [JsonProperty("services")]
        [JsonRequired]
        public Models.EnvironmentServices Services { get; set; }

        /// <summary>
        /// Gets or sets PrivateNetwork.
        /// </summary>
        [JsonProperty("private_network", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentPrivateNetwork PrivateNetwork { get; set; }

        /// <summary>
        /// A map of custom tags to deployment versions.
        /// </summary>
        [JsonProperty("deployments")]
        public Models.Deployments Deployments
        {
            get
            {
                return this.deployments;
            }

            set
            {
                this.shouldSerialize["deployments"] = true;
                this.deployments = value;
            }
        }

        /// <summary>
        /// A list of meta fields that can be applied to this environment.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnvironmentMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Environment : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeployments()
        {
            this.shouldSerialize["deployments"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeployments()
        {
            return this.shouldSerialize["deployments"];
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
            return obj is Environment other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.Services == null && other.Services == null) || (this.Services?.Equals(other.Services) == true)) &&
                ((this.PrivateNetwork == null && other.PrivateNetwork == null) || (this.PrivateNetwork?.Equals(other.PrivateNetwork) == true)) &&
                ((this.Deployments == null && other.Deployments == null) || (this.Deployments?.Equals(other.Deployments) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
            toStringOutput.Add($"this.Services = {(this.Services == null ? "null" : this.Services.ToString())}");
            toStringOutput.Add($"PrivateNetwork = {(this.PrivateNetwork == null ? "null" : this.PrivateNetwork.ToString())}");
            toStringOutput.Add($"this.Deployments = {(this.Deployments == null ? "null" : this.Deployments.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}
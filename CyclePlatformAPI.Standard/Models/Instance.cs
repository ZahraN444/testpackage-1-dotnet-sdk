// <copyright file="Instance.cs" company="APIMatic">
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
    /// Instance.
    /// </summary>
    public class Instance
    {
        private Models.Stateful2 stateful;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "stateful", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Instance"/> class.
        /// </summary>
        public Instance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Instance"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="environment">environment.</param>
        /// <param name="provider">provider.</param>
        /// <param name="serverId">server_id.</param>
        /// <param name="readyState">ready_state.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="stateful">stateful.</param>
        /// <param name="function">function.</param>
        /// <param name="purgeTime">purge_time.</param>
        /// <param name="service">service.</param>
        /// <param name="autoscale">autoscale.</param>
        /// <param name="migration">migration.</param>
        /// <param name="deployment">deployment.</param>
        public Instance(
            string id,
            Models.CreatorScope creator,
            string hubId,
            string containerId,
            string locationId,
            Models.EnvironmentNetworkSummary environment,
            Models.InstanceProvider provider,
            string serverId,
            Models.ReadyStateEnum readyState,
            string hostname,
            Models.InstanceState state,
            Models.InstanceEvents events,
            Models.Stateful2 stateful = null,
            Models.Function function = null,
            InstancePurgeTime purgeTime = null,
            Models.ServiceContainerIdentifier1Enum? service = null,
            InstanceAutoscale autoscale = null,
            InstanceMigration2 migration = null,
            InstanceDeployment deployment = null)
        {
            this.Id = id;
            this.Creator = creator;
            this.HubId = hubId;
            this.ContainerId = containerId;
            this.LocationId = locationId;
            this.Environment = environment;
            if (stateful != null)
            {
                this.Stateful = stateful;
            }

            this.Function = function;
            this.Provider = provider;
            this.ServerId = serverId;
            this.ReadyState = readyState;
            this.PurgeTime = purgeTime;
            this.Hostname = hostname;
            this.Service = service;
            this.State = state;
            this.Autoscale = autoscale;
            this.Migration = migration;
            this.Deployment = deployment;
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
        /// A container identifier for the container that is associated with this instance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("container_id")]
        [JsonRequired]
        public string ContainerId { get; set; }

        /// <summary>
        /// A location identifier that's associated with the server this instance is deployed to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("location_id")]
        [JsonRequired]
        public string LocationId { get; set; }

        /// <summary>
        /// Details about the environment network this instance is a member of.
        /// </summary>
        [JsonProperty("environment")]
        [JsonRequired]
        public Models.EnvironmentNetworkSummary Environment { get; set; }

        /// <summary>
        /// If the instance is stateful, additional details relating to its stateful properties.
        /// </summary>
        [JsonProperty("stateful")]
        public Models.Stateful2 Stateful
        {
            get
            {
                return this.stateful;
            }

            set
            {
                this.shouldSerialize["stateful"] = true;
                this.stateful = value;
            }
        }

        /// <summary>
        /// If the instance is a function, additional details relating to its function properties
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Function Function { get; set; }

        /// <summary>
        /// Gets or sets Provider.
        /// </summary>
        [JsonProperty("provider")]
        [JsonRequired]
        public Models.InstanceProvider Provider { get; set; }

        /// <summary>
        /// An identifier for the server this instance is deployed to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("server_id")]
        [JsonRequired]
        public string ServerId { get; set; }

        /// <summary>
        /// The state as it relates to the following. * `active` - instance can be started or stopped. * `purge` - instance should be deleted. * `hibernate` - instance is active but not allowed to run. * `configuring` - this instance is not allowed to start yet
        /// </summary>
        [JsonProperty("ready_state")]
        [JsonRequired]
        public Models.ReadyStateEnum ReadyState { get; set; }

        /// <summary>
        /// The timestamp of when the instance was purged.
        /// </summary>
        [JsonProperty("purge_time", NullValueHandling = NullValueHandling.Ignore)]
        public InstancePurgeTime PurgeTime { get; set; }

        /// <summary>
        /// The hostname of the instance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hostname")]
        [JsonRequired]
        public string Hostname { get; set; }

        /// <summary>
        /// The type of service this instance is within the environment, if any.
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceContainerIdentifier1Enum? Service { get; set; }

        /// <summary>
        /// Information about the state of an instance.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.InstanceState State { get; set; }

        /// <summary>
        /// Gets or sets Autoscale.
        /// </summary>
        [JsonProperty("autoscale", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceAutoscale Autoscale { get; set; }

        /// <summary>
        /// Gets or sets Migration.
        /// </summary>
        [JsonProperty("migration", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceMigration2 Migration { get; set; }

        /// <summary>
        /// Gets or sets Deployment.
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceDeployment Deployment { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the instnaces lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.InstanceEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Instance : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStateful()
        {
            this.shouldSerialize["stateful"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStateful()
        {
            return this.shouldSerialize["stateful"];
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
            return obj is Instance other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.Stateful == null && other.Stateful == null) || (this.Stateful?.Equals(other.Stateful) == true)) &&
                ((this.Function == null && other.Function == null) || (this.Function?.Equals(other.Function) == true)) &&
                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                this.ReadyState.Equals(other.ReadyState) &&
                ((this.PurgeTime == null && other.PurgeTime == null) || (this.PurgeTime?.Equals(other.PurgeTime) == true)) &&
                ((this.Hostname == null && other.Hostname == null) || (this.Hostname?.Equals(other.Hostname) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Autoscale == null && other.Autoscale == null) || (this.Autoscale?.Equals(other.Autoscale) == true)) &&
                ((this.Migration == null && other.Migration == null) || (this.Migration?.Equals(other.Migration) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment.ToString())}");
            toStringOutput.Add($"this.Stateful = {(this.Stateful == null ? "null" : this.Stateful.ToString())}");
            toStringOutput.Add($"this.Function = {(this.Function == null ? "null" : this.Function.ToString())}");
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.ReadyState = {this.ReadyState}");
            toStringOutput.Add($"PurgeTime = {(this.PurgeTime == null ? "null" : this.PurgeTime.ToString())}");
            toStringOutput.Add($"this.Hostname = {(this.Hostname == null ? "null" : this.Hostname)}");
            toStringOutput.Add($"this.Service = {(this.Service == null ? "null" : this.Service.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"Autoscale = {(this.Autoscale == null ? "null" : this.Autoscale.ToString())}");
            toStringOutput.Add($"Migration = {(this.Migration == null ? "null" : this.Migration.ToString())}");
            toStringOutput.Add($"Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
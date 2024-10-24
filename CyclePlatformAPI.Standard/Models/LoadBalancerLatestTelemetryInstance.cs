// <copyright file="LoadBalancerLatestTelemetryInstance.cs" company="APIMatic">
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
    /// LoadBalancerLatestTelemetryInstance.
    /// </summary>
    public class LoadBalancerLatestTelemetryInstance
    {
        private List<Models.LoadBalancerTelemetrySnapshot> snapshots;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "snapshots", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestTelemetryInstance"/> class.
        /// </summary>
        public LoadBalancerLatestTelemetryInstance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestTelemetryInstance"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="serverId">server_id.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="time">time.</param>
        /// <param name="controller">controller.</param>
        /// <param name="latest">latest.</param>
        /// <param name="snapshots">snapshots.</param>
        public LoadBalancerLatestTelemetryInstance(
            string id,
            string hubId,
            string environmentId,
            string containerId,
            string instanceId,
            string serverId,
            string cluster,
            DateTime time,
            string controller,
            LoadBalancerLatestTelemetryInstanceLatest latest = null,
            List<Models.LoadBalancerTelemetrySnapshot> snapshots = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.EnvironmentId = environmentId;
            this.ContainerId = containerId;
            this.InstanceId = instanceId;
            this.ServerId = serverId;
            this.Cluster = cluster;
            this.Time = time;
            this.Controller = controller;
            this.Latest = latest;
            if (snapshots != null)
            {
                this.Snapshots = snapshots;
            }

        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("server_id")]
        public string ServerId { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("controller")]
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets Latest.
        /// </summary>
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public LoadBalancerLatestTelemetryInstanceLatest Latest { get; set; }

        /// <summary>
        /// Gets or sets Snapshots.
        /// </summary>
        [JsonProperty("snapshots")]
        public List<Models.LoadBalancerTelemetrySnapshot> Snapshots
        {
            get
            {
                return this.snapshots;
            }

            set
            {
                this.shouldSerialize["snapshots"] = true;
                this.snapshots = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerLatestTelemetryInstance : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSnapshots()
        {
            this.shouldSerialize["snapshots"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSnapshots()
        {
            return this.shouldSerialize["snapshots"];
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
            return obj is LoadBalancerLatestTelemetryInstance other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                this.Time.Equals(other.Time) &&
                ((this.Controller == null && other.Controller == null) || (this.Controller?.Equals(other.Controller) == true)) &&
                ((this.Latest == null && other.Latest == null) || (this.Latest?.Equals(other.Latest) == true)) &&
                ((this.Snapshots == null && other.Snapshots == null) || (this.Snapshots?.Equals(other.Snapshots) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Controller = {(this.Controller == null ? "null" : this.Controller)}");
            toStringOutput.Add($"Latest = {(this.Latest == null ? "null" : this.Latest.ToString())}");
            toStringOutput.Add($"this.Snapshots = {(this.Snapshots == null ? "null" : $"[{string.Join(", ", this.Snapshots)} ]")}");
        }
    }
}
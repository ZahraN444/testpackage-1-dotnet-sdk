// <copyright file="InstanceTelemetryResourceSnapshot.cs" company="APIMatic">
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
    /// InstanceTelemetryResourceSnapshot.
    /// </summary>
    public class InstanceTelemetryResourceSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryResourceSnapshot"/> class.
        /// </summary>
        public InstanceTelemetryResourceSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryResourceSnapshot"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="cpu">cpu.</param>
        /// <param name="memory">memory.</param>
        /// <param name="processes">processes.</param>
        /// <param name="network">network.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="serverId">server_id.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="hugetlb">hugetlb.</param>
        public InstanceTelemetryResourceSnapshot(
            DateTime time,
            Models.InstanceTelemetryCPUSnapshot cpu,
            Models.InstanceTelemetryMemorySnapshot memory,
            Models.InstanceTelemetryProcessesSnapshot processes,
            Models.InstanceTelemetryNetworkSnapshot network,
            InstanceTelemetryResourceSnapshotHubId hubId = null,
            InstanceTelemetryResourceSnapshotContainerId containerId = null,
            InstanceTelemetryResourceSnapshotInstanceId instanceId = null,
            InstanceTelemetryResourceSnapshotEnvironmentId environmentId = null,
            InstanceTelemetryResourceSnapshotServerId serverId = null,
            InstanceTelemetryResourceSnapshotCluster cluster = null,
            Models.HugeTLB hugetlb = null)
        {
            this.Time = time;
            this.HubId = hubId;
            this.ContainerId = containerId;
            this.InstanceId = instanceId;
            this.EnvironmentId = environmentId;
            this.ServerId = serverId;
            this.Cluster = cluster;
            this.Cpu = cpu;
            this.Memory = memory;
            this.Processes = processes;
            this.Network = network;
            this.Hugetlb = hugetlb;
        }

        /// <summary>
        /// A timestamp of the time this snapshot was captured at.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets HubId.
        /// </summary>
        [JsonProperty("hub_id", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTelemetryResourceSnapshotHubId HubId { get; set; }

        /// <summary>
        /// Gets or sets ContainerId.
        /// </summary>
        [JsonProperty("container_id", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTelemetryResourceSnapshotContainerId ContainerId { get; set; }

        /// <summary>
        /// Gets or sets InstanceId.
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTelemetryResourceSnapshotInstanceId InstanceId { get; set; }

        /// <summary>
        /// Gets or sets EnvironmentId.
        /// </summary>
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTelemetryResourceSnapshotEnvironmentId EnvironmentId { get; set; }

        /// <summary>
        /// Gets or sets ServerId.
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTelemetryResourceSnapshotServerId ServerId { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonProperty("cluster", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTelemetryResourceSnapshotCluster Cluster { get; set; }

        /// <summary>
        /// A telemetry snapshot pertaining to CPU usage.
        /// </summary>
        [JsonProperty("cpu")]
        public Models.InstanceTelemetryCPUSnapshot Cpu { get; set; }

        /// <summary>
        /// A snapshot of memory usage statistics.
        /// </summary>
        [JsonProperty("memory")]
        public Models.InstanceTelemetryMemorySnapshot Memory { get; set; }

        /// <summary>
        /// Process information for a given snapshot.
        /// </summary>
        [JsonProperty("processes")]
        public Models.InstanceTelemetryProcessesSnapshot Processes { get; set; }

        /// <summary>
        /// A snapshot of network usage statistics.
        /// </summary>
        [JsonProperty("network")]
        public Models.InstanceTelemetryNetworkSnapshot Network { get; set; }

        /// <summary>
        /// HugeTLB data.
        /// </summary>
        [JsonProperty("hugetlb", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HugeTLB Hugetlb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryResourceSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryResourceSnapshot other &&                this.Time.Equals(other.Time) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Cpu == null && other.Cpu == null) || (this.Cpu?.Equals(other.Cpu) == true)) &&
                ((this.Memory == null && other.Memory == null) || (this.Memory?.Equals(other.Memory) == true)) &&
                ((this.Processes == null && other.Processes == null) || (this.Processes?.Equals(other.Processes) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Hugetlb == null && other.Hugetlb == null) || (this.Hugetlb?.Equals(other.Hugetlb) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"HubId = {(this.HubId == null ? "null" : this.HubId.ToString())}");
            toStringOutput.Add($"ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId.ToString())}");
            toStringOutput.Add($"InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId.ToString())}");
            toStringOutput.Add($"EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId.ToString())}");
            toStringOutput.Add($"ServerId = {(this.ServerId == null ? "null" : this.ServerId.ToString())}");
            toStringOutput.Add($"Cluster = {(this.Cluster == null ? "null" : this.Cluster.ToString())}");
            toStringOutput.Add($"this.Cpu = {(this.Cpu == null ? "null" : this.Cpu.ToString())}");
            toStringOutput.Add($"this.Memory = {(this.Memory == null ? "null" : this.Memory.ToString())}");
            toStringOutput.Add($"this.Processes = {(this.Processes == null ? "null" : this.Processes.ToString())}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"this.Hugetlb = {(this.Hugetlb == null ? "null" : this.Hugetlb.ToString())}");
        }
    }
}
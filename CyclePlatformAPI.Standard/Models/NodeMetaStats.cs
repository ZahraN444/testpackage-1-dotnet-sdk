// <copyright file="NodeMetaStats.cs" company="APIMatic">
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
    /// NodeMetaStats.
    /// </summary>
    public class NodeMetaStats
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMetaStats"/> class.
        /// </summary>
        public NodeMetaStats()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMetaStats"/> class.
        /// </summary>
        /// <param name="network">network.</param>
        /// <param name="uptime">uptime.</param>
        /// <param name="cpu">cpu.</param>
        /// <param name="load">load.</param>
        /// <param name="ram">ram.</param>
        /// <param name="storage">storage.</param>
        /// <param name="os">os.</param>
        /// <param name="versions">versions.</param>
        public NodeMetaStats(
            Models.ServerStatsNetwork network,
            Models.ServerStatsUptime uptime,
            Models.ServerStatsCpu cpu,
            Models.ServerStatsLoad load,
            Models.ServerStatsRam ram,
            Models.ServerStatsStorage storage,
            Models.ServerStatsOS os,
            Models.ServerStatsVersions versions)
        {
            this.Network = network;
            this.Uptime = uptime;
            this.Cpu = cpu;
            this.Load = load;
            this.Ram = ram;
            this.Storage = storage;
            this.Os = os;
            this.Versions = versions;
        }

        /// <summary>
        /// Statistics about the networks on a given server.
        /// </summary>
        [JsonProperty("network")]
        public Models.ServerStatsNetwork Network { get; set; }

        /// <summary>
        /// Statistics describing the uptime of a given server.
        /// </summary>
        [JsonProperty("uptime")]
        public Models.ServerStatsUptime Uptime { get; set; }

        /// <summary>
        /// Statistics about the CPU resources on a server.
        /// </summary>
        [JsonProperty("cpu")]
        public Models.ServerStatsCpu Cpu { get; set; }

        /// <summary>
        /// Statistics about the current load on the server.
        /// </summary>
        [JsonProperty("load")]
        public Models.ServerStatsLoad Load { get; set; }

        /// <summary>
        /// Statistics about the RAM on a given server.
        /// </summary>
        [JsonProperty("ram")]
        public Models.ServerStatsRam Ram { get; set; }

        /// <summary>
        /// Statistics about storage for a given server.
        /// </summary>
        [JsonProperty("storage")]
        public Models.ServerStatsStorage Storage { get; set; }

        /// <summary>
        /// Statistics about the operating system installed on the server (CycleOS).
        /// </summary>
        [JsonProperty("os")]
        public Models.ServerStatsOS Os { get; set; }

        /// <summary>
        /// Information about the versions of Cycle services on a given server.
        /// </summary>
        [JsonProperty("versions")]
        public Models.ServerStatsVersions Versions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeMetaStats : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeMetaStats other &&                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Uptime == null && other.Uptime == null) || (this.Uptime?.Equals(other.Uptime) == true)) &&
                ((this.Cpu == null && other.Cpu == null) || (this.Cpu?.Equals(other.Cpu) == true)) &&
                ((this.Load == null && other.Load == null) || (this.Load?.Equals(other.Load) == true)) &&
                ((this.Ram == null && other.Ram == null) || (this.Ram?.Equals(other.Ram) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.Os == null && other.Os == null) || (this.Os?.Equals(other.Os) == true)) &&
                ((this.Versions == null && other.Versions == null) || (this.Versions?.Equals(other.Versions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"this.Uptime = {(this.Uptime == null ? "null" : this.Uptime.ToString())}");
            toStringOutput.Add($"this.Cpu = {(this.Cpu == null ? "null" : this.Cpu.ToString())}");
            toStringOutput.Add($"this.Load = {(this.Load == null ? "null" : this.Load.ToString())}");
            toStringOutput.Add($"this.Ram = {(this.Ram == null ? "null" : this.Ram.ToString())}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage.ToString())}");
            toStringOutput.Add($"this.Os = {(this.Os == null ? "null" : this.Os.ToString())}");
            toStringOutput.Add($"this.Versions = {(this.Versions == null ? "null" : this.Versions.ToString())}");
        }
    }
}
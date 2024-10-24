// <copyright file="ServerStatsTelemetry.cs" company="APIMatic">
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
    /// ServerStatsTelemetry.
    /// </summary>
    public class ServerStatsTelemetry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsTelemetry"/> class.
        /// </summary>
        public ServerStatsTelemetry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsTelemetry"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="load">load.</param>
        /// <param name="ram">ram.</param>
        /// <param name="storageBase">storage_base.</param>
        /// <param name="storagePool">storage_pool.</param>
        /// <param name="cpuUsage">cpu_usage.</param>
        public ServerStatsTelemetry(
            DateTime time,
            Models.ServerStatsLoad load,
            Models.ServerStatsRamTelemetry ram,
            Models.StorageBase storageBase,
            Models.StoragePool storagePool,
            Models.ServerStatsCpuUsageTelemetry cpuUsage = null)
        {
            this.Time = time;
            this.CpuUsage = cpuUsage;
            this.Load = load;
            this.Ram = ram;
            this.StorageBase = storageBase;
            this.StoragePool = storagePool;
        }

        /// <summary>
        /// The timestamp for when the telemetery data was collected.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets CpuUsage.
        /// </summary>
        [JsonProperty("cpu_usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServerStatsCpuUsageTelemetry CpuUsage { get; set; }

        /// <summary>
        /// Statistics about the current load on the server.
        /// </summary>
        [JsonProperty("load")]
        public Models.ServerStatsLoad Load { get; set; }

        /// <summary>
        /// Statistics about the RAM on a given server.
        /// </summary>
        [JsonProperty("ram")]
        public Models.ServerStatsRamTelemetry Ram { get; set; }

        /// <summary>
        /// Telemetry data for the base volume of a given server.
        /// </summary>
        [JsonProperty("storage_base")]
        public Models.StorageBase StorageBase { get; set; }

        /// <summary>
        /// User data storage across all devices.
        /// </summary>
        [JsonProperty("storage_pool")]
        public Models.StoragePool StoragePool { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsTelemetry : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsTelemetry other &&                this.Time.Equals(other.Time) &&
                ((this.CpuUsage == null && other.CpuUsage == null) || (this.CpuUsage?.Equals(other.CpuUsage) == true)) &&
                ((this.Load == null && other.Load == null) || (this.Load?.Equals(other.Load) == true)) &&
                ((this.Ram == null && other.Ram == null) || (this.Ram?.Equals(other.Ram) == true)) &&
                ((this.StorageBase == null && other.StorageBase == null) || (this.StorageBase?.Equals(other.StorageBase) == true)) &&
                ((this.StoragePool == null && other.StoragePool == null) || (this.StoragePool?.Equals(other.StoragePool) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.CpuUsage = {(this.CpuUsage == null ? "null" : this.CpuUsage.ToString())}");
            toStringOutput.Add($"this.Load = {(this.Load == null ? "null" : this.Load.ToString())}");
            toStringOutput.Add($"this.Ram = {(this.Ram == null ? "null" : this.Ram.ToString())}");
            toStringOutput.Add($"this.StorageBase = {(this.StorageBase == null ? "null" : this.StorageBase.ToString())}");
            toStringOutput.Add($"this.StoragePool = {(this.StoragePool == null ? "null" : this.StoragePool.ToString())}");
        }
    }
}
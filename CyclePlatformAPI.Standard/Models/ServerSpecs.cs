// <copyright file="ServerSpecs.cs" company="APIMatic">
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
    /// ServerSpecs.
    /// </summary>
    public class ServerSpecs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerSpecs"/> class.
        /// </summary>
        public ServerSpecs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerSpecs"/> class.
        /// </summary>
        /// <param name="cpu">cpu.</param>
        /// <param name="gpu">gpu.</param>
        /// <param name="memory">memory.</param>
        /// <param name="storage">storage.</param>
        /// <param name="network">network.</param>
        /// <param name="features">features.</param>
        public ServerSpecs(
            Models.CPUServerSpec cpu,
            Models.GPUServerSpec gpu,
            Models.MemoryServerSpec memory,
            List<Models.StorageServerSpec> storage,
            List<Models.NetworkServerSpec> network,
            Models.FeaturesServerSpec features)
        {
            this.Cpu = cpu;
            this.Gpu = gpu;
            this.Memory = memory;
            this.Storage = storage;
            this.Network = network;
            this.Features = features;
        }

        /// <summary>
        /// Information about the CPU for a given server.
        /// </summary>
        [JsonProperty("cpu")]
        public Models.CPUServerSpec Cpu { get; set; }

        /// <summary>
        /// Information about a given servers GPU resources.
        /// </summary>
        [JsonProperty("gpu")]
        public Models.GPUServerSpec Gpu { get; set; }

        /// <summary>
        /// Information about the memory resources of a given server.
        /// </summary>
        [JsonProperty("memory")]
        public Models.MemoryServerSpec Memory { get; set; }

        /// <summary>
        /// Gets or sets Storage.
        /// </summary>
        [JsonProperty("storage")]
        public List<Models.StorageServerSpec> Storage { get; set; }

        /// <summary>
        /// Gets or sets Network.
        /// </summary>
        [JsonProperty("network")]
        public List<Models.NetworkServerSpec> Network { get; set; }

        /// <summary>
        /// The spec for server features.
        /// </summary>
        [JsonProperty("features")]
        public Models.FeaturesServerSpec Features { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerSpecs : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerSpecs other &&                ((this.Cpu == null && other.Cpu == null) || (this.Cpu?.Equals(other.Cpu) == true)) &&
                ((this.Gpu == null && other.Gpu == null) || (this.Gpu?.Equals(other.Gpu) == true)) &&
                ((this.Memory == null && other.Memory == null) || (this.Memory?.Equals(other.Memory) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cpu = {(this.Cpu == null ? "null" : this.Cpu.ToString())}");
            toStringOutput.Add($"this.Gpu = {(this.Gpu == null ? "null" : this.Gpu.ToString())}");
            toStringOutput.Add($"this.Memory = {(this.Memory == null ? "null" : this.Memory.ToString())}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : $"[{string.Join(", ", this.Storage)} ]")}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : $"[{string.Join(", ", this.Network)} ]")}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
        }
    }
}
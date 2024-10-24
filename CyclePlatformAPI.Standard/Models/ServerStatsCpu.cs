// <copyright file="ServerStatsCpu.cs" company="APIMatic">
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
    /// ServerStatsCpu.
    /// </summary>
    public class ServerStatsCpu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsCpu"/> class.
        /// </summary>
        public ServerStatsCpu()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsCpu"/> class.
        /// </summary>
        /// <param name="cores">cores.</param>
        /// <param name="processors">processors.</param>
        /// <param name="usage">usage.</param>
        public ServerStatsCpu(
            int? cores = null,
            List<Models.Processor> processors = null,
            Models.ServerStatsCpuUsage usage = null)
        {
            this.Cores = cores;
            this.Processors = processors;
            this.Usage = usage;
        }

        /// <summary>
        /// The number of CPU's or vCPU's for a given server.
        /// </summary>
        [JsonProperty("cores", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cores { get; set; }

        /// <summary>
        /// An array of processor information objects.
        /// </summary>
        [JsonProperty("processors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Processor> Processors { get; set; }

        /// <summary>
        /// Gets or sets Usage.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServerStatsCpuUsage Usage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsCpu : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsCpu other &&                ((this.Cores == null && other.Cores == null) || (this.Cores?.Equals(other.Cores) == true)) &&
                ((this.Processors == null && other.Processors == null) || (this.Processors?.Equals(other.Processors) == true)) &&
                ((this.Usage == null && other.Usage == null) || (this.Usage?.Equals(other.Usage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cores = {(this.Cores == null ? "null" : this.Cores.ToString())}");
            toStringOutput.Add($"this.Processors = {(this.Processors == null ? "null" : $"[{string.Join(", ", this.Processors)} ]")}");
            toStringOutput.Add($"this.Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
        }
    }
}
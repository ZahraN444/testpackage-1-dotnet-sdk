// <copyright file="ServerUsageDatum.cs" company="APIMatic">
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
    /// ServerUsageDatum.
    /// </summary>
    public class ServerUsageDatum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerUsageDatum"/> class.
        /// </summary>
        public ServerUsageDatum()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerUsageDatum"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="nodes">nodes.</param>
        /// <param name="memoryGb">memory_gb.</param>
        public ServerUsageDatum(
            DateTime time,
            int nodes,
            int memoryGb)
        {
            this.Time = time;
            this.Nodes = nodes;
            this.MemoryGb = memoryGb;
        }

        /// <summary>
        /// A timestamp for when the usage data was collected.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// The number of nodes the data is pulled from.
        /// </summary>
        [JsonProperty("nodes")]
        public int Nodes { get; set; }

        /// <summary>
        /// A number in GB representing memory.
        /// </summary>
        [JsonProperty("memory_gb")]
        public int MemoryGb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerUsageDatum : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerUsageDatum other &&                this.Time.Equals(other.Time) &&
                this.Nodes.Equals(other.Nodes) &&
                this.MemoryGb.Equals(other.MemoryGb);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Nodes = {this.Nodes}");
            toStringOutput.Add($"this.MemoryGb = {this.MemoryGb}");
        }
    }
}
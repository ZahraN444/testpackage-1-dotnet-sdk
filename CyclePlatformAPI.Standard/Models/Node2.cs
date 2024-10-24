// <copyright file="Node2.cs" company="APIMatic">
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
    /// Node2.
    /// </summary>
    public class Node2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node2"/> class.
        /// </summary>
        public Node2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node2"/> class.
        /// </summary>
        /// <param name="lastCheckin">last_checkin.</param>
        /// <param name="drivers">drivers.</param>
        /// <param name="state">state.</param>
        /// <param name="stats">stats.</param>
        /// <param name="healthy">healthy.</param>
        /// <param name="online">online.</param>
        public Node2(
            DateTime lastCheckin,
            List<string> drivers,
            Models.NodeState state,
            Models.NodeMetaStats stats,
            bool healthy,
            bool online)
        {
            this.LastCheckin = lastCheckin;
            this.Drivers = drivers;
            this.State = state;
            this.Stats = stats;
            this.Healthy = healthy;
            this.Online = online;
        }

        /// <summary>
        /// The last time this server checked in with the platform.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_checkin")]
        public DateTime LastCheckin { get; set; }

        /// <summary>
        /// An array a drivers associated with the given server.
        /// </summary>
        [JsonProperty("drivers")]
        public List<string> Drivers { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.NodeState State { get; set; }

        /// <summary>
        /// Statistics that pertain to a specific node.
        /// </summary>
        [JsonProperty("stats")]
        public Models.NodeMetaStats Stats { get; set; }

        /// <summary>
        /// A boolean where true means the platform is reporting the server as healthy.
        /// </summary>
        [JsonProperty("healthy")]
        public bool Healthy { get; set; }

        /// <summary>
        /// A boolean where true means the server is online and reachable by the platform.
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Node2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Node2 other &&                this.LastCheckin.Equals(other.LastCheckin) &&
                ((this.Drivers == null && other.Drivers == null) || (this.Drivers?.Equals(other.Drivers) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Stats == null && other.Stats == null) || (this.Stats?.Equals(other.Stats) == true)) &&
                this.Healthy.Equals(other.Healthy) &&
                this.Online.Equals(other.Online);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastCheckin = {this.LastCheckin}");
            toStringOutput.Add($"this.Drivers = {(this.Drivers == null ? "null" : $"[{string.Join(", ", this.Drivers)} ]")}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Stats = {(this.Stats == null ? "null" : this.Stats.ToString())}");
            toStringOutput.Add($"this.Healthy = {this.Healthy}");
            toStringOutput.Add($"this.Online = {this.Online}");
        }
    }
}
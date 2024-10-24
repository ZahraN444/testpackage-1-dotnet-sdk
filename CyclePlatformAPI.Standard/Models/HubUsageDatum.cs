// <copyright file="HubUsageDatum.cs" company="APIMatic">
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
    /// HubUsageDatum.
    /// </summary>
    public class HubUsageDatum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubUsageDatum"/> class.
        /// </summary>
        public HubUsageDatum()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubUsageDatum"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="servers">servers.</param>
        /// <param name="members">members.</param>
        /// <param name="environments">environments.</param>
        /// <param name="containers">containers.</param>
        public HubUsageDatum(
            string time,
            double servers,
            double members,
            double environments,
            double containers)
        {
            this.Time = time;
            this.Servers = servers;
            this.Members = members;
            this.Environments = environments;
            this.Containers = containers;
        }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets Servers.
        /// </summary>
        [JsonProperty("servers")]
        public double Servers { get; set; }

        /// <summary>
        /// Gets or sets Members.
        /// </summary>
        [JsonProperty("members")]
        public double Members { get; set; }

        /// <summary>
        /// Gets or sets Environments.
        /// </summary>
        [JsonProperty("environments")]
        public double Environments { get; set; }

        /// <summary>
        /// Gets or sets Containers.
        /// </summary>
        [JsonProperty("containers")]
        public double Containers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubUsageDatum : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubUsageDatum other &&                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                this.Servers.Equals(other.Servers) &&
                this.Members.Equals(other.Members) &&
                this.Environments.Equals(other.Environments) &&
                this.Containers.Equals(other.Containers);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time)}");
            toStringOutput.Add($"this.Servers = {this.Servers}");
            toStringOutput.Add($"this.Members = {this.Members}");
            toStringOutput.Add($"this.Environments = {this.Environments}");
            toStringOutput.Add($"this.Containers = {this.Containers}");
        }
    }
}
// <copyright file="DiscoveryEnvironmentService.cs" company="APIMatic">
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
    /// DiscoveryEnvironmentService.
    /// </summary>
    public class DiscoveryEnvironmentService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryEnvironmentService"/> class.
        /// </summary>
        public DiscoveryEnvironmentService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryEnvironmentService"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="highAvailability">high_availability.</param>
        /// <param name="config">config.</param>
        /// <param name="autoUpdate">auto_update.</param>
        public DiscoveryEnvironmentService(
            bool enable,
            string containerId,
            bool highAvailability,
            DiscoveryEnvironmentServiceConfig config,
            bool? autoUpdate = null)
        {
            this.Enable = enable;
            this.ContainerId = containerId;
            this.HighAvailability = highAvailability;
            this.AutoUpdate = autoUpdate;
            this.Config = config;
        }

        /// <summary>
        /// Whether or not the discovery service is enabled.
        /// </summary>
        [JsonProperty("enable")]
        [JsonRequired]
        public bool Enable { get; set; }

        /// <summary>
        /// The ID of the discovery service container
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("container_id")]
        [JsonRequired]
        public string ContainerId { get; set; }

        /// <summary>
        /// A boolean representing if this service container is set to high availability mode or not.
        /// </summary>
        [JsonProperty("high_availability")]
        [JsonRequired]
        public bool HighAvailability { get; set; }

        /// <summary>
        /// A boolean where `true` represents the desire to automatically update the environment discovery service.
        /// </summary>
        [JsonProperty("auto_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// The config object for the discovery service.
        /// </summary>
        [JsonProperty("config")]
        [JsonRequired]
        public DiscoveryEnvironmentServiceConfig Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DiscoveryEnvironmentService : ({string.Join(", ", toStringOutput)})";
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
            return obj is DiscoveryEnvironmentService other &&                this.Enable.Equals(other.Enable) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                this.HighAvailability.Equals(other.HighAvailability) &&
                ((this.AutoUpdate == null && other.AutoUpdate == null) || (this.AutoUpdate?.Equals(other.AutoUpdate) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enable = {this.Enable}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.HighAvailability = {this.HighAvailability}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
            toStringOutput.Add($"Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}
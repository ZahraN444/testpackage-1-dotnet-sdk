// <copyright file="VpnEnvironmentService.cs" company="APIMatic">
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
    /// VpnEnvironmentService.
    /// </summary>
    public class VpnEnvironmentService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnEnvironmentService"/> class.
        /// </summary>
        public VpnEnvironmentService()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnEnvironmentService"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="autoUpdate">auto_update.</param>
        /// <param name="config">config.</param>
        public VpnEnvironmentService(
            bool enable,
            string containerId,
            bool? autoUpdate = null,
            Models.Config3 config = null)
        {
            this.Enable = enable;
            this.ContainerId = containerId;
            this.AutoUpdate = autoUpdate;
            this.Config = config;
        }

        /// <summary>
        /// Whether or not the VPN service is enabled.
        /// </summary>
        [JsonProperty("enable")]
        [JsonRequired]
        public bool Enable { get; set; }

        /// <summary>
        /// The ID of the VPN service container
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("container_id")]
        [JsonRequired]
        public string ContainerId { get; set; }

        /// <summary>
        /// A boolean representing if this service container is set to autoupdate or not
        /// </summary>
        [JsonProperty("auto_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// The config object for the VPN service.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Include)]
        public Models.Config3 Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VpnEnvironmentService : ({string.Join(", ", toStringOutput)})";
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
            return obj is VpnEnvironmentService other &&                this.Enable.Equals(other.Enable) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
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
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}
// <copyright file="Vpn.cs" company="APIMatic">
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
    /// Vpn.
    /// </summary>
    public class Vpn
    {
        private Models.Config3 config;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "config", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Vpn"/> class.
        /// </summary>
        public Vpn()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vpn"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="autoUpdate">auto_update.</param>
        /// <param name="config">config.</param>
        public Vpn(
            bool? enable = null,
            string containerId = null,
            bool? autoUpdate = null,
            Models.Config3 config = null)
        {
            this.Enable = enable;
            this.ContainerId = containerId;
            this.AutoUpdate = autoUpdate;
            if (config != null)
            {
                this.Config = config;
            }

        }

        /// <summary>
        /// Whether or not the VPN service is enabled.
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The ID of the VPN service container
        /// </summary>
        [JsonProperty("container_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerId { get; set; }

        /// <summary>
        /// A boolean representing if this service container is set to autoupdate or not
        /// </summary>
        [JsonProperty("auto_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// The config object for the VPN service.
        /// </summary>
        [JsonProperty("config")]
        public Models.Config3 Config
        {
            get
            {
                return this.config;
            }

            set
            {
                this.shouldSerialize["config"] = true;
                this.config = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Vpn : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetConfig()
        {
            this.shouldSerialize["config"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConfig()
        {
            return this.shouldSerialize["config"];
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
            return obj is Vpn other &&                ((this.Enable == null && other.Enable == null) || (this.Enable?.Equals(other.Enable) == true)) &&
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
            toStringOutput.Add($"this.Enable = {(this.Enable == null ? "null" : this.Enable.ToString())}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}
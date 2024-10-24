// <copyright file="Loadbalancer.cs" company="APIMatic">
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
    /// Loadbalancer.
    /// </summary>
    public class Loadbalancer
    {
        private string containerId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "container_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Loadbalancer"/> class.
        /// </summary>
        public Loadbalancer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loadbalancer"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="highAvailability">high_availability.</param>
        /// <param name="autoUpdate">auto_update.</param>
        /// <param name="config">config.</param>
        public Loadbalancer(
            bool? enable = null,
            string containerId = null,
            bool? highAvailability = null,
            bool? autoUpdate = null,
            LoadbalancerConfig config = null)
        {
            this.Enable = enable;
            if (containerId != null)
            {
                this.ContainerId = containerId;
            }

            this.HighAvailability = highAvailability;
            this.AutoUpdate = autoUpdate;
            this.Config = config;
        }

        /// <summary>
        /// Whether or not the loadbalancer service is enabled.
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The ID of the loadbalancer service container
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId
        {
            get
            {
                return this.containerId;
            }

            set
            {
                this.shouldSerialize["container_id"] = true;
                this.containerId = value;
            }
        }

        /// <summary>
        /// A boolean representing if this service container is set to high availability mode or not.
        /// </summary>
        [JsonProperty("high_availability", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighAvailability { get; set; }

        /// <summary>
        /// A boolean representing if this service container is set to autoupdate or not
        /// </summary>
        [JsonProperty("auto_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public LoadbalancerConfig Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Loadbalancer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContainerId()
        {
            this.shouldSerialize["container_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContainerId()
        {
            return this.shouldSerialize["container_id"];
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
            return obj is Loadbalancer other &&                ((this.Enable == null && other.Enable == null) || (this.Enable?.Equals(other.Enable) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.HighAvailability == null && other.HighAvailability == null) || (this.HighAvailability?.Equals(other.HighAvailability) == true)) &&
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
            toStringOutput.Add($"this.HighAvailability = {(this.HighAvailability == null ? "null" : this.HighAvailability.ToString())}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
            toStringOutput.Add($"Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}
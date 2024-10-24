// <copyright file="Loadbalancer1.cs" company="APIMatic">
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
    /// Loadbalancer1.
    /// </summary>
    public class Loadbalancer1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Loadbalancer1"/> class.
        /// </summary>
        public Loadbalancer1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loadbalancer1"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="state">state.</param>
        /// <param name="highAvailability">high_availability.</param>
        /// <param name="autoUpdate">auto_update.</param>
        public Loadbalancer1(
            bool? enable = null,
            Loadbalancer1ContainerId containerId = null,
            Models.ContainerState state = null,
            bool? highAvailability = null,
            bool? autoUpdate = null)
        {
            this.Enable = enable;
            this.ContainerId = containerId;
            this.State = state;
            this.HighAvailability = highAvailability;
            this.AutoUpdate = autoUpdate;
        }

        /// <summary>
        /// Whether or not the service is enabled.
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Gets or sets ContainerId.
        /// </summary>
        [JsonProperty("container_id", NullValueHandling = NullValueHandling.Ignore)]
        public Loadbalancer1ContainerId ContainerId { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContainerState State { get; set; }

        /// <summary>
        /// Whether or not the service is deployed in high availability
        /// </summary>
        [JsonProperty("high_availability", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighAvailability { get; set; }

        /// <summary>
        /// Whether or not the service will be automatically updated as new versions are released. Otherwise, the service will need to be restarted manually.
        /// </summary>
        [JsonProperty("auto_update", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Loadbalancer1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Loadbalancer1 other &&                ((this.Enable == null && other.Enable == null) || (this.Enable?.Equals(other.Enable) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.HighAvailability == null && other.HighAvailability == null) || (this.HighAvailability?.Equals(other.HighAvailability) == true)) &&
                ((this.AutoUpdate == null && other.AutoUpdate == null) || (this.AutoUpdate?.Equals(other.AutoUpdate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enable = {(this.Enable == null ? "null" : this.Enable.ToString())}");
            toStringOutput.Add($"ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.HighAvailability = {(this.HighAvailability == null ? "null" : this.HighAvailability.ToString())}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
        }
    }
}
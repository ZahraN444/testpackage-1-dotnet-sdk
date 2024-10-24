// <copyright file="EnvironmentServiceContainerSummary.cs" company="APIMatic">
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
    /// EnvironmentServiceContainerSummary.
    /// </summary>
    public class EnvironmentServiceContainerSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentServiceContainerSummary"/> class.
        /// </summary>
        public EnvironmentServiceContainerSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentServiceContainerSummary"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="state">state.</param>
        /// <param name="highAvailability">high_availability.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="autoUpdate">auto_update.</param>
        public EnvironmentServiceContainerSummary(
            bool enable,
            Models.ContainerState state,
            bool highAvailability,
            EnvironmentServiceContainerSummaryContainerId containerId = null,
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
        [JsonProperty("enable")]
        [JsonRequired]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or sets ContainerId.
        /// </summary>
        [JsonProperty("container_id", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentServiceContainerSummaryContainerId ContainerId { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ContainerState State { get; set; }

        /// <summary>
        /// Whether or not the service is deployed in high availability
        /// </summary>
        [JsonProperty("high_availability")]
        [JsonRequired]
        public bool HighAvailability { get; set; }

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

            return $"EnvironmentServiceContainerSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentServiceContainerSummary other &&                this.Enable.Equals(other.Enable) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                this.HighAvailability.Equals(other.HighAvailability) &&
                ((this.AutoUpdate == null && other.AutoUpdate == null) || (this.AutoUpdate?.Equals(other.AutoUpdate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enable = {this.Enable}");
            toStringOutput.Add($"ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.HighAvailability = {this.HighAvailability}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
        }
    }
}
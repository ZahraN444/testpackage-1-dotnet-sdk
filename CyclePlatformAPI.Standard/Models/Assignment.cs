// <copyright file="Assignment.cs" company="APIMatic">
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
    /// Assignment.
    /// </summary>
    public class Assignment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Assignment"/> class.
        /// </summary>
        public Assignment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Assignment"/> class.
        /// </summary>
        /// <param name="containerId">container_id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="environmentId">environment_id.</param>
        public Assignment(
            string containerId,
            string instanceId,
            string environmentId)
        {
            this.ContainerId = containerId;
            this.InstanceId = instanceId;
            this.EnvironmentId = environmentId;
        }

        /// <summary>
        /// Gets or sets ContainerId.
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or sets InstanceId.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or sets EnvironmentId.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Assignment : ({string.Join(", ", toStringOutput)})";
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
            return obj is Assignment other &&                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
        }
    }
}
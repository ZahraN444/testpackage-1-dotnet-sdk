// <copyright file="ActivityContext.cs" company="APIMatic">
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
    /// ActivityContext.
    /// </summary>
    public class ActivityContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityContext"/> class.
        /// </summary>
        public ActivityContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityContext"/> class.
        /// </summary>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="serverId">server_id.</param>
        /// <param name="stackId">stack_id.</param>
        /// <param name="dnsZoneId">dns_zone_id.</param>
        public ActivityContext(
            string environmentId = null,
            string containerId = null,
            string instanceId = null,
            string serverId = null,
            string stackId = null,
            string dnsZoneId = null)
        {
            this.EnvironmentId = environmentId;
            this.ContainerId = containerId;
            this.InstanceId = instanceId;
            this.ServerId = serverId;
            this.StackId = stackId;
            this.DnsZoneId = dnsZoneId;
        }

        /// <summary>
        /// An ID for the given resource.
        /// </summary>
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// An ID for the given resource.
        /// </summary>
        [JsonProperty("container_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerId { get; set; }

        /// <summary>
        /// An ID for the given resource.
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// An ID for the given resource.
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// An ID for the given resource.
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// An ID for the given resource.
        /// </summary>
        [JsonProperty("dns_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsZoneId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivityContext : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivityContext other &&                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                ((this.StackId == null && other.StackId == null) || (this.StackId?.Equals(other.StackId) == true)) &&
                ((this.DnsZoneId == null && other.DnsZoneId == null) || (this.DnsZoneId?.Equals(other.DnsZoneId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.StackId = {(this.StackId == null ? "null" : this.StackId)}");
            toStringOutput.Add($"this.DnsZoneId = {(this.DnsZoneId == null ? "null" : this.DnsZoneId)}");
        }
    }
}
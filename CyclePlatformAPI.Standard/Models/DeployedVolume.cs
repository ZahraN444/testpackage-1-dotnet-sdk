// <copyright file="DeployedVolume.cs" company="APIMatic">
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
    /// DeployedVolume.
    /// </summary>
    public class DeployedVolume
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployedVolume"/> class.
        /// </summary>
        public DeployedVolume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployedVolume"/> class.
        /// </summary>
        /// <param name="serverId">server_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="containerVolumeId">container_volume_id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="hash">hash.</param>
        /// <param name="path">path.</param>
        /// <param name="storage">storage.</param>
        public DeployedVolume(
            string serverId,
            string containerId,
            string containerVolumeId,
            string instanceId,
            string hash,
            string path,
            Models.Storage storage)
        {
            this.ServerId = serverId;
            this.ContainerId = containerId;
            this.ContainerVolumeId = containerVolumeId;
            this.InstanceId = instanceId;
            this.Hash = hash;
            this.Path = path;
            this.Storage = storage;
        }

        /// <summary>
        /// The ID of the server the instance is deployed to.
        /// </summary>
        [JsonProperty("server_id")]
        public string ServerId { get; set; }

        /// <summary>
        /// The ID of the container the instance was created from.
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }

        /// <summary>
        /// The ID for the volume withing the context of the container.
        /// </summary>
        [JsonProperty("container_volume_id")]
        public string ContainerVolumeId { get; set; }

        /// <summary>
        /// The ID for the container instance this volume is attached to.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// A hash used as part of the identification mechanisms for the platform and API.
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// The path where the volume is mounted on the instnace filesystem.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Storage information for the volume.
        /// </summary>
        [JsonProperty("storage")]
        public Models.Storage Storage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeployedVolume : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeployedVolume other &&                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.ContainerVolumeId == null && other.ContainerVolumeId == null) || (this.ContainerVolumeId?.Equals(other.ContainerVolumeId) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.Hash == null && other.Hash == null) || (this.Hash?.Equals(other.Hash) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.Storage == null && other.Storage == null) || (this.Storage?.Equals(other.Storage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.ContainerVolumeId = {(this.ContainerVolumeId == null ? "null" : this.ContainerVolumeId)}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.Hash = {(this.Hash == null ? "null" : this.Hash)}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"this.Storage = {(this.Storage == null ? "null" : this.Storage.ToString())}");
        }
    }
}
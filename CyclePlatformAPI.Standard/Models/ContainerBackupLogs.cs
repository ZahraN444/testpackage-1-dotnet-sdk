// <copyright file="ContainerBackupLogs.cs" company="APIMatic">
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
    /// ContainerBackupLogs.
    /// </summary>
    public class ContainerBackupLogs
    {
        private Models.Error2 error;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "error", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerBackupLogs"/> class.
        /// </summary>
        public ContainerBackupLogs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerBackupLogs"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="backupId">backup_id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="type">type.</param>
        /// <param name="log">log.</param>
        /// <param name="events">events.</param>
        /// <param name="error">error.</param>
        public ContainerBackupLogs(
            string id,
            string containerId,
            string instanceId,
            string backupId,
            string hubId,
            Models.Type11Enum type,
            string log,
            Models.BackupLogEvents events,
            Models.Error2 error = null)
        {
            this.Id = id;
            this.ContainerId = containerId;
            this.InstanceId = instanceId;
            this.BackupId = backupId;
            this.HubId = hubId;
            this.Type = type;
            this.Log = log;
            if (error != null)
            {
                this.Error = error;
            }

            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// An identifier for the container.
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }

        /// <summary>
        /// An identifier for the instance.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// An identifier for the backup.
        /// </summary>
        [JsonProperty("backup_id")]
        public string BackupId { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// The type of the backup log.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type11Enum Type { get; set; }

        /// <summary>
        /// The log.
        /// </summary>
        [JsonProperty("log")]
        public string Log { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error")]
        public Models.Error2 Error
        {
            get
            {
                return this.error;
            }

            set
            {
                this.shouldSerialize["error"] = true;
                this.error = value;
            }
        }

        /// <summary>
        /// A collection of timestamps for each event in the backup log's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.BackupLogEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerBackupLogs : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetError()
        {
            this.shouldSerialize["error"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeError()
        {
            return this.shouldSerialize["error"];
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
            return obj is ContainerBackupLogs other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.BackupId == null && other.BackupId == null) || (this.BackupId?.Equals(other.BackupId) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Log == null && other.Log == null) || (this.Log?.Equals(other.Log) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.BackupId = {(this.BackupId == null ? "null" : this.BackupId)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Log = {(this.Log == null ? "null" : this.Log)}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
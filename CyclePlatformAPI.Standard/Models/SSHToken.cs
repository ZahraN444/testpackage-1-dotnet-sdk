// <copyright file="SSHToken.cs" company="APIMatic">
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
    /// SSHToken.
    /// </summary>
    public class SSHToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSHToken"/> class.
        /// </summary>
        public SSHToken()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSHToken"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="events">events.</param>
        /// <param name="valid">valid.</param>
        public SSHToken(
            string id,
            string instanceId,
            string containerId,
            string hubId,
            Models.CreatorScope creator,
            Models.SSHTokenEvents events,
            bool valid)
        {
            this.Id = id;
            this.InstanceId = instanceId;
            this.ContainerId = containerId;
            this.HubId = hubId;
            this.Creator = creator;
            this.Events = events;
            this.Valid = valid;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the instance being connected to.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the container from which the instance was created.
        /// </summary>
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the SSH token's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.SSHTokenEvents Events { get; set; }

        /// <summary>
        /// A boolean where true represents the token as being a valid token to be used for connection.
        /// </summary>
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SSHToken : ({string.Join(", ", toStringOutput)})";
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
            return obj is SSHToken other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                this.Valid.Equals(other.Valid);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Valid = {this.Valid}");
        }
    }
}
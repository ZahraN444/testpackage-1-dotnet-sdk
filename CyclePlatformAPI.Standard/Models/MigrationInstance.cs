// <copyright file="MigrationInstance.cs" company="APIMatic">
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
    /// MigrationInstance.
    /// </summary>
    public class MigrationInstance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationInstance"/> class.
        /// </summary>
        public MigrationInstance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationInstance"/> class.
        /// </summary>
        /// <param name="instanceId">instance_id.</param>
        /// <param name="serverId">server_id.</param>
        public MigrationInstance(
            string instanceId,
            string serverId)
        {
            this.InstanceId = instanceId;
            this.ServerId = serverId;
        }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("instance_id")]
        [JsonRequired]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the server.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("server_id")]
        [JsonRequired]
        public string ServerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MigrationInstance : ({string.Join(", ", toStringOutput)})";
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
            return obj is MigrationInstance other &&                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true)) &&
                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
        }
    }
}
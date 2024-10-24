// <copyright file="V1ContainersInstancesRequest.cs" company="APIMatic">
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
    /// V1ContainersInstancesRequest.
    /// </summary>
    public class V1ContainersInstancesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainersInstancesRequest"/> class.
        /// </summary>
        public V1ContainersInstancesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainersInstancesRequest"/> class.
        /// </summary>
        /// <param name="serverId">server_id.</param>
        /// <param name="newInstances">new_instances.</param>
        public V1ContainersInstancesRequest(
            string serverId,
            int newInstances)
        {
            this.ServerId = serverId;
            this.NewInstances = newInstances;
        }

        /// <summary>
        /// The ID of the Server the new Instance(s) should be deployed to.
        /// </summary>
        [JsonProperty("server_id")]
        public string ServerId { get; set; }

        /// <summary>
        /// The number of new Instances to be created on the given Server.
        /// </summary>
        [JsonProperty("new_instances")]
        public int NewInstances { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ContainersInstancesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1ContainersInstancesRequest other &&                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                this.NewInstances.Equals(other.NewInstances);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.NewInstances = {this.NewInstances}");
        }
    }
}
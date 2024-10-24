// <copyright file="ServerInstancesSummary.cs" company="APIMatic">
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
    /// ServerInstancesSummary.
    /// </summary>
    public class ServerInstancesSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInstancesSummary"/> class.
        /// </summary>
        public ServerInstancesSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInstancesSummary"/> class.
        /// </summary>
        /// <param name="serverId">server_id.</param>
        /// <param name="instances">instances.</param>
        public ServerInstancesSummary(
            string serverId,
            int instances)
        {
            this.ServerId = serverId;
            this.Instances = instances;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("server_id")]
        public string ServerId { get; set; }

        /// <summary>
        /// Gets or sets Instances.
        /// </summary>
        [JsonProperty("instances")]
        public int Instances { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerInstancesSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerInstancesSummary other &&                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                this.Instances.Equals(other.Instances);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.Instances = {this.Instances}");
        }
    }
}
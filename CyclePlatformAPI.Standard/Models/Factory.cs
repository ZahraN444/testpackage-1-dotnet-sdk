// <copyright file="Factory.cs" company="APIMatic">
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
    /// Factory.
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class.
        /// </summary>
        public Factory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class.
        /// </summary>
        /// <param name="nodeId">node_id.</param>
        /// <param name="cached">cached.</param>
        /// <param name="acknowledged">acknowledged.</param>
        public Factory(
            string nodeId,
            DateTime cached,
            DateTime acknowledged)
        {
            this.NodeId = nodeId;
            this.Cached = cached;
            this.Acknowledged = acknowledged;
        }

        /// <summary>
        /// The node holding the factory service that was responsible for building the image.
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// A date timestamp for when the node cached the image.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cached")]
        public DateTime Cached { get; set; }

        /// <summary>
        /// A date timestamp for when the node acknowledged the image import job.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("acknowledged")]
        public DateTime Acknowledged { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Factory : ({string.Join(", ", toStringOutput)})";
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
            return obj is Factory other &&                ((this.NodeId == null && other.NodeId == null) || (this.NodeId?.Equals(other.NodeId) == true)) &&
                this.Cached.Equals(other.Cached) &&
                this.Acknowledged.Equals(other.Acknowledged);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NodeId = {(this.NodeId == null ? "null" : this.NodeId)}");
            toStringOutput.Add($"this.Cached = {this.Cached}");
            toStringOutput.Add($"this.Acknowledged = {this.Acknowledged}");
        }
    }
}
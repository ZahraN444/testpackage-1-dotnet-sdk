// <copyright file="ServerEvents.cs" company="APIMatic">
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
    /// ServerEvents.
    /// </summary>
    public class ServerEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerEvents"/> class.
        /// </summary>
        public ServerEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="latestInstance">latest_instance.</param>
        /// <param name="provisioning">provisioning.</param>
        public ServerEvents(
            DateTime created,
            DateTime updated,
            DateTime deleted,
            DateTime latestInstance,
            Models.Provisioning provisioning)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.LatestInstance = latestInstance;
            this.Provisioning = provisioning;
        }

        /// <summary>
        /// The timestamp of when the server was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the server was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The timestamp of when the server was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted")]
        public DateTime Deleted { get; set; }

        /// <summary>
        /// The timestamp of when the latest instance was deployed to this server.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("latest_instance")]
        public DateTime LatestInstance { get; set; }

        /// <summary>
        /// Information about the provisioning of the server.
        /// </summary>
        [JsonProperty("provisioning")]
        public Models.Provisioning Provisioning { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerEvents other &&                this.Created.Equals(other.Created) &&
                this.Updated.Equals(other.Updated) &&
                this.Deleted.Equals(other.Deleted) &&
                this.LatestInstance.Equals(other.LatestInstance) &&
                ((this.Provisioning == null && other.Provisioning == null) || (this.Provisioning?.Equals(other.Provisioning) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Updated = {this.Updated}");
            toStringOutput.Add($"this.Deleted = {this.Deleted}");
            toStringOutput.Add($"this.LatestInstance = {this.LatestInstance}");
            toStringOutput.Add($"this.Provisioning = {(this.Provisioning == null ? "null" : this.Provisioning.ToString())}");
        }
    }
}
// <copyright file="InstanceEvents.cs" company="APIMatic">
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
    /// InstanceEvents.
    /// </summary>
    public class InstanceEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceEvents"/> class.
        /// </summary>
        public InstanceEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        public InstanceEvents(
            DateTime created,
            DateTime updated,
            DateTime deleted)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
        }

        /// <summary>
        /// The timestamp of when the instance was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the instance was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The timestamp of when the instance was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted")]
        public DateTime Deleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceEvents other &&                this.Created.Equals(other.Created) &&
                this.Updated.Equals(other.Updated) &&
                this.Deleted.Equals(other.Deleted);
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
        }
    }
}
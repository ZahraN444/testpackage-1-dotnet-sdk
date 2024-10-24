// <copyright file="ZoneEvents.cs" company="APIMatic">
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
    /// ZoneEvents.
    /// </summary>
    public class ZoneEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneEvents"/> class.
        /// </summary>
        public ZoneEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="lastVerification">last_verification.</param>
        /// <param name="verified">verified.</param>
        public ZoneEvents(
            DateTime created,
            DateTime updated,
            DateTime deleted,
            DateTime lastVerification,
            DateTime verified)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.LastVerification = lastVerification;
            this.Verified = verified;
        }

        /// <summary>
        /// The timestamp of when the DNS zone was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the DNS zone was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The timestamp of when the DNS zone was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted")]
        public DateTime Deleted { get; set; }

        /// <summary>
        /// The timestamp of when the DNS zone was last_verification.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_verification")]
        public DateTime LastVerification { get; set; }

        /// <summary>
        /// The timestamp of when the DNS zone was verified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("verified")]
        public DateTime Verified { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ZoneEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is ZoneEvents other &&                this.Created.Equals(other.Created) &&
                this.Updated.Equals(other.Updated) &&
                this.Deleted.Equals(other.Deleted) &&
                this.LastVerification.Equals(other.LastVerification) &&
                this.Verified.Equals(other.Verified);
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
            toStringOutput.Add($"this.LastVerification = {this.LastVerification}");
            toStringOutput.Add($"this.Verified = {this.Verified}");
        }
    }
}
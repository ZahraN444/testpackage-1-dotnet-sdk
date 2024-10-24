// <copyright file="MembershipEvents.cs" company="APIMatic">
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
    /// MembershipEvents.
    /// </summary>
    public class MembershipEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipEvents"/> class.
        /// </summary>
        public MembershipEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipEvents"/> class.
        /// </summary>
        /// <param name="joined">joined.</param>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        public MembershipEvents(
            DateTime joined,
            DateTime? created = null,
            DateTime? updated = null,
            DateTime? deleted = null)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.Joined = joined;
        }

        /// <summary>
        /// The timestamp of when the membership was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when the membership was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the membership was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Deleted { get; set; }

        /// <summary>
        /// The timestamp of when the membership was accepted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("joined")]
        public DateTime Joined { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MembershipEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is MembershipEvents other &&                ((this.Created == null && other.Created == null) || (this.Created?.Equals(other.Created) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                this.Joined.Equals(other.Joined);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated.ToString())}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"this.Joined = {this.Joined}");
        }
    }
}
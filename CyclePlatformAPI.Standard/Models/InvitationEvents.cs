// <copyright file="InvitationEvents.cs" company="APIMatic">
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
    /// InvitationEvents.
    /// </summary>
    public class InvitationEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationEvents"/> class.
        /// </summary>
        public InvitationEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="accepted">accepted.</param>
        /// <param name="declined">declined.</param>
        /// <param name="revoked">revoked.</param>
        public InvitationEvents(
            DateTime created,
            DateTime updated,
            DateTime deleted,
            DateTime accepted,
            DateTime declined,
            DateTime revoked)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.Accepted = accepted;
            this.Declined = declined;
            this.Revoked = revoked;
        }

        /// <summary>
        /// The timestamp of when the invitation was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the invitation was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The timestamp of when the invitation was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted")]
        public DateTime Deleted { get; set; }

        /// <summary>
        /// The timestamp of when the invitation was accepted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("accepted")]
        public DateTime Accepted { get; set; }

        /// <summary>
        /// The timestamp of when the invitation was declined.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("declined")]
        public DateTime Declined { get; set; }

        /// <summary>
        /// The timestamp of when the invitation was revoked.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("revoked")]
        public DateTime Revoked { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvitationEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvitationEvents other &&                this.Created.Equals(other.Created) &&
                this.Updated.Equals(other.Updated) &&
                this.Deleted.Equals(other.Deleted) &&
                this.Accepted.Equals(other.Accepted) &&
                this.Declined.Equals(other.Declined) &&
                this.Revoked.Equals(other.Revoked);
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
            toStringOutput.Add($"this.Accepted = {this.Accepted}");
            toStringOutput.Add($"this.Declined = {this.Declined}");
            toStringOutput.Add($"this.Revoked = {this.Revoked}");
        }
    }
}
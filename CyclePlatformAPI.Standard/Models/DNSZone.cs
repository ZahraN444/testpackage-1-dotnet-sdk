// <copyright file="DNSZone.cs" company="APIMatic">
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
    /// DNSZone.
    /// </summary>
    public class DNSZone
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSZone"/> class.
        /// </summary>
        public DNSZone()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSZone"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="origin">origin.</param>
        /// <param name="hosted">hosted.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        public DNSZone(
            string id,
            string hubId,
            Models.CreatorScope creator,
            string origin,
            bool hosted,
            Models.DNSZoneState state,
            Models.ZoneEvents events)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Creator = creator;
            this.Origin = origin;
            this.Hosted = hosted;
            this.State = state;
            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// The origin for the given DNS zone.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("origin")]
        [JsonRequired]
        public string Origin { get; set; }

        /// <summary>
        /// A boolean where true represents this zone is a hosted zone.
        /// </summary>
        [JsonProperty("hosted")]
        [JsonRequired]
        public bool Hosted { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.DNSZoneState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the DNS zone's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.ZoneEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DNSZone : ({string.Join(", ", toStringOutput)})";
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
            return obj is DNSZone other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                this.Hosted.Equals(other.Hosted) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Origin = {(this.Origin == null ? "null" : this.Origin)}");
            toStringOutput.Add($"this.Hosted = {this.Hosted}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
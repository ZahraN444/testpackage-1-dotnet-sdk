// <copyright file="DNSRecord.cs" company="APIMatic">
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
    /// DNSRecord.
    /// </summary>
    public class DNSRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSRecord"/> class.
        /// </summary>
        public DNSRecord()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSRecord"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="zoneId">zone_id.</param>
        /// <param name="name">name.</param>
        /// <param name="resolvedDomain">resolved_domain.</param>
        /// <param name="type">type.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="features">features.</param>
        public DNSRecord(
            string id,
            string hubId,
            Models.CreatorScope creator,
            string zoneId,
            string name,
            string resolvedDomain,
            Models.DNSRecordTypes type,
            Models.DNSRecordState state,
            Dictionary<string, DateTime> events,
            Models.Features2 features = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Creator = creator;
            this.ZoneId = zoneId;
            this.Name = name;
            this.ResolvedDomain = resolvedDomain;
            this.Type = type;
            this.Features = features;
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
        /// A unique identifier for the zone
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("zone_id")]
        [JsonRequired]
        public string ZoneId { get; set; }

        /// <summary>
        /// A name used for the record, where `@` signifies the use of the root domain.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The name of the record and the origin as a domain name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("resolved_domain")]
        [JsonRequired]
        public string ResolvedDomain { get; set; }

        /// <summary>
        /// DNS record types the platform supports.
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.DNSRecordTypes Type { get; set; }

        /// <summary>
        /// TLS features for the record.
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Include)]
        public Models.Features2 Features { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.DNSRecordState State { get; set; }

        /// <summary>
        /// Describes the date and time at which certain events occurred in the lifetime of this resource.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(IsoDateTimeConverter))]
        [JsonProperty("events")]
        [JsonRequired]
        public Dictionary<string, DateTime> Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DNSRecord : ({string.Join(", ", toStringOutput)})";
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
            return obj is DNSRecord other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.ZoneId == null && other.ZoneId == null) || (this.ZoneId?.Equals(other.ZoneId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ResolvedDomain == null && other.ResolvedDomain == null) || (this.ResolvedDomain?.Equals(other.ResolvedDomain) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
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
            toStringOutput.Add($"this.ZoneId = {(this.ZoneId == null ? "null" : this.ZoneId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.ResolvedDomain = {(this.ResolvedDomain == null ? "null" : this.ResolvedDomain)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
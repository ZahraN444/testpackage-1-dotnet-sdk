// <copyright file="ApiKeyCreator.cs" company="APIMatic">
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
    /// ApiKeyCreator.
    /// </summary>
    public class ApiKeyCreator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreator"/> class.
        /// </summary>
        public ApiKeyCreator()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreator"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="secret">secret.</param>
        /// <param name="ips">ips.</param>
        public ApiKeyCreator(
            string id,
            string name,
            string hubId,
            Models.Permissions permissions,
            Models.Capabilities2 capabilities,
            Models.State6 state,
            Dictionary<string, DateTime> events,
            string secret = null,
            List<string> ips = null)
        {
            this.Id = id;
            this.Name = name;
            this.HubId = hubId;
            this.Secret = secret;
            this.Permissions = permissions;
            this.Capabilities = capabilities;
            this.Ips = ips;
            this.State = state;
            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the API key
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// The API key secret
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// Permissions information for an API Key
        /// </summary>
        [JsonProperty("permissions")]
        public Models.Permissions Permissions { get; set; }

        /// <summary>
        /// The API key capabilities list
        /// </summary>
        [JsonProperty("capabilities")]
        public Models.Capabilities2 Capabilities { get; set; }

        /// <summary>
        /// Gets or sets Ips.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Include)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.State6 State { get; set; }

        /// <summary>
        /// Describes the date and time at which certain events occurred in the lifetime of this resource.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(IsoDateTimeConverter))]
        [JsonProperty("events")]
        public Dictionary<string, DateTime> Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApiKeyCreator : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApiKeyCreator other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true)) &&
                ((this.Permissions == null && other.Permissions == null) || (this.Permissions?.Equals(other.Permissions) == true)) &&
                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true)) &&
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
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.Permissions = {(this.Permissions == null ? "null" : this.Permissions.ToString())}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : this.Capabilities.ToString())}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
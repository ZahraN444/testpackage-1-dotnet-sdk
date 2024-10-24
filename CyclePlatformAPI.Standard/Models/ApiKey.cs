// <copyright file="ApiKey.cs" company="APIMatic">
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
    /// ApiKey.
    /// </summary>
    public class ApiKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey"/> class.
        /// </summary>
        public ApiKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="name">name.</param>
        /// <param name="creator">creator.</param>
        /// <param name="secret">secret.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="ips">ips.</param>
        public ApiKey(
            string id,
            string hubId,
            string name,
            Models.CreatorScope creator,
            string secret,
            Models.Permissions1 permissions,
            Models.Capabilities7 capabilities,
            Models.ApiKeyState state,
            Models.HubEvents1 events,
            List<string> ips = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Name = name;
            this.Creator = creator;
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
        /// A name for the API key.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// The API key secret.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("secret")]
        [JsonRequired]
        public string Secret { get; set; }

        /// <summary>
        /// Information about this members permissions for a given resource.
        /// </summary>
        [JsonProperty("permissions")]
        [JsonRequired]
        public Models.Permissions1 Permissions { get; set; }

        /// <summary>
        /// An object holding information about the capabilities of this API key.
        /// </summary>
        [JsonProperty("capabilities")]
        [JsonRequired]
        public Models.Capabilities7 Capabilities { get; set; }

        /// <summary>
        /// An array of IP's this API key can make calls from.
        /// </summary>
        [JsonConverter(typeof(CoreListConverter), typeof(JsonStringConverter))]
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Include)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ApiKeyState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the hub's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.HubEvents1 Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApiKey : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApiKey other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
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
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.Permissions = {(this.Permissions == null ? "null" : this.Permissions.ToString())}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : this.Capabilities.ToString())}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
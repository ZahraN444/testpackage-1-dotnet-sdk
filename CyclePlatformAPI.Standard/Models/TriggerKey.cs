// <copyright file="TriggerKey.cs" company="APIMatic">
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
    /// TriggerKey.
    /// </summary>
    public class TriggerKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerKey"/> class.
        /// </summary>
        public TriggerKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerKey"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="secret">secret.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="pipelineId">pipeline_id.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="ips">ips.</param>
        public TriggerKey(
            string id,
            string name,
            string secret,
            Models.CreatorScope creator,
            string hubId,
            string pipelineId,
            Models.TriggerKeyState state,
            Models.TriggerKeyEvents events,
            List<string> ips)
        {
            this.Id = id;
            this.Name = name;
            this.Secret = secret;
            this.Creator = creator;
            this.HubId = hubId;
            this.PipelineId = pipelineId;
            this.State = state;
            this.Events = events;
            this.Ips = ips;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// The name of the trigger key.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The secret used when calling the trigger key programmatically.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("secret")]
        [JsonRequired]
        public string Secret { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// The ID for the pipeline related to this trigger key.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("pipeline_id")]
        [JsonRequired]
        public string PipelineId { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.TriggerKeyState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the trigger key's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.TriggerKeyEvents Events { get; set; }

        /// <summary>
        /// An array of ips this trigger key is usable from.
        /// </summary>
        [JsonConverter(typeof(CoreListConverter), typeof(JsonStringConverter), true)]
        [JsonProperty("ips")]
        [JsonRequired]
        public List<string> Ips { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TriggerKey : ({string.Join(", ", toStringOutput)})";
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
            return obj is TriggerKey other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.PipelineId == null && other.PipelineId == null) || (this.PipelineId?.Equals(other.PipelineId) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.PipelineId = {(this.PipelineId == null ? "null" : this.PipelineId)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
        }
    }
}
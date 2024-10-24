// <copyright file="Pipeline.cs" company="APIMatic">
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
    /// Pipeline.
    /// </summary>
    public class Pipeline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline"/> class.
        /// </summary>
        public Pipeline()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pipeline"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="disable">disable.</param>
        /// <param name="mDynamic">dynamic.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="stages">stages.</param>
        public Pipeline(
            string id,
            string name,
            Models.CreatorScope creator,
            string hubId,
            bool disable,
            bool mDynamic,
            Models.PipelineEvents events,
            Models.PipelineState state,
            string identifier = null,
            List<Models.PipelineStage> stages = null)
        {
            this.Id = id;
            this.Identifier = identifier;
            this.Name = name;
            this.Creator = creator;
            this.HubId = hubId;
            this.Disable = disable;
            this.MDynamic = mDynamic;
            this.Stages = stages;
            this.Events = events;
            this.State = state;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// A name for the pipeline.
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
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A boolean where true signifies the pipeline is disabled.
        /// </summary>
        [JsonProperty("disable")]
        [JsonRequired]
        public bool Disable { get; set; }

        /// <summary>
        /// Setting to true enables variable and other advanced logic support on this pipeline. This is a one-way toggle. Once set to true, it cannot be set back to false.
        /// </summary>
        [JsonProperty("dynamic")]
        [JsonRequired]
        public bool MDynamic { get; set; }

        /// <summary>
        /// An array of stages.
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PipelineStage> Stages { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the pipeline's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.PipelineEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.PipelineState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Pipeline : ({string.Join(", ", toStringOutput)})";
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
            return obj is Pipeline other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                this.Disable.Equals(other.Disable) &&
                this.MDynamic.Equals(other.MDynamic) &&
                ((this.Stages == null && other.Stages == null) || (this.Stages?.Equals(other.Stages) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Disable = {this.Disable}");
            toStringOutput.Add($"this.MDynamic = {this.MDynamic}");
            toStringOutput.Add($"this.Stages = {(this.Stages == null ? "null" : $"[{string.Join(", ", this.Stages)} ]")}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}
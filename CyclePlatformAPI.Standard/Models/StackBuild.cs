// <copyright file="StackBuild.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// StackBuild.
    /// </summary>
    public class StackBuild
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuild"/> class.
        /// </summary>
        public StackBuild()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuild"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="stackId">stack_id.</param>
        /// <param name="about">about.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="spec">spec.</param>
        /// <param name="meta">meta.</param>
        public StackBuild(
            string id,
            string hubId,
            string stackId,
            Models.About1 about,
            Models.StackBuildInstructions instructions,
            Models.StackBuildEvents events,
            Models.StackBuildState state,
            StackBuildSpec spec = null,
            Models.StackBuildMeta meta = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.StackId = stackId;
            this.Spec = spec;
            this.About = about;
            this.Instructions = instructions;
            this.Events = events;
            this.State = state;
            this.Meta = meta;
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
        /// An identifier for the stack related to this build.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("stack_id")]
        [JsonRequired]
        public string StackId { get; set; }

        /// <summary>
        /// Gets or sets Spec.
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public StackBuildSpec Spec { get; set; }

        /// <summary>
        /// Information about the stack build.
        /// </summary>
        [JsonProperty("about")]
        [JsonRequired]
        public Models.About1 About { get; set; }

        /// <summary>
        /// Additional instructions used when generating this stack build.
        /// </summary>
        [JsonProperty("instructions")]
        [JsonRequired]
        public Models.StackBuildInstructions Instructions { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the stack build's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.StackBuildEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.StackBuildState State { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to a stack build.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StackBuildMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackBuild : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackBuild other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.StackId == null && other.StackId == null) || (this.StackId?.Equals(other.StackId) == true)) &&
                ((this.Spec == null && other.Spec == null) || (this.Spec?.Equals(other.Spec) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.StackId = {(this.StackId == null ? "null" : this.StackId)}");
            toStringOutput.Add($"Spec = {(this.Spec == null ? "null" : this.Spec.ToString())}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}
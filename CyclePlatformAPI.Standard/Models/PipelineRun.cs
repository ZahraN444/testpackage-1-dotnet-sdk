// <copyright file="PipelineRun.cs" company="APIMatic">
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
    /// PipelineRun.
    /// </summary>
    public class PipelineRun
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun"/> class.
        /// </summary>
        public PipelineRun()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="pipelineId">pipeline_id.</param>
        /// <param name="stages">stages.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="variables">variables.</param>
        public PipelineRun(
            string id,
            Models.CreatorScope creator,
            string hubId,
            string pipelineId,
            List<Models.Stage> stages,
            Models.PipelineRunState state,
            Models.PipelineRunEvents events,
            Dictionary<string, string> variables = null)
        {
            this.Id = id;
            this.Creator = creator;
            this.HubId = hubId;
            this.PipelineId = pipelineId;
            this.Stages = stages;
            this.State = state;
            this.Events = events;
            this.Variables = variables;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

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
        /// The ID for the pipeline this run belongs to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("pipeline_id")]
        [JsonRequired]
        public string PipelineId { get; set; }

        /// <summary>
        /// An array of pipeline stages.
        /// </summary>
        [JsonProperty("stages")]
        [JsonRequired]
        public List<Models.Stage> Stages { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.PipelineRunState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the pipeline run's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.PipelineRunEvents Events { get; set; }

        /// <summary>
        /// A map of variable values used during pipeline run.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Variables { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PipelineRun : ({string.Join(", ", toStringOutput)})";
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
            return obj is PipelineRun other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.PipelineId == null && other.PipelineId == null) || (this.PipelineId?.Equals(other.PipelineId) == true)) &&
                ((this.Stages == null && other.Stages == null) || (this.Stages?.Equals(other.Stages) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Variables == null && other.Variables == null) || (this.Variables?.Equals(other.Variables) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.PipelineId = {(this.PipelineId == null ? "null" : this.PipelineId)}");
            toStringOutput.Add($"this.Stages = {(this.Stages == null ? "null" : $"[{string.Join(", ", this.Stages)} ]")}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"Variables = {(this.Variables == null ? "null" : this.Variables.ToString())}");
        }
    }
}
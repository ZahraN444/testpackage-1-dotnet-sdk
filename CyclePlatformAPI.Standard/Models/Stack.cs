// <copyright file="Stack.cs" company="APIMatic">
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
    /// Stack.
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stack"/> class.
        /// </summary>
        public Stack()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="name">name.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="source">source.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="variables">variables.</param>
        /// <param name="meta">meta.</param>
        public Stack(
            string id,
            string identifier,
            string name,
            string hubId,
            Models.UserScope creator,
            StackSource source,
            Models.StackState state,
            Models.StackEvents events,
            Dictionary<string, string> variables = null,
            Models.StackMeta meta = null)
        {
            this.Id = id;
            this.Identifier = identifier;
            this.Name = name;
            this.HubId = hubId;
            this.Creator = creator;
            this.Source = source;
            this.State = state;
            this.Variables = variables;
            this.Events = events;
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
        /// A human readable slugged identifier for this stack.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// A user defined name for the stack resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A type of creator and a matching identifier.
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.UserScope Creator { get; set; }

        /// <summary>
        /// A source for a stack to be created from.
        /// </summary>
        [JsonProperty("source")]
        [JsonRequired]
        public StackSource Source { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.StackState State { get; set; }

        /// <summary>
        /// A map of default variable values used when building this stack. A variable can be added anywhere in a stack using the format `{{var}}` where `var` would be a key in this map.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Variables { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the Stacks lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.StackEvents Events { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to this stack.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StackMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stack : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stack other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Variables == null && other.Variables == null) || (this.Variables?.Equals(other.Variables) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
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
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"Variables = {(this.Variables == null ? "null" : this.Variables.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}
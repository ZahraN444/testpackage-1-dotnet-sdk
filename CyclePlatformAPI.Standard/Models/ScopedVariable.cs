// <copyright file="ScopedVariable.cs" company="APIMatic">
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
    /// ScopedVariable.
    /// </summary>
    public class ScopedVariable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariable"/> class.
        /// </summary>
        public ScopedVariable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariable"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="creator">creator.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="scope">scope.</param>
        /// <param name="access">access.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="source">source.</param>
        public ScopedVariable(
            string id,
            Models.CreatorScope creator,
            string hubId,
            string environmentId,
            string identifier,
            Models.ScopedVariableScope scope,
            Models.ScopedVariableAccess access,
            Models.ScopedVariableState state,
            Models.ScopedVariableEvents events,
            ScopedVariableSource source = null)
        {
            this.Id = id;
            this.Creator = creator;
            this.HubId = hubId;
            this.EnvironmentId = environmentId;
            this.Identifier = identifier;
            this.Scope = scope;
            this.Access = access;
            this.Source = source;
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
        /// An identifier used to reference the environment this resource is scoped to.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("environment_id")]
        [JsonRequired]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// Information about the assignment of the scoped variable and how it is invoked.
        /// </summary>
        [JsonProperty("scope")]
        [JsonRequired]
        public Models.ScopedVariableScope Scope { get; set; }

        /// <summary>
        /// The way the scoped variable is accessed.
        /// </summary>
        [JsonProperty("access")]
        [JsonRequired]
        public Models.ScopedVariableAccess Access { get; set; }

        /// <summary>
        /// The source or value of the scoped variable.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Include)]
        public ScopedVariableSource Source { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ScopedVariableState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the Scoped Variable's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.ScopedVariableEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ScopedVariable : ({string.Join(", ", toStringOutput)})";
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
            return obj is ScopedVariable other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                ((this.Access == null && other.Access == null) || (this.Access?.Equals(other.Access) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
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
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope.ToString())}");
            toStringOutput.Add($"this.Access = {(this.Access == null ? "null" : this.Access.ToString())}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}
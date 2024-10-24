// <copyright file="IndexComponent.cs" company="APIMatic">
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
    /// IndexComponent.
    /// </summary>
    public class IndexComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexComponent"/> class.
        /// </summary>
        public IndexComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexComponent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="contextBlobs">context_blobs.</param>
        /// <param name="associations">associations.</param>
        /// <param name="identifier">identifier.</param>
        public IndexComponent(
            string id,
            string name,
            string state,
            Dictionary<string, DateTime> events,
            List<string> contextBlobs,
            Models.Associations associations,
            string identifier = null)
        {
            this.Id = id;
            this.Name = name;
            this.Identifier = identifier;
            this.State = state;
            this.Events = events;
            this.ContextBlobs = contextBlobs;
            this.Associations = associations;
        }

        /// <summary>
        /// ID of the component
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the component
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// State of the component
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Describes the date and time at which certain events occurred in the lifetime of this resource.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(IsoDateTimeConverter))]
        [JsonProperty("events")]
        public Dictionary<string, DateTime> Events { get; set; }

        /// <summary>
        /// related strings for fuzzy search
        /// </summary>
        [JsonProperty("context_blobs")]
        public List<string> ContextBlobs { get; set; }

        /// <summary>
        /// Component associations
        /// </summary>
        [JsonProperty("associations")]
        public Models.Associations Associations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IndexComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is IndexComponent other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.ContextBlobs == null && other.ContextBlobs == null) || (this.ContextBlobs?.Equals(other.ContextBlobs) == true)) &&
                ((this.Associations == null && other.Associations == null) || (this.Associations?.Equals(other.Associations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.ContextBlobs = {(this.ContextBlobs == null ? "null" : $"[{string.Join(", ", this.ContextBlobs)} ]")}");
            toStringOutput.Add($"this.Associations = {(this.Associations == null ? "null" : this.Associations.ToString())}");
        }
    }
}
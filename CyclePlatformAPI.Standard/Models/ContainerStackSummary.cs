// <copyright file="ContainerStackSummary.cs" company="APIMatic">
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
    /// ContainerStackSummary.
    /// </summary>
    public class ContainerStackSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerStackSummary"/> class.
        /// </summary>
        public ContainerStackSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerStackSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="buildId">build_id.</param>
        /// <param name="identifier">identifier.</param>
        public ContainerStackSummary(
            string id = null,
            string buildId = null,
            string identifier = null)
        {
            this.Id = id;
            this.BuildId = buildId;
            this.Identifier = identifier;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the stack build this container is associated with.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        /// <summary>
        /// The container identifier, usually the key to the container section of a stack file.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerStackSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerStackSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.BuildId == null && other.BuildId == null) || (this.BuildId?.Equals(other.BuildId) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.BuildId = {(this.BuildId == null ? "null" : this.BuildId)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
        }
    }
}
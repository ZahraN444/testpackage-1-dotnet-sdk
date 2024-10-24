// <copyright file="SourceIncludes.cs" company="APIMatic">
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
    /// SourceIncludes.
    /// </summary>
    public class SourceIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceIncludes"/> class.
        /// </summary>
        public SourceIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="integrationsIdentifiers">integrations:identifiers.</param>
        public SourceIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.Integration> integrations = null,
            object integrationsIdentifiers = null)
        {
            this.Creators = creators;
            this.Integrations = integrations;
            this.IntegrationsIdentifiers = integrationsIdentifiers;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// A resource thats associated with an integration.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Integration> Integrations { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("integrations:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object IntegrationsIdentifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SourceIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is SourceIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Integrations == null && other.Integrations == null) || (this.Integrations?.Equals(other.Integrations) == true)) &&
                ((this.IntegrationsIdentifiers == null && other.IntegrationsIdentifiers == null) || (this.IntegrationsIdentifiers?.Equals(other.IntegrationsIdentifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
            toStringOutput.Add($"IntegrationsIdentifiers = {(this.IntegrationsIdentifiers == null ? "null" : this.IntegrationsIdentifiers.ToString())}");
        }
    }
}
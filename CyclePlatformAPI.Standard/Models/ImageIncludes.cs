// <copyright file="ImageIncludes.cs" company="APIMatic">
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
    /// ImageIncludes.
    /// </summary>
    public class ImageIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageIncludes"/> class.
        /// </summary>
        public ImageIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="stackBuilds">stack_builds.</param>
        /// <param name="stacks">stacks.</param>
        /// <param name="stacksIdentifiers">stacks:identifiers.</param>
        /// <param name="sources">sources.</param>
        /// <param name="sourcesIdentifiers">sources:identifiers.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="integrationsIdentifiers">integrations:identifiers.</param>
        public ImageIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.StackBuild> stackBuilds = null,
            Dictionary<string, Models.Stack> stacks = null,
            object stacksIdentifiers = null,
            Dictionary<string, Models.ImageSource> sources = null,
            object sourcesIdentifiers = null,
            Dictionary<string, Models.Integration> integrations = null,
            object integrationsIdentifiers = null)
        {
            this.Creators = creators;
            this.StackBuilds = stackBuilds;
            this.Stacks = stacks;
            this.StacksIdentifiers = stacksIdentifiers;
            this.Sources = sources;
            this.SourcesIdentifiers = sourcesIdentifiers;
            this.Integrations = integrations;
            this.IntegrationsIdentifiers = integrationsIdentifiers;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// A resource thats associated with a stack build.
        /// </summary>
        [JsonProperty("stack_builds", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.StackBuild> StackBuilds { get; set; }

        /// <summary>
        /// A resource associated with a stack.
        /// </summary>
        [JsonProperty("stacks", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Stack> Stacks { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("stacks:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object StacksIdentifiers { get; set; }

        /// <summary>
        /// A resource associated with an image source.
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ImageSource> Sources { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("sources:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object SourcesIdentifiers { get; set; }

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

            return $"ImageIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImageIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.StackBuilds == null && other.StackBuilds == null) || (this.StackBuilds?.Equals(other.StackBuilds) == true)) &&
                ((this.Stacks == null && other.Stacks == null) || (this.Stacks?.Equals(other.Stacks) == true)) &&
                ((this.StacksIdentifiers == null && other.StacksIdentifiers == null) || (this.StacksIdentifiers?.Equals(other.StacksIdentifiers) == true)) &&
                ((this.Sources == null && other.Sources == null) || (this.Sources?.Equals(other.Sources) == true)) &&
                ((this.SourcesIdentifiers == null && other.SourcesIdentifiers == null) || (this.SourcesIdentifiers?.Equals(other.SourcesIdentifiers) == true)) &&
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
            toStringOutput.Add($"StackBuilds = {(this.StackBuilds == null ? "null" : this.StackBuilds.ToString())}");
            toStringOutput.Add($"Stacks = {(this.Stacks == null ? "null" : this.Stacks.ToString())}");
            toStringOutput.Add($"StacksIdentifiers = {(this.StacksIdentifiers == null ? "null" : this.StacksIdentifiers.ToString())}");
            toStringOutput.Add($"Sources = {(this.Sources == null ? "null" : this.Sources.ToString())}");
            toStringOutput.Add($"SourcesIdentifiers = {(this.SourcesIdentifiers == null ? "null" : this.SourcesIdentifiers.ToString())}");
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
            toStringOutput.Add($"IntegrationsIdentifiers = {(this.IntegrationsIdentifiers == null ? "null" : this.IntegrationsIdentifiers.ToString())}");
        }
    }
}
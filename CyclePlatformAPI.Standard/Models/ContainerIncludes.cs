// <copyright file="ContainerIncludes.cs" company="APIMatic">
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
    /// ContainerIncludes.
    /// </summary>
    public class ContainerIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerIncludes"/> class.
        /// </summary>
        public ContainerIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="images">images.</param>
        /// <param name="stackBuilds">stack_builds.</param>
        /// <param name="stacks">stacks.</param>
        /// <param name="stacksIdentifiers">stacks:identifiers.</param>
        /// <param name="environments">environments.</param>
        /// <param name="environmentsIdentifiers">environments:identifiers.</param>
        public ContainerIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.Image> images = null,
            Dictionary<string, Models.StackBuild> stackBuilds = null,
            Dictionary<string, Models.Stack> stacks = null,
            object stacksIdentifiers = null,
            Dictionary<string, Models.Environment> environments = null,
            object environmentsIdentifiers = null)
        {
            this.Creators = creators;
            this.Images = images;
            this.StackBuilds = stackBuilds;
            this.Stacks = stacks;
            this.StacksIdentifiers = stacksIdentifiers;
            this.Environments = environments;
            this.EnvironmentsIdentifiers = environmentsIdentifiers;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// A resource associated with an image.
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Image> Images { get; set; }

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
        /// An identity that is associated with an environment.
        /// </summary>
        [JsonProperty("environments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Environment> Environments { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("environments:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object EnvironmentsIdentifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Images == null && other.Images == null) || (this.Images?.Equals(other.Images) == true)) &&
                ((this.StackBuilds == null && other.StackBuilds == null) || (this.StackBuilds?.Equals(other.StackBuilds) == true)) &&
                ((this.Stacks == null && other.Stacks == null) || (this.Stacks?.Equals(other.Stacks) == true)) &&
                ((this.StacksIdentifiers == null && other.StacksIdentifiers == null) || (this.StacksIdentifiers?.Equals(other.StacksIdentifiers) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true)) &&
                ((this.EnvironmentsIdentifiers == null && other.EnvironmentsIdentifiers == null) || (this.EnvironmentsIdentifiers?.Equals(other.EnvironmentsIdentifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"Images = {(this.Images == null ? "null" : this.Images.ToString())}");
            toStringOutput.Add($"StackBuilds = {(this.StackBuilds == null ? "null" : this.StackBuilds.ToString())}");
            toStringOutput.Add($"Stacks = {(this.Stacks == null ? "null" : this.Stacks.ToString())}");
            toStringOutput.Add($"StacksIdentifiers = {(this.StacksIdentifiers == null ? "null" : this.StacksIdentifiers.ToString())}");
            toStringOutput.Add($"Environments = {(this.Environments == null ? "null" : this.Environments.ToString())}");
            toStringOutput.Add($"EnvironmentsIdentifiers = {(this.EnvironmentsIdentifiers == null ? "null" : this.EnvironmentsIdentifiers.ToString())}");
        }
    }
}
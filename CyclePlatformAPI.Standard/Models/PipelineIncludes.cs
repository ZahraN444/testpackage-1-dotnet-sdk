// <copyright file="PipelineIncludes.cs" company="APIMatic">
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
    /// PipelineIncludes.
    /// </summary>
    public class PipelineIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineIncludes"/> class.
        /// </summary>
        public PipelineIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="name">name.</param>
        /// <param name="components">components.</param>
        /// <param name="componentsIdentifiers">components:identifiers.</param>
        public PipelineIncludes(
            Models.CreatorInclude creators = null,
            string name = null,
            Dictionary<string, PipelineIncludesComponents> components = null,
            object componentsIdentifiers = null)
        {
            this.Creators = creators;
            this.Name = name;
            this.Components = components;
            this.ComponentsIdentifiers = componentsIdentifiers;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// A name value.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A record of resources that can be associated with the pipeline.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PipelineIncludesComponents> Components { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("components:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object ComponentsIdentifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PipelineIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is PipelineIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.ComponentsIdentifiers == null && other.ComponentsIdentifiers == null) || (this.ComponentsIdentifiers?.Equals(other.ComponentsIdentifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Components = {(this.Components == null ? "null" : this.Components.ToString())}");
            toStringOutput.Add($"ComponentsIdentifiers = {(this.ComponentsIdentifiers == null ? "null" : this.ComponentsIdentifiers.ToString())}");
        }
    }
}
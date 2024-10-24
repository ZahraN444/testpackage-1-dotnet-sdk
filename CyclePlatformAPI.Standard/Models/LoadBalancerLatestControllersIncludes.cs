// <copyright file="LoadBalancerLatestControllersIncludes.cs" company="APIMatic">
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
    /// LoadBalancerLatestControllersIncludes.
    /// </summary>
    public class LoadBalancerLatestControllersIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestControllersIncludes"/> class.
        /// </summary>
        public LoadBalancerLatestControllersIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestControllersIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="stackBuilds">stack_builds.</param>
        /// <param name="stacks">stacks.</param>
        /// <param name="sources">sources.</param>
        public LoadBalancerLatestControllersIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.StackBuild> stackBuilds = null,
            Dictionary<string, Models.Stack> stacks = null,
            Dictionary<string, Models.ImageSource> sources = null)
        {
            this.Creators = creators;
            this.StackBuilds = stackBuilds;
            this.Stacks = stacks;
            this.Sources = sources;
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
        /// A resource associated with an image source.
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ImageSource> Sources { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerLatestControllersIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerLatestControllersIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.StackBuilds == null && other.StackBuilds == null) || (this.StackBuilds?.Equals(other.StackBuilds) == true)) &&
                ((this.Stacks == null && other.Stacks == null) || (this.Stacks?.Equals(other.Stacks) == true)) &&
                ((this.Sources == null && other.Sources == null) || (this.Sources?.Equals(other.Sources) == true));
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
            toStringOutput.Add($"Sources = {(this.Sources == null ? "null" : this.Sources.ToString())}");
        }
    }
}
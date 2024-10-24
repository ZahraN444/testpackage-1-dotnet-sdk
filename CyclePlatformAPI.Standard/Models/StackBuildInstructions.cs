// <copyright file="StackBuildInstructions.cs" company="APIMatic">
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
    /// StackBuildInstructions.
    /// </summary>
    public class StackBuildInstructions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildInstructions"/> class.
        /// </summary>
        public StackBuildInstructions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildInstructions"/> class.
        /// </summary>
        /// <param name="git">git.</param>
        /// <param name="variables">variables.</param>
        public StackBuildInstructions(
            Models.Git git = null,
            Dictionary<string, string> variables = null)
        {
            this.Git = git;
            this.Variables = variables;
        }

        /// <summary>
        /// Git information specifics.
        /// </summary>
        [JsonProperty("git", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Git Git { get; set; }

        /// <summary>
        /// Custom variables applied to the stack during build. Any place in the stack where a `{{variable}}` is used is replaced with the value of the variable supplied in this map.
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Variables { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackBuildInstructions : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackBuildInstructions other &&                ((this.Git == null && other.Git == null) || (this.Git?.Equals(other.Git) == true)) &&
                ((this.Variables == null && other.Variables == null) || (this.Variables?.Equals(other.Variables) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Git = {(this.Git == null ? "null" : this.Git.ToString())}");
            toStringOutput.Add($"Variables = {(this.Variables == null ? "null" : this.Variables.ToString())}");
        }
    }
}
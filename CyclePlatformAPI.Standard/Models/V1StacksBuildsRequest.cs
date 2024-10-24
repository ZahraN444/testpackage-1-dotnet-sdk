// <copyright file="V1StacksBuildsRequest.cs" company="APIMatic">
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
    /// V1StacksBuildsRequest.
    /// </summary>
    public class V1StacksBuildsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1StacksBuildsRequest"/> class.
        /// </summary>
        public V1StacksBuildsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1StacksBuildsRequest"/> class.
        /// </summary>
        /// <param name="about">about.</param>
        /// <param name="instructions">instructions.</param>
        public V1StacksBuildsRequest(
            Models.StackBuildAbout about = null,
            Models.StackBuildInstructions instructions = null)
        {
            this.About = about;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Information about the stack build.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StackBuildAbout About { get; set; }

        /// <summary>
        /// Additional instructions used when generating this stack build.
        /// </summary>
        [JsonProperty("instructions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StackBuildInstructions Instructions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1StacksBuildsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1StacksBuildsRequest other &&                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions.ToString())}");
        }
    }
}
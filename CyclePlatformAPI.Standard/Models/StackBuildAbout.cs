// <copyright file="StackBuildAbout.cs" company="APIMatic">
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
    /// StackBuildAbout.
    /// </summary>
    public class StackBuildAbout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildAbout"/> class.
        /// </summary>
        public StackBuildAbout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildAbout"/> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="description">description.</param>
        /// <param name="gitCommit">git_commit.</param>
        public StackBuildAbout(
            string version,
            string description,
            Models.StackGitCommit gitCommit = null)
        {
            this.Version = version;
            this.Description = description;
            this.GitCommit = gitCommit;
        }

        /// <summary>
        /// A user defined version of the build.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// A user defined description for the build.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information about the git commit this stack build was created from.
        /// </summary>
        [JsonProperty("git_commit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.StackGitCommit GitCommit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackBuildAbout : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackBuildAbout other &&                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.GitCommit == null && other.GitCommit == null) || (this.GitCommit?.Equals(other.GitCommit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.GitCommit = {(this.GitCommit == null ? "null" : this.GitCommit.ToString())}");
        }
    }
}
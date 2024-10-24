// <copyright file="Details5.cs" company="APIMatic">
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
    /// Details5.
    /// </summary>
    public class Details5
    {
        private string targzUrl;
        private string contextDir;
        private string buildFile;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "targz_url", false },
            { "context_dir", false },
            { "build_file", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details5"/> class.
        /// </summary>
        public Details5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details5"/> class.
        /// </summary>
        /// <param name="existing">existing.</param>
        /// <param name="repo">repo.</param>
        /// <param name="targzUrl">targz_url.</param>
        /// <param name="contextDir">context_dir.</param>
        /// <param name="buildFile">build_file.</param>
        /// <param name="credentials">credentials.</param>
        public Details5(
            Details5Existing existing = null,
            Details5Repo repo = null,
            string targzUrl = null,
            string contextDir = null,
            string buildFile = null,
            Details5Credentials credentials = null)
        {
            this.Existing = existing;
            this.Repo = repo;
            if (targzUrl != null)
            {
                this.TargzUrl = targzUrl;
            }

            if (contextDir != null)
            {
                this.ContextDir = contextDir;
            }

            if (buildFile != null)
            {
                this.BuildFile = buildFile;
            }

            this.Credentials = credentials;
        }

        /// <summary>
        /// Gets or sets Existing.
        /// </summary>
        [JsonProperty("existing", NullValueHandling = NullValueHandling.Ignore)]
        public Details5Existing Existing { get; set; }

        /// <summary>
        /// Gets or sets Repo.
        /// </summary>
        [JsonProperty("repo", NullValueHandling = NullValueHandling.Ignore)]
        public Details5Repo Repo { get; set; }

        /// <summary>
        /// An endpoint that serves the tar file.
        /// </summary>
        [JsonProperty("targz_url")]
        public string TargzUrl
        {
            get
            {
                return this.targzUrl;
            }

            set
            {
                this.shouldSerialize["targz_url"] = true;
                this.targzUrl = value;
            }
        }

        /// <summary>
        /// The path to the directory to use as the context when building the image.
        /// </summary>
        [JsonProperty("context_dir")]
        public string ContextDir
        {
            get
            {
                return this.contextDir;
            }

            set
            {
                this.shouldSerialize["context_dir"] = true;
                this.contextDir = value;
            }
        }

        /// <summary>
        /// The path to the Dockerfile to be used for buiding the image.
        /// </summary>
        [JsonProperty("build_file")]
        public string BuildFile
        {
            get
            {
                return this.buildFile;
            }

            set
            {
                this.shouldSerialize["build_file"] = true;
                this.buildFile = value;
            }
        }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Details5Credentials Credentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details5 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTargzUrl()
        {
            this.shouldSerialize["targz_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContextDir()
        {
            this.shouldSerialize["context_dir"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuildFile()
        {
            this.shouldSerialize["build_file"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTargzUrl()
        {
            return this.shouldSerialize["targz_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContextDir()
        {
            return this.shouldSerialize["context_dir"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuildFile()
        {
            return this.shouldSerialize["build_file"];
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
            return obj is Details5 other &&                ((this.Existing == null && other.Existing == null) || (this.Existing?.Equals(other.Existing) == true)) &&
                ((this.Repo == null && other.Repo == null) || (this.Repo?.Equals(other.Repo) == true)) &&
                ((this.TargzUrl == null && other.TargzUrl == null) || (this.TargzUrl?.Equals(other.TargzUrl) == true)) &&
                ((this.ContextDir == null && other.ContextDir == null) || (this.ContextDir?.Equals(other.ContextDir) == true)) &&
                ((this.BuildFile == null && other.BuildFile == null) || (this.BuildFile?.Equals(other.BuildFile) == true)) &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Existing = {(this.Existing == null ? "null" : this.Existing.ToString())}");
            toStringOutput.Add($"Repo = {(this.Repo == null ? "null" : this.Repo.ToString())}");
            toStringOutput.Add($"this.TargzUrl = {(this.TargzUrl == null ? "null" : this.TargzUrl)}");
            toStringOutput.Add($"this.ContextDir = {(this.ContextDir == null ? "null" : this.ContextDir)}");
            toStringOutput.Add($"this.BuildFile = {(this.BuildFile == null ? "null" : this.BuildFile)}");
            toStringOutput.Add($"Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
        }
    }
}
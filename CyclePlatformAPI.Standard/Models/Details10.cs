// <copyright file="Details10.cs" company="APIMatic">
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
    /// Details10.
    /// </summary>
    public class Details10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details10"/> class.
        /// </summary>
        public Details10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details10"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="url">url.</param>
        /// <param name="auth">auth.</param>
        /// <param name="existing">existing.</param>
        public Details10(
            string target,
            string url,
            Details10Auth auth,
            Models.ExistingSource existing = null)
        {
            this.Existing = existing;
            this.Target = target;
            this.Url = url;
            this.Auth = auth;
        }

        /// <summary>
        /// In a stack, specifies an image source ID from which Cycle will derive any values not specified in the stack file. This is useful for avoiding direct placement of credentials in a stack file, for example.
        /// </summary>
        [JsonProperty("existing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExistingSource Existing { get; set; }

        /// <summary>
        /// The image name on the registry.
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }

        /// <summary>
        /// The url of the remote registry.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Auth.
        /// </summary>
        [JsonProperty("auth")]
        public Details10Auth Auth { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details10 other &&                ((this.Existing == null && other.Existing == null) || (this.Existing?.Equals(other.Existing) == true)) &&
                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Existing = {(this.Existing == null ? "null" : this.Existing.ToString())}");
            toStringOutput.Add($"this.Target = {(this.Target == null ? "null" : this.Target)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
        }
    }
}
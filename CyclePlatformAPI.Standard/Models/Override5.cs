// <copyright file="Override5.cs" company="APIMatic">
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
    /// Override5.
    /// </summary>
    public class Override5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Override5"/> class.
        /// </summary>
        public Override5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Override5"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="targzUrl">targz_url.</param>
        public Override5(
            string target = null,
            string targzUrl = null)
        {
            this.Target = target;
            this.TargzUrl = targzUrl;
        }

        /// <summary>
        /// For Image sources with `docker-hub` or `docker-registry` origin types. A target to be used for overridding the default target - should include an Image and a tag.
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// For Image sources with `docker-file` origin types. A URL pointing to a .tar.gz file of a repo with a Dockerfile in it - can be used instead of linking Cycle directly to a repository.
        /// </summary>
        [JsonProperty("targz_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TargzUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Override5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Override5 other &&                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true)) &&
                ((this.TargzUrl == null && other.TargzUrl == null) || (this.TargzUrl?.Equals(other.TargzUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Target = {(this.Target == null ? "null" : this.Target)}");
            toStringOutput.Add($"this.TargzUrl = {(this.TargzUrl == null ? "null" : this.TargzUrl)}");
        }
    }
}
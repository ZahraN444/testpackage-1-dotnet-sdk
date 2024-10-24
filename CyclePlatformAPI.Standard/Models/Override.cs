// <copyright file="Override.cs" company="APIMatic">
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
    /// Override.
    /// </summary>
    public class Override
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Override"/> class.
        /// </summary>
        public Override()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Override"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="targzUrl">targz_url.</param>
        public Override(
            string target = null,
            string targzUrl = null)
        {
            this.Target = target;
            this.TargzUrl = targzUrl;
        }

        /// <summary>
        /// Gets or sets Target.
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets TargzUrl.
        /// </summary>
        [JsonProperty("targz_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TargzUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Override : ({string.Join(", ", toStringOutput)})";
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
            return obj is Override other &&                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true)) &&
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
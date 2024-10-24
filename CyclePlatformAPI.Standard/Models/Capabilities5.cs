// <copyright file="Capabilities5.cs" company="APIMatic">
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
    /// Capabilities5.
    /// </summary>
    public class Capabilities5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities5"/> class.
        /// </summary>
        public Capabilities5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities5"/> class.
        /// </summary>
        /// <param name="includes">includes.</param>
        /// <param name="excludes">excludes.</param>
        public Capabilities5(
            string includes = null,
            string excludes = null)
        {
            this.Includes = includes;
            this.Excludes = excludes;
        }

        /// <summary>
        /// Gets or sets Includes.
        /// </summary>
        [JsonProperty("includes", NullValueHandling = NullValueHandling.Ignore)]
        public string Includes { get; set; }

        /// <summary>
        /// Gets or sets Excludes.
        /// </summary>
        [JsonProperty("excludes", NullValueHandling = NullValueHandling.Ignore)]
        public string Excludes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Capabilities5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Capabilities5 other &&                ((this.Includes == null && other.Includes == null) || (this.Includes?.Equals(other.Includes) == true)) &&
                ((this.Excludes == null && other.Excludes == null) || (this.Excludes?.Equals(other.Excludes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Includes = {(this.Includes == null ? "null" : this.Includes)}");
            toStringOutput.Add($"this.Excludes = {(this.Excludes == null ? "null" : this.Excludes)}");
        }
    }
}
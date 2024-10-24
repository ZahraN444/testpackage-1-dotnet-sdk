// <copyright file="Deployment5.cs" company="APIMatic">
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
    /// Deployment5.
    /// </summary>
    public class Deployment5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment5"/> class.
        /// </summary>
        public Deployment5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment5"/> class.
        /// </summary>
        /// <param name="version">version.</param>
        public Deployment5(
            string version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Version can be any string, but if it begins with a "v", semantic version will be enforced. A [Semantic Version](https://semver.org/) string. Follows the format vMAJOR.MINOR.PATCH-build.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Deployment5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Deployment5 other &&                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
        }
    }
}
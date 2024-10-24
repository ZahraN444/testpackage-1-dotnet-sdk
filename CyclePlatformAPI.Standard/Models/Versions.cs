// <copyright file="Versions.cs" company="APIMatic">
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
    /// Versions.
    /// </summary>
    public class Versions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Versions"/> class.
        /// </summary>
        public Versions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Versions"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="containers">containers.</param>
        public Versions(
            List<string> tags,
            int containers)
        {
            this.Tags = tags;
            this.Containers = containers;
        }

        /// <summary>
        /// An array of all tags on this environment that point to this version.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The number of containers utilizing this version of this deployment.
        /// </summary>
        [JsonProperty("containers")]
        public int Containers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Versions : ({string.Join(", ", toStringOutput)})";
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
            return obj is Versions other &&                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                this.Containers.Equals(other.Containers);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Containers = {this.Containers}");
        }
    }
}
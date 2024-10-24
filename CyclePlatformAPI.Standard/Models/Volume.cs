// <copyright file="Volume.cs" company="APIMatic">
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
    /// Volume.
    /// </summary>
    public class Volume
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        public Volume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volume"/> class.
        /// </summary>
        /// <param name="path">path.</param>
        /// <param name="mode">mode.</param>
        public Volume(
            string path = null,
            Models.Mode3Enum? mode = null)
        {
            this.Path = path;
            this.Mode = mode;
        }

        /// <summary>
        /// The path where the volume is mounted.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// Permission settings for the volume.
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mode3Enum? Mode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Volume : ({string.Join(", ", toStringOutput)})";
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
            return obj is Volume other &&                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.Mode == null && other.Mode == null) || (this.Mode?.Equals(other.Mode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"this.Mode = {(this.Mode == null ? "null" : this.Mode.ToString())}");
        }
    }
}
// <copyright file="DirectImageSource.cs" company="APIMatic">
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
    /// DirectImageSource.
    /// </summary>
    public class DirectImageSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectImageSource"/> class.
        /// </summary>
        public DirectImageSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectImageSource"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        /// <param name="mOverride">override.</param>
        public DirectImageSource(
            Models.Type9Enum? type = null,
            Models.Details30 details = null,
            Models.Override mOverride = null)
        {
            this.Type = type;
            this.Details = details;
            this.MOverride = mOverride;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type9Enum? Type { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Details30 Details { get; set; }

        /// <summary>
        /// Gets or sets MOverride.
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Override MOverride { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectImageSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is DirectImageSource other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.MOverride == null && other.MOverride == null) || (this.MOverride?.Equals(other.MOverride) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details.ToString())}");
            toStringOutput.Add($"this.MOverride = {(this.MOverride == null ? "null" : this.MOverride.ToString())}");
        }
    }
}
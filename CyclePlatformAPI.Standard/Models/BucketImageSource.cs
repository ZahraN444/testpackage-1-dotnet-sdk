// <copyright file="BucketImageSource.cs" company="APIMatic">
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
    /// BucketImageSource.
    /// </summary>
    public class BucketImageSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketImageSource"/> class.
        /// </summary>
        public BucketImageSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketImageSource"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        /// <param name="mOverride">override.</param>
        public BucketImageSource(
            Models.Type10Enum? type = null,
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
        public Models.Type10Enum? Type { get; set; }

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

            return $"BucketImageSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is BucketImageSource other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
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
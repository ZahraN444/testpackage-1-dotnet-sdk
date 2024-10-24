// <copyright file="Contents2.cs" company="APIMatic">
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
    /// Contents2.
    /// </summary>
    public class Contents2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents2"/> class.
        /// </summary>
        public Contents2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents2"/> class.
        /// </summary>
        /// <param name="imageId">image_id.</param>
        /// <param name="allowIncompatible">allow_incompatible.</param>
        /// <param name="overwriteRuntimeConfig">overwrite_runtime_config.</param>
        public Contents2(
            string imageId,
            bool? allowIncompatible = null,
            bool? overwriteRuntimeConfig = null)
        {
            this.ImageId = imageId;
            this.AllowIncompatible = allowIncompatible;
            this.OverwriteRuntimeConfig = overwriteRuntimeConfig;
        }

        /// <summary>
        /// The ID of the image to use when reimaging.
        /// </summary>
        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// A boolean where true signifies the image being used to reimage does not have to have compatibility with the image being replaced.
        /// </summary>
        [JsonProperty("allow_incompatible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowIncompatible { get; set; }

        /// <summary>
        /// A boolean where true signifies the user wishes to overwrite the current runtime configuration for the given container during the reimage process.
        /// </summary>
        [JsonProperty("overwrite_runtime_config", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverwriteRuntimeConfig { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents2 other &&                ((this.ImageId == null && other.ImageId == null) || (this.ImageId?.Equals(other.ImageId) == true)) &&
                ((this.AllowIncompatible == null && other.AllowIncompatible == null) || (this.AllowIncompatible?.Equals(other.AllowIncompatible) == true)) &&
                ((this.OverwriteRuntimeConfig == null && other.OverwriteRuntimeConfig == null) || (this.OverwriteRuntimeConfig?.Equals(other.OverwriteRuntimeConfig) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ImageId = {(this.ImageId == null ? "null" : this.ImageId)}");
            toStringOutput.Add($"this.AllowIncompatible = {(this.AllowIncompatible == null ? "null" : this.AllowIncompatible.ToString())}");
            toStringOutput.Add($"this.OverwriteRuntimeConfig = {(this.OverwriteRuntimeConfig == null ? "null" : this.OverwriteRuntimeConfig.ToString())}");
        }
    }
}
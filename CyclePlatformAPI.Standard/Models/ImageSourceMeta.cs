// <copyright file="ImageSourceMeta.cs" company="APIMatic">
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
    /// ImageSourceMeta.
    /// </summary>
    public class ImageSourceMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSourceMeta"/> class.
        /// </summary>
        public ImageSourceMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSourceMeta"/> class.
        /// </summary>
        /// <param name="imagesCount">images_count.</param>
        public ImageSourceMeta(
            Models.ImagesCount imagesCount = null)
        {
            this.ImagesCount = imagesCount;
        }

        /// <summary>
        /// Gets or sets ImagesCount.
        /// </summary>
        [JsonProperty("images_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ImagesCount ImagesCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ImageSourceMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImageSourceMeta other &&                ((this.ImagesCount == null && other.ImagesCount == null) || (this.ImagesCount?.Equals(other.ImagesCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ImagesCount = {(this.ImagesCount == null ? "null" : this.ImagesCount.ToString())}");
        }
    }
}
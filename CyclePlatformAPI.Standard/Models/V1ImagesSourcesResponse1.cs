// <copyright file="V1ImagesSourcesResponse1.cs" company="APIMatic">
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
    /// V1ImagesSourcesResponse1.
    /// </summary>
    public class V1ImagesSourcesResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesSourcesResponse1"/> class.
        /// </summary>
        public V1ImagesSourcesResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesSourcesResponse1"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1ImagesSourcesResponse1(
            Models.ImageSource data)
        {
            this.Data = data;
        }

        /// <summary>
        /// An image source is a set of resources that direct the platform on where it can find the resources needed to build an image resource.
        /// </summary>
        [JsonProperty("data")]
        public Models.ImageSource Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ImagesSourcesResponse1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1ImagesSourcesResponse1 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}
// <copyright file="Details30.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Details30.
    /// </summary>
    public class Details30
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details30"/> class.
        /// </summary>
        public Details30()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details30"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="origin">origin.</param>
        public Details30(
            string id,
            ImageOrigin origin)
        {
            this.Id = id;
            this.Origin = origin;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The origin of the given image source.
        /// </summary>
        [JsonProperty("origin")]
        public ImageOrigin Origin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details30 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details30 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
        }
    }
}
// <copyright file="Details32.cs" company="APIMatic">
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
    /// Details32.
    /// </summary>
    public class Details32
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details32"/> class.
        /// </summary>
        public Details32()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details32"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="origin">origin.</param>
        /// <param name="about">about.</param>
        public Details32(
            string name,
            string type,
            ImageOrigin origin,
            Models.ImageSourceAbout about = null)
        {
            this.Name = name;
            this.Type = type;
            this.About = about;
            this.Origin = origin;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Information about the image source resource.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ImageSourceAbout About { get; set; }

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

            return $"Details32 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details32 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
        }
    }
}
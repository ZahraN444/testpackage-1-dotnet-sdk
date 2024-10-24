// <copyright file="V1ImagesSourcesRequest.cs" company="APIMatic">
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
    /// V1ImagesSourcesRequest.
    /// </summary>
    public class V1ImagesSourcesRequest
    {
        private Models.Builder builder;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "builder", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesSourcesRequest"/> class.
        /// </summary>
        public V1ImagesSourcesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesSourcesRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="origin">origin.</param>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="builder">builder.</param>
        /// <param name="about">about.</param>
        public V1ImagesSourcesRequest(
            Models.ImageSourceTypeEnum type,
            ImageOrigin origin,
            string name = null,
            string identifier = null,
            Models.Builder builder = null,
            Models.About6 about = null)
        {
            this.Name = name;
            this.Identifier = identifier;
            if (builder != null)
            {
                this.Builder = builder;
            }

            this.Type = type;
            this.Origin = origin;
            this.About = about;
        }

        /// <summary>
        /// A name for the Image Source.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets Builder.
        /// </summary>
        [JsonProperty("builder")]
        public Models.Builder Builder
        {
            get
            {
                return this.builder;
            }

            set
            {
                this.shouldSerialize["builder"] = true;
                this.builder = value;
            }
        }

        /// <summary>
        /// The type of images in this source.
        /// </summary>
        [JsonProperty("type")]
        public Models.ImageSourceTypeEnum Type { get; set; }

        /// <summary>
        /// The origin of the given image source.
        /// </summary>
        [JsonProperty("origin")]
        public ImageOrigin Origin { get; set; }

        /// <summary>
        /// User defined information about the Image Source.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.About6 About { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ImagesSourcesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuilder()
        {
            this.shouldSerialize["builder"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuilder()
        {
            return this.shouldSerialize["builder"];
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
            return obj is V1ImagesSourcesRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Builder == null && other.Builder == null) || (this.Builder?.Equals(other.Builder) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Builder = {(this.Builder == null ? "null" : this.Builder.ToString())}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
        }
    }
}
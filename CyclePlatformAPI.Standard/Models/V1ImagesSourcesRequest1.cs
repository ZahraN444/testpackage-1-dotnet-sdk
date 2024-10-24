// <copyright file="V1ImagesSourcesRequest1.cs" company="APIMatic">
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
    /// V1ImagesSourcesRequest1.
    /// </summary>
    public class V1ImagesSourcesRequest1
    {
        private Models.Builder4 builder;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "builder", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesSourcesRequest1"/> class.
        /// </summary>
        public V1ImagesSourcesRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesSourcesRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="origin">origin.</param>
        /// <param name="builder">builder.</param>
        /// <param name="about">about.</param>
        public V1ImagesSourcesRequest1(
            string name = null,
            ImageOrigin origin = null,
            Models.Builder4 builder = null,
            Models.About7 about = null)
        {
            this.Name = name;
            this.Origin = origin;
            if (builder != null)
            {
                this.Builder = builder;
            }

            this.About = about;
        }

        /// <summary>
        /// A name for the image source.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The origin of the given image source.
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public ImageOrigin Origin { get; set; }

        /// <summary>
        /// Gets or sets Builder.
        /// </summary>
        [JsonProperty("builder")]
        public Models.Builder4 Builder
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
        /// User defined information about the image source.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.About7 About { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ImagesSourcesRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1ImagesSourcesRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                ((this.Builder == null && other.Builder == null) || (this.Builder?.Equals(other.Builder) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
            toStringOutput.Add($"this.Builder = {(this.Builder == null ? "null" : this.Builder.ToString())}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
        }
    }
}
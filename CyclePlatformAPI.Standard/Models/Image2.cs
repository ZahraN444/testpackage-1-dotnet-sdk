// <copyright file="Image2.cs" company="APIMatic">
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
    /// Image2.
    /// </summary>
    public class Image2
    {
        private string name;
        private Models.Build build;
        private Models.Builder builder;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "build", false },
            { "builder", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Image2"/> class.
        /// </summary>
        public Image2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image2"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="origin">origin.</param>
        /// <param name="build">build.</param>
        /// <param name="builder">builder.</param>
        public Image2(
            string name = null,
            ImageOrigin origin = null,
            Models.Build build = null,
            Models.Builder builder = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            this.Origin = origin;
            if (build != null)
            {
                this.Build = build;
            }

            if (builder != null)
            {
                this.Builder = builder;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// The origin of the given image source.
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public ImageOrigin Origin { get; set; }

        /// <summary>
        /// Gets or sets Build.
        /// </summary>
        [JsonProperty("build")]
        public Models.Build Build
        {
            get
            {
                return this.build;
            }

            set
            {
                this.shouldSerialize["build"] = true;
                this.build = value;
            }
        }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Image2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuild()
        {
            this.shouldSerialize["build"] = false;
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
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuild()
        {
            return this.shouldSerialize["build"];
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
            return obj is Image2 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                ((this.Build == null && other.Build == null) || (this.Build?.Equals(other.Build) == true)) &&
                ((this.Builder == null && other.Builder == null) || (this.Builder?.Equals(other.Builder) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
            toStringOutput.Add($"this.Build = {(this.Build == null ? "null" : this.Build.ToString())}");
            toStringOutput.Add($"this.Builder = {(this.Builder == null ? "null" : this.Builder.ToString())}");
        }
    }
}
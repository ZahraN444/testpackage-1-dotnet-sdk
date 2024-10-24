// <copyright file="StackSpecTestContainer.cs" company="APIMatic">
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
    /// StackSpecTestContainer.
    /// </summary>
    public class StackSpecTestContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecTestContainer"/> class.
        /// </summary>
        public StackSpecTestContainer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecTestContainer"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="image">image.</param>
        /// <param name="config">config.</param>
        public StackSpecTestContainer(
            string name,
            StackSpecTestContainerImage image,
            Models.Config5 config = null)
        {
            this.Name = name;
            this.Image = image;
            this.Config = config;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Image.
        /// </summary>
        [JsonProperty("image")]
        public StackSpecTestContainerImage Image { get; set; }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Include)]
        public Models.Config5 Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackSpecTestContainer : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackSpecTestContainer other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}
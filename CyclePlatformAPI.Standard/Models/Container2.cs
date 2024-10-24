// <copyright file="Container2.cs" company="APIMatic">
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
    /// Container2.
    /// </summary>
    public class Container2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Container2"/> class.
        /// </summary>
        public Container2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Container2"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="state">state.</param>
        /// <param name="image">image.</param>
        /// <param name="environment">environment.</param>
        public Container2(
            string id,
            string name,
            Models.ContainerState state,
            Models.ContainerImageSummary image,
            Models.ContainerEnvironmentSummary environment)
        {
            this.Id = id;
            this.Name = name;
            this.State = state;
            this.Image = image;
            this.Environment = environment;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A user defined name for the container resource.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.ContainerState State { get; set; }

        /// <summary>
        /// The Id of the image and information on if it is a service.
        /// </summary>
        [JsonProperty("image")]
        public Models.ContainerImageSummary Image { get; set; }

        /// <summary>
        /// A summary of supplemental environment and network information specific to a container.
        /// </summary>
        [JsonProperty("environment")]
        public Models.ContainerEnvironmentSummary Environment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Container2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Container2 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment.ToString())}");
        }
    }
}
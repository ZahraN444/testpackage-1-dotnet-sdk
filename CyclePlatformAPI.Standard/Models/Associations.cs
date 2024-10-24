// <copyright file="Associations.cs" company="APIMatic">
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
    /// Associations.
    /// </summary>
    public class Associations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Associations"/> class.
        /// </summary>
        public Associations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Associations"/> class.
        /// </summary>
        /// <param name="container">container.</param>
        /// <param name="environment">environment.</param>
        /// <param name="imageSource">image-source.</param>
        /// <param name="image">image.</param>
        /// <param name="stack">stack.</param>
        /// <param name="server">server.</param>
        /// <param name="providerLocation">provider-location.</param>
        public Associations(
            string container = null,
            string environment = null,
            string imageSource = null,
            string image = null,
            string stack = null,
            string server = null,
            string providerLocation = null)
        {
            this.Container = container;
            this.Environment = environment;
            this.ImageSource = imageSource;
            this.Image = image;
            this.Stack = stack;
            this.Server = server;
            this.ProviderLocation = providerLocation;
        }

        /// <summary>
        /// Associated container Id
        /// </summary>
        [JsonProperty("container", NullValueHandling = NullValueHandling.Ignore)]
        public string Container { get; set; }

        /// <summary>
        /// Associated environment Id
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public string Environment { get; set; }

        /// <summary>
        /// Associated image source Id
        /// </summary>
        [JsonProperty("image-source", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSource { get; set; }

        /// <summary>
        /// Associated image Id
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// Associated stack Id
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public string Stack { get; set; }

        /// <summary>
        /// Associated server Id
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// Associated provider location Id
        /// </summary>
        [JsonProperty("provider-location", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderLocation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Associations : ({string.Join(", ", toStringOutput)})";
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
            return obj is Associations other &&                ((this.Container == null && other.Container == null) || (this.Container?.Equals(other.Container) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.ImageSource == null && other.ImageSource == null) || (this.ImageSource?.Equals(other.ImageSource) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Stack == null && other.Stack == null) || (this.Stack?.Equals(other.Stack) == true)) &&
                ((this.Server == null && other.Server == null) || (this.Server?.Equals(other.Server) == true)) &&
                ((this.ProviderLocation == null && other.ProviderLocation == null) || (this.ProviderLocation?.Equals(other.ProviderLocation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Container = {(this.Container == null ? "null" : this.Container)}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"this.ImageSource = {(this.ImageSource == null ? "null" : this.ImageSource)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.Stack = {(this.Stack == null ? "null" : this.Stack)}");
            toStringOutput.Add($"this.Server = {(this.Server == null ? "null" : this.Server)}");
            toStringOutput.Add($"this.ProviderLocation = {(this.ProviderLocation == null ? "null" : this.ProviderLocation)}");
        }
    }
}
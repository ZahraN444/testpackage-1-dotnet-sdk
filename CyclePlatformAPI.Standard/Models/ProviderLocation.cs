// <copyright file="ProviderLocation.cs" company="APIMatic">
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
    /// ProviderLocation.
    /// </summary>
    public class ProviderLocation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderLocation"/> class.
        /// </summary>
        public ProviderLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderLocation"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="provider">provider.</param>
        /// <param name="compatible">compatible.</param>
        /// <param name="features">features.</param>
        /// <param name="abbreviation">abbreviation.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="geographic">geographic.</param>
        public ProviderLocation(
            string id,
            string name,
            Models.LocationProvider provider,
            bool compatible,
            Models.Features3 features,
            string abbreviation,
            object annotations,
            ProviderLocationGeographic geographic = null)
        {
            this.Id = id;
            this.Name = name;
            this.Geographic = geographic;
            this.Provider = provider;
            this.Compatible = compatible;
            this.Features = features;
            this.Abbreviation = abbreviation;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A name for the location.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Geographic.
        /// </summary>
        [JsonProperty("geographic", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderLocationGeographic Geographic { get; set; }

        /// <summary>
        /// Information about the locaiton of the provider.
        /// </summary>
        [JsonProperty("provider")]
        public Models.LocationProvider Provider { get; set; }

        /// <summary>
        /// A boolean where true means the locaiton is supported by the platform.
        /// </summary>
        [JsonProperty("compatible")]
        public bool Compatible { get; set; }

        /// <summary>
        /// Additional information about available and supported features of the provider location.
        /// </summary>
        [JsonProperty("features")]
        public Models.Features3 Features { get; set; }

        /// <summary>
        /// An abbreviation for the given provider locaiton.
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Additional information about the given provider locaiton.
        /// </summary>
        [JsonProperty("annotations")]
        public object Annotations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProviderLocation : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProviderLocation other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Geographic == null && other.Geographic == null) || (this.Geographic?.Equals(other.Geographic) == true)) &&
                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                this.Compatible.Equals(other.Compatible) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.Abbreviation == null && other.Abbreviation == null) || (this.Abbreviation?.Equals(other.Abbreviation) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Geographic = {(this.Geographic == null ? "null" : this.Geographic.ToString())}");
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.Compatible = {this.Compatible}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
            toStringOutput.Add($"this.Abbreviation = {(this.Abbreviation == null ? "null" : this.Abbreviation)}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
        }
    }
}
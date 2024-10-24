// <copyright file="EnvironmentAbout.cs" company="APIMatic">
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
    /// EnvironmentAbout.
    /// </summary>
    public class EnvironmentAbout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAbout"/> class.
        /// </summary>
        public EnvironmentAbout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAbout"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="favorite">favorite.</param>
        public EnvironmentAbout(
            string description,
            bool favorite)
        {
            this.Description = description;
            this.Favorite = favorite;
        }

        /// <summary>
        /// A custom description for this environment.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("description")]
        [JsonRequired]
        public string Description { get; set; }

        /// <summary>
        /// If true, this environment has been marked as a favorite.
        /// </summary>
        [JsonProperty("favorite")]
        [JsonRequired]
        public bool Favorite { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentAbout : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentAbout other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Favorite.Equals(other.Favorite);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Favorite = {this.Favorite}");
        }
    }
}
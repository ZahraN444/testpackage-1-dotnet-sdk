// <copyright file="About3.cs" company="APIMatic">
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
    /// About3.
    /// </summary>
    public class About3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="About3"/> class.
        /// </summary>
        public About3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="About3"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="favorite">favorite.</param>
        public About3(
            string description = null,
            bool? favorite = null)
        {
            this.Description = description;
            this.Favorite = favorite;
        }

        /// <summary>
        /// A custom description for this environment.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// If true, this environment has been marked as a favorite.
        /// </summary>
        [JsonProperty("favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Favorite { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"About3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is About3 other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Favorite == null && other.Favorite == null) || (this.Favorite?.Equals(other.Favorite) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Favorite = {(this.Favorite == null ? "null" : this.Favorite.ToString())}");
        }
    }
}
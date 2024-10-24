// <copyright file="ImagesCount.cs" company="APIMatic">
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
    /// ImagesCount.
    /// </summary>
    public class ImagesCount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesCount"/> class.
        /// </summary>
        public ImagesCount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesCount"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="state">state.</param>
        public ImagesCount(
            double total,
            Models.State7 state)
        {
            this.Total = total;
            this.State = state;
        }

        /// <summary>
        /// Number of image sources
        /// </summary>
        [JsonProperty("total")]
        public double Total { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.State7 State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ImagesCount : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImagesCount other &&                this.Total.Equals(other.Total) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}
// <copyright file="Features3.cs" company="APIMatic">
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
    /// Features3.
    /// </summary>
    public class Features3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Features3"/> class.
        /// </summary>
        public Features3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Features3"/> class.
        /// </summary>
        /// <param name="available">available.</param>
        /// <param name="supported">supported.</param>
        public Features3(
            List<string> available,
            List<string> supported)
        {
            this.Available = available;
            this.Supported = supported;
        }

        /// <summary>
        /// Available features for the provider location.
        /// </summary>
        [JsonProperty("available")]
        public List<string> Available { get; set; }

        /// <summary>
        /// Supported features for the provider location.
        /// </summary>
        [JsonProperty("supported")]
        public List<string> Supported { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Features3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Features3 other &&                ((this.Available == null && other.Available == null) || (this.Available?.Equals(other.Available) == true)) &&
                ((this.Supported == null && other.Supported == null) || (this.Supported?.Equals(other.Supported) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Available = {(this.Available == null ? "null" : $"[{string.Join(", ", this.Available)} ]")}");
            toStringOutput.Add($"this.Supported = {(this.Supported == null ? "null" : $"[{string.Join(", ", this.Supported)} ]")}");
        }
    }
}
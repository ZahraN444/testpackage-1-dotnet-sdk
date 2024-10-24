// <copyright file="File2.cs" company="APIMatic">
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
    /// File2.
    /// </summary>
    public class File2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File2"/> class.
        /// </summary>
        public File2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File2"/> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="destination">destination.</param>
        public File2(
            string source,
            string destination)
        {
            this.Source = source;
            this.Destination = destination;
        }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets Destination.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"File2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is File2 other &&                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination)}");
        }
    }
}
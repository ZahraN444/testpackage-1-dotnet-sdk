// <copyright file="Mounts.cs" company="APIMatic">
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
    /// Mounts.
    /// </summary>
    public class Mounts
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mounts"/> class.
        /// </summary>
        public Mounts()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mounts"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="options">options.</param>
        /// <param name="source">source.</param>
        public Mounts(
            string type,
            string options,
            string source)
        {
            this.Type = type;
            this.Options = options;
            this.Source = source;
        }

        /// <summary>
        /// String describing the server mount type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Comma separated string describing the server mount options.
        /// </summary>
        [JsonProperty("options")]
        public string Options { get; set; }

        /// <summary>
        /// String describing the server mount source.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Mounts : ({string.Join(", ", toStringOutput)})";
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
            return obj is Mounts other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options)}");
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
        }
    }
}
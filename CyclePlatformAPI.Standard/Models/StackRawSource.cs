// <copyright file="StackRawSource.cs" company="APIMatic">
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
    /// StackRawSource.
    /// </summary>
    public class StackRawSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackRawSource"/> class.
        /// </summary>
        public StackRawSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackRawSource"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        public StackRawSource(
            string type,
            StackRawSourceDetails details)
        {
            this.Type = type;
            this.Details = details;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details")]
        [JsonRequired]
        public StackRawSourceDetails Details { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackRawSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackRawSource other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : this.Details.ToString())}");
        }
    }
}
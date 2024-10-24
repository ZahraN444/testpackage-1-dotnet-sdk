// <copyright file="Details12.cs" company="APIMatic">
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
    /// Details12.
    /// </summary>
    public class Details12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details12"/> class.
        /// </summary>
        public Details12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details12"/> class.
        /// </summary>
        /// <param name="sourceId">source_id.</param>
        public Details12(
            string sourceId)
        {
            this.SourceId = sourceId;
        }

        /// <summary>
        /// The ID referencing the image source where this image originated.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details12 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details12 other &&                ((this.SourceId == null && other.SourceId == null) || (this.SourceId?.Equals(other.SourceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SourceId = {(this.SourceId == null ? "null" : this.SourceId)}");
        }
    }
}
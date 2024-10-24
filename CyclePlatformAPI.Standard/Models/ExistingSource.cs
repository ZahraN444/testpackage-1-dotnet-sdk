// <copyright file="ExistingSource.cs" company="APIMatic">
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
    /// ExistingSource.
    /// </summary>
    public class ExistingSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExistingSource"/> class.
        /// </summary>
        public ExistingSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExistingSource"/> class.
        /// </summary>
        /// <param name="sourceId">source_id.</param>
        public ExistingSource(
            string sourceId = null)
        {
            this.SourceId = sourceId;
        }

        /// <summary>
        /// The ID of the image source this image should be built from.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExistingSource : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExistingSource other &&                ((this.SourceId == null && other.SourceId == null) || (this.SourceId?.Equals(other.SourceId) == true));
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
// <copyright file="Details35.cs" company="APIMatic">
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
    /// Details35.
    /// </summary>
    public class Details35
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details35"/> class.
        /// </summary>
        public Details35()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details35"/> class.
        /// </summary>
        /// <param name="sourceIds">source_ids.</param>
        public Details35(
            List<string> sourceIds)
        {
            this.SourceIds = sourceIds;
        }

        /// <summary>
        /// Gets or sets SourceIds.
        /// </summary>
        [JsonProperty("source_ids")]
        public List<string> SourceIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details35 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details35 other &&                ((this.SourceIds == null && other.SourceIds == null) || (this.SourceIds?.Equals(other.SourceIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SourceIds = {(this.SourceIds == null ? "null" : $"[{string.Join(", ", this.SourceIds)} ]")}");
        }
    }
}
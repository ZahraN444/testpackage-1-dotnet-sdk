// <copyright file="Contents12.cs" company="APIMatic">
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
    /// Contents12.
    /// </summary>
    public class Contents12
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents12"/> class.
        /// </summary>
        public Contents12()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents12"/> class.
        /// </summary>
        /// <param name="sourceIds">source_ids.</param>
        public Contents12(
            List<string> sourceIds)
        {
            this.SourceIds = sourceIds;
        }

        /// <summary>
        /// A list of IDs to be pruned.
        /// </summary>
        [JsonProperty("source_ids")]
        public List<string> SourceIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents12 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents12 other &&                ((this.SourceIds == null && other.SourceIds == null) || (this.SourceIds?.Equals(other.SourceIds) == true));
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
// <copyright file="Filter.cs" company="APIMatic">
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
    /// Filter.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class.
        /// </summary>
        public Filter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter"/> class.
        /// </summary>
        /// <param name="resolved">resolved.</param>
        /// <param name="range">range.</param>
        public Filter(
            Models.ResolvedEnum? resolved = null,
            Models.Range2Enum? range = null)
        {
            this.Resolved = resolved;
            this.Range = range;
        }

        /// <summary>
        /// Get only Announcements that have been resolved, or only those that have not.
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResolvedEnum? Resolved { get; set; }

        /// <summary>
        /// The start date from when to fetch the Announcements
        /// </summary>
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Range2Enum? Range { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter other &&                ((this.Resolved == null && other.Resolved == null) || (this.Resolved?.Equals(other.Resolved) == true)) &&
                ((this.Range == null && other.Range == null) || (this.Range?.Equals(other.Range) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Resolved = {(this.Resolved == null ? "null" : this.Resolved.ToString())}");
            toStringOutput.Add($"this.Range = {(this.Range == null ? "null" : this.Range.ToString())}");
        }
    }
}
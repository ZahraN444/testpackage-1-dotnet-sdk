// <copyright file="Filter6.cs" company="APIMatic">
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
    /// Filter6.
    /// </summary>
    public class Filter6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter6"/> class.
        /// </summary>
        public Filter6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter6"/> class.
        /// </summary>
        /// <param name="rangeStart">range-start.</param>
        /// <param name="rangeEnd">range-end.</param>
        public Filter6(
            DateTime? rangeStart = null,
            DateTime? rangeEnd = null)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        /// <summary>
        /// The start date from when to pull instance telemetry data
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeStart { get; set; }

        /// <summary>
        /// The end date from when to pull instance telemetry data
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeEnd { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter6 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter6 other &&                ((this.RangeStart == null && other.RangeStart == null) || (this.RangeStart?.Equals(other.RangeStart) == true)) &&
                ((this.RangeEnd == null && other.RangeEnd == null) || (this.RangeEnd?.Equals(other.RangeEnd) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RangeStart = {(this.RangeStart == null ? "null" : this.RangeStart.ToString())}");
            toStringOutput.Add($"this.RangeEnd = {(this.RangeEnd == null ? "null" : this.RangeEnd.ToString())}");
        }
    }
}
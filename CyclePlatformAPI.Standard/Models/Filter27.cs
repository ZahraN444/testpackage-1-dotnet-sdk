// <copyright file="Filter27.cs" company="APIMatic">
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
    /// Filter27.
    /// </summary>
    public class Filter27
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter27"/> class.
        /// </summary>
        public Filter27()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter27"/> class.
        /// </summary>
        /// <param name="rangeStart">range-start.</param>
        /// <param name="rangeEnd">range-end.</param>
        /// <param name="search">search.</param>
        /// <param name="state">state.</param>
        public Filter27(
            DateTime? rangeStart = null,
            DateTime? rangeEnd = null,
            string search = null,
            string state = null)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
            this.Search = search;
            this.State = state;
        }

        /// <summary>
        /// The start date from when to fetch Jobs
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeStart { get; set; }

        /// <summary>
        /// The end date from when to fetch Jobs
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeEnd { get; set; }

        /// <summary>
        /// `filter[search]=value` search jobs for a value associated with a field on the given job(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the job's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter27 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter27 other &&                ((this.RangeStart == null && other.RangeStart == null) || (this.RangeStart?.Equals(other.RangeStart) == true)) &&
                ((this.RangeEnd == null && other.RangeEnd == null) || (this.RangeEnd?.Equals(other.RangeEnd) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RangeStart = {(this.RangeStart == null ? "null" : this.RangeStart.ToString())}");
            toStringOutput.Add($"this.RangeEnd = {(this.RangeEnd == null ? "null" : this.RangeEnd.ToString())}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
        }
    }
}
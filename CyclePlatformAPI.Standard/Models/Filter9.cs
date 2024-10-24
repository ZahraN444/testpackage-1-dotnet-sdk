// <copyright file="Filter9.cs" company="APIMatic">
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
    /// Filter9.
    /// </summary>
    public class Filter9
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter9"/> class.
        /// </summary>
        public Filter9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter9"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="search">search.</param>
        /// <param name="server">server.</param>
        /// <param name="rangeStart">range-start.</param>
        /// <param name="rangeEnd">range-end.</param>
        public Filter9(
            string state = null,
            string search = null,
            string server = null,
            DateTime? rangeStart = null,
            DateTime? rangeEnd = null)
        {
            this.State = state;
            this.Search = search;
            this.Server = server;
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the instance's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[search]=value` search instances for a value associated with a field on the given instance(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[server]=ID` server filtering by ID. Submit the ID of the server you wish to filter for and the return will be any instances of the container currently deployed to the given server.
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// The start date from when to pull the instances
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeStart { get; set; }

        /// <summary>
        /// The end date from when to pull the instances
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeEnd { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter9 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter9 other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.Server == null && other.Server == null) || (this.Server?.Equals(other.Server) == true)) &&
                ((this.RangeStart == null && other.RangeStart == null) || (this.RangeStart?.Equals(other.RangeStart) == true)) &&
                ((this.RangeEnd == null && other.RangeEnd == null) || (this.RangeEnd?.Equals(other.RangeEnd) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.Server = {(this.Server == null ? "null" : this.Server)}");
            toStringOutput.Add($"this.RangeStart = {(this.RangeStart == null ? "null" : this.RangeStart.ToString())}");
            toStringOutput.Add($"this.RangeEnd = {(this.RangeEnd == null ? "null" : this.RangeEnd.ToString())}");
        }
    }
}
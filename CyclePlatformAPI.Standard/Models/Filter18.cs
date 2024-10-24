// <copyright file="Filter18.cs" company="APIMatic">
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
    /// Filter18.
    /// </summary>
    public class Filter18
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter18"/> class.
        /// </summary>
        public Filter18()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter18"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="search">search.</param>
        /// <param name="state">state.</param>
        /// <param name="sourceType">source_type.</param>
        /// <param name="sourceId">source_id.</param>
        public Filter18(
            string identifier = null,
            string search = null,
            string state = null,
            string sourceType = null,
            string sourceId = null)
        {
            this.Identifier = identifier;
            this.Search = search;
            this.State = state;
            this.SourceType = sourceType;
            this.SourceId = sourceId;
        }

        /// <summary>
        /// `filter[identifier]=value` List only those images matching this identifier. May return multiple results.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// `filter[search]=value` search for a value associated with a field on the given Image(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the Image's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[source_type]=value` filter images by the Image source's type.  Can be: `direct` or `stack_build`
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// `filter[source_id]=ID` Image filtering by source ID.  Submit the ID of the Image source you wish to filter for and the return will be any Images created from that source.
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter18 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter18 other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.SourceType == null && other.SourceType == null) || (this.SourceType?.Equals(other.SourceType) == true)) &&
                ((this.SourceId == null && other.SourceId == null) || (this.SourceId?.Equals(other.SourceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.SourceType = {(this.SourceType == null ? "null" : this.SourceType)}");
            toStringOutput.Add($"this.SourceId = {(this.SourceId == null ? "null" : this.SourceId)}");
        }
    }
}
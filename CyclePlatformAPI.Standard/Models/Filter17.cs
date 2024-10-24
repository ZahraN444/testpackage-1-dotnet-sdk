// <copyright file="Filter17.cs" company="APIMatic">
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
    /// Filter17.
    /// </summary>
    public class Filter17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter17"/> class.
        /// </summary>
        public Filter17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter17"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="search">search.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="category">category.</param>
        public Filter17(
            string state = null,
            string search = null,
            string identifier = null,
            string category = null)
        {
            this.State = state;
            this.Search = search;
            this.Identifier = identifier;
            this.Category = category;
        }

        /// <summary>
        /// `filter[state]=value` Filters integrations by their current state. For example, `filter[state]=active` would return only integrations in an active state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[search]=value` Performs a text search across relevant fields of the integrations. For example, `filter[search]=example` would return integrations that have "example" in any of the searchable fields
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[identifier]=value` Filters integrations by their identifier. For example, `filter[identifier]=abstraction` would return only integrations with the abstraction identifier.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// `filter[category]=value` Filters integrations by their category. For example, `filter[category]=infrastructure-provider` would return only integrations that are capable of provisioning infrastructure.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter17 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter17 other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category)}");
        }
    }
}
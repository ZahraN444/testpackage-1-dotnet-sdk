// <copyright file="Filter7.cs" company="APIMatic">
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
    /// Filter7.
    /// </summary>
    public class Filter7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter7"/> class.
        /// </summary>
        public Filter7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter7"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="search">search.</param>
        /// <param name="state">state.</param>
        public Filter7(
            string identifier = null,
            string search = null,
            string state = null)
        {
            this.Identifier = identifier;
            this.Search = search;
            this.State = state;
        }

        /// <summary>
        /// `filter[identifier]=value` List only those environments matching this identifier. May return multiple results.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// `filter[search]=value` search for a value associated with a field on the given Scoped Variable(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the Scoped Variable's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter7 other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
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
        }
    }
}
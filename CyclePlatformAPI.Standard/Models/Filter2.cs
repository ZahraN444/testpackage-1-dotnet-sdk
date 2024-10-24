// <copyright file="Filter2.cs" company="APIMatic">
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
    /// Filter2.
    /// </summary>
    public class Filter2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter2"/> class.
        /// </summary>
        public Filter2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter2"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="search">search.</param>
        public Filter2(
            string state = null,
            string search = null)
        {
            this.State = state;
            this.Search = search;
        }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the credit's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Use a text-based search to filter the credits.
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter2 other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
        }
    }
}
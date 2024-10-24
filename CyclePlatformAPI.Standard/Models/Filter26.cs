// <copyright file="Filter26.cs" company="APIMatic">
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
    /// Filter26.
    /// </summary>
    public class Filter26
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter26"/> class.
        /// </summary>
        public Filter26()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter26"/> class.
        /// </summary>
        /// <param name="available">available.</param>
        /// <param name="state">state.</param>
        public Filter26(
            string available = null,
            string state = null)
        {
            this.Available = available;
            this.State = state;
        }

        /// <summary>
        /// `filter[available]=true` filter for IPs that are available for use.
        /// </summary>
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public string Available { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the IP's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter26 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter26 other &&                ((this.Available == null && other.Available == null) || (this.Available?.Equals(other.Available) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Available = {(this.Available == null ? "null" : this.Available)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
        }
    }
}
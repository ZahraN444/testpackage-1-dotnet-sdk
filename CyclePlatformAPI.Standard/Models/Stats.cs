// <copyright file="Stats.cs" company="APIMatic">
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
    /// Stats.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        public Stats()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="total">total.</param>
        /// <param name="available">available.</param>
        public Stats(
            Dictionary<string, int> state = null,
            int? total = null,
            int? available = null)
        {
            this.State = state;
            this.Total = total;
            this.Available = available;
        }

        /// <summary>
        /// A count of this resource, grouped by state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int> State { get; set; }

        /// <summary>
        /// The total number of this resource
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// The total number of this resource available, less any deleted ones.
        /// </summary>
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public int? Available { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stats : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stats other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Total == null && other.Total == null) || (this.Total?.Equals(other.Total) == true)) &&
                ((this.Available == null && other.Available == null) || (this.Available?.Equals(other.Available) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Total = {(this.Total == null ? "null" : this.Total.ToString())}");
            toStringOutput.Add($"this.Available = {(this.Available == null ? "null" : this.Available.ToString())}");
        }
    }
}
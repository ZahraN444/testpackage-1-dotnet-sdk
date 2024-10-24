// <copyright file="ResourceCountSummary.cs" company="APIMatic">
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
    /// ResourceCountSummary.
    /// </summary>
    public class ResourceCountSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCountSummary"/> class.
        /// </summary>
        public ResourceCountSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCountSummary"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="total">total.</param>
        /// <param name="available">available.</param>
        public ResourceCountSummary(
            Dictionary<string, int> state,
            int total,
            int available)
        {
            this.State = state;
            this.Total = total;
            this.Available = available;
        }

        /// <summary>
        /// A count of this resource, grouped by state.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Dictionary<string, int> State { get; set; }

        /// <summary>
        /// The total number of this resource
        /// </summary>
        [JsonProperty("total")]
        [JsonRequired]
        public int Total { get; set; }

        /// <summary>
        /// The total number of this resource available, less any deleted ones.
        /// </summary>
        [JsonProperty("available")]
        [JsonRequired]
        public int Available { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResourceCountSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResourceCountSummary other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                this.Total.Equals(other.Total) &&
                this.Available.Equals(other.Available);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.Available = {this.Available}");
        }
    }
}
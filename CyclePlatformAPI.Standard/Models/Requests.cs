// <copyright file="Requests.cs" company="APIMatic">
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
    /// Requests.
    /// </summary>
    public class Requests
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Requests"/> class.
        /// </summary>
        public Requests()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Requests"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="responses">responses.</param>
        /// <param name="errors">errors.</param>
        public Requests(
            int total,
            Dictionary<string, int> responses = null,
            Dictionary<string, int> errors = null)
        {
            this.Total = total;
            this.Responses = responses;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or sets Total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets Responses.
        /// </summary>
        [JsonProperty("responses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int> Responses { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Requests : ({string.Join(", ", toStringOutput)})";
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
            return obj is Requests other &&                this.Total.Equals(other.Total) &&
                ((this.Responses == null && other.Responses == null) || (this.Responses?.Equals(other.Responses) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"Responses = {(this.Responses == null ? "null" : this.Responses.ToString())}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : this.Errors.ToString())}");
        }
    }
}
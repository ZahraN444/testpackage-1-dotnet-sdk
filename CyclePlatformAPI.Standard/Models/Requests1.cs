// <copyright file="Requests1.cs" company="APIMatic">
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
    /// Requests1.
    /// </summary>
    public class Requests1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Requests1"/> class.
        /// </summary>
        public Requests1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Requests1"/> class.
        /// </summary>
        /// <param name="host">host.</param>
        /// <param name="method">method.</param>
        /// <param name="path">path.</param>
        /// <param name="total">total.</param>
        /// <param name="lastHit">last_hit.</param>
        /// <param name="handlers">handlers.</param>
        /// <param name="responses">responses.</param>
        /// <param name="errors">errors.</param>
        public Requests1(
            string host,
            string method,
            string path,
            int total,
            DateTime lastHit,
            Models.Handlers handlers,
            Dictionary<string, int> responses = null,
            Dictionary<string, int> errors = null)
        {
            this.Host = host;
            this.Method = method;
            this.Path = path;
            this.Total = total;
            this.LastHit = lastHit;
            this.Handlers = handlers;
            this.Responses = responses;
            this.Errors = errors;
        }

        /// <summary>
        /// The host name of the URL request.
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        /// The HTTP method of the URL request.
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// The path portion of the inbound URL request.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// The number of requests to a this URL.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// The date of the most recent hit to the URL.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_hit")]
        public DateTime LastHit { get; set; }

        /// <summary>
        /// An object describing the relative breakdown of proxy, cache, forward, and redirect URL responses.
        /// </summary>
        [JsonProperty("handlers")]
        public Models.Handlers Handlers { get; set; }

        /// <summary>
        /// An object where the key is the response type and the value is the number of hits with that response.
        /// </summary>
        [JsonProperty("responses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int> Responses { get; set; }

        /// <summary>
        /// An object where the key is the error type and the value is the number of hits with that error.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int> Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Requests1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Requests1 other &&                ((this.Host == null && other.Host == null) || (this.Host?.Equals(other.Host) == true)) &&
                ((this.Method == null && other.Method == null) || (this.Method?.Equals(other.Method) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                this.Total.Equals(other.Total) &&
                this.LastHit.Equals(other.LastHit) &&
                ((this.Handlers == null && other.Handlers == null) || (this.Handlers?.Equals(other.Handlers) == true)) &&
                ((this.Responses == null && other.Responses == null) || (this.Responses?.Equals(other.Responses) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Host = {(this.Host == null ? "null" : this.Host)}");
            toStringOutput.Add($"this.Method = {(this.Method == null ? "null" : this.Method)}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.LastHit = {this.LastHit}");
            toStringOutput.Add($"this.Handlers = {(this.Handlers == null ? "null" : this.Handlers.ToString())}");
            toStringOutput.Add($"Responses = {(this.Responses == null ? "null" : this.Responses.ToString())}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : this.Errors.ToString())}");
        }
    }
}
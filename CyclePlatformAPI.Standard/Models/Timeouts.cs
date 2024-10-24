// <copyright file="Timeouts.cs" company="APIMatic">
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
    /// Timeouts.
    /// </summary>
    public class Timeouts
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts"/> class.
        /// </summary>
        public Timeouts()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts"/> class.
        /// </summary>
        /// <param name="clientSecs">client_secs.</param>
        /// <param name="clientFinMs">client_fin_ms.</param>
        /// <param name="httpKeepAliveMs">http_keep_alive_ms.</param>
        /// <param name="httpRequestMs">http_request_ms.</param>
        public Timeouts(
            int? clientSecs = null,
            int? clientFinMs = null,
            int? httpKeepAliveMs = null,
            int? httpRequestMs = null)
        {
            this.ClientSecs = clientSecs;
            this.ClientFinMs = clientFinMs;
            this.HttpKeepAliveMs = httpKeepAliveMs;
            this.HttpRequestMs = httpRequestMs;
        }

        /// <summary>
        /// The number of seconds the load balancer will wait for a response from a client before disconnecting.
        /// </summary>
        [JsonProperty("client_secs", NullValueHandling = NullValueHandling.Include)]
        public int? ClientSecs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will wait for a client to send it data when one direction is already closed. This is particularly useful to avoid keeping connections in a waiting state for too long when clients do not disconnect cleanly.
        /// </summary>
        [JsonProperty("client_fin_ms", NullValueHandling = NullValueHandling.Include)]
        public int? ClientFinMs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will wait for a new HTTP request to start coming after a response was set. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.2-timeout%20http-request) for more information. (`http` mode only)
        /// </summary>
        [JsonProperty("http_keep_alive_ms", NullValueHandling = NullValueHandling.Include)]
        public int? HttpKeepAliveMs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will wait for a complete HTTP request. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.2-timeout%20http-request) for more information. (`http` mode only)
        /// </summary>
        [JsonProperty("http_request_ms", NullValueHandling = NullValueHandling.Include)]
        public int? HttpRequestMs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Timeouts : ({string.Join(", ", toStringOutput)})";
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
            return obj is Timeouts other &&                ((this.ClientSecs == null && other.ClientSecs == null) || (this.ClientSecs?.Equals(other.ClientSecs) == true)) &&
                ((this.ClientFinMs == null && other.ClientFinMs == null) || (this.ClientFinMs?.Equals(other.ClientFinMs) == true)) &&
                ((this.HttpKeepAliveMs == null && other.HttpKeepAliveMs == null) || (this.HttpKeepAliveMs?.Equals(other.HttpKeepAliveMs) == true)) &&
                ((this.HttpRequestMs == null && other.HttpRequestMs == null) || (this.HttpRequestMs?.Equals(other.HttpRequestMs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientSecs = {(this.ClientSecs == null ? "null" : this.ClientSecs.ToString())}");
            toStringOutput.Add($"this.ClientFinMs = {(this.ClientFinMs == null ? "null" : this.ClientFinMs.ToString())}");
            toStringOutput.Add($"this.HttpKeepAliveMs = {(this.HttpKeepAliveMs == null ? "null" : this.HttpKeepAliveMs.ToString())}");
            toStringOutput.Add($"this.HttpRequestMs = {(this.HttpRequestMs == null ? "null" : this.HttpRequestMs.ToString())}");
        }
    }
}
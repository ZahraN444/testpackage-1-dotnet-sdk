// <copyright file="Handlers.cs" company="APIMatic">
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
    /// Handlers.
    /// </summary>
    public class Handlers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Handlers"/> class.
        /// </summary>
        public Handlers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Handlers"/> class.
        /// </summary>
        /// <param name="proxy">proxy.</param>
        /// <param name="cache">cache.</param>
        /// <param name="forward">forward.</param>
        /// <param name="redirect">redirect.</param>
        public Handlers(
            Models.LoadBalancerTelemetryUrlRequestHandler1 proxy,
            Models.LoadBalancerTelemetryUrlRequestHandler2 cache,
            Models.LoadBalancerTelemetryUrlRequestHandler3 forward,
            Models.LoadBalancerTelemetryUrlRequestHandler4 redirect)
        {
            this.Proxy = proxy;
            this.Cache = cache;
            this.Forward = forward;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Object containing hit count and timing data for proxy responses.
        /// </summary>
        [JsonProperty("proxy")]
        public Models.LoadBalancerTelemetryUrlRequestHandler1 Proxy { get; set; }

        /// <summary>
        /// Object containing hit count and timing data for cache responses.
        /// </summary>
        [JsonProperty("cache")]
        public Models.LoadBalancerTelemetryUrlRequestHandler2 Cache { get; set; }

        /// <summary>
        /// Object containing hit count and timing data for forward responses.
        /// </summary>
        [JsonProperty("forward")]
        public Models.LoadBalancerTelemetryUrlRequestHandler3 Forward { get; set; }

        /// <summary>
        /// Object containing hit count and timing data for redirect responses.
        /// </summary>
        [JsonProperty("redirect")]
        public Models.LoadBalancerTelemetryUrlRequestHandler4 Redirect { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Handlers : ({string.Join(", ", toStringOutput)})";
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
            return obj is Handlers other &&                ((this.Proxy == null && other.Proxy == null) || (this.Proxy?.Equals(other.Proxy) == true)) &&
                ((this.Cache == null && other.Cache == null) || (this.Cache?.Equals(other.Cache) == true)) &&
                ((this.Forward == null && other.Forward == null) || (this.Forward?.Equals(other.Forward) == true)) &&
                ((this.Redirect == null && other.Redirect == null) || (this.Redirect?.Equals(other.Redirect) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Proxy = {(this.Proxy == null ? "null" : this.Proxy.ToString())}");
            toStringOutput.Add($"this.Cache = {(this.Cache == null ? "null" : this.Cache.ToString())}");
            toStringOutput.Add($"this.Forward = {(this.Forward == null ? "null" : this.Forward.ToString())}");
            toStringOutput.Add($"this.Redirect = {(this.Redirect == null ? "null" : this.Redirect.ToString())}");
        }
    }
}
// <copyright file="Timeouts1.cs" company="APIMatic">
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
    /// Timeouts1.
    /// </summary>
    public class Timeouts1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts1"/> class.
        /// </summary>
        public Timeouts1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts1"/> class.
        /// </summary>
        /// <param name="serverSecs">server_secs.</param>
        /// <param name="serverFinMs">server_fin_ms.</param>
        /// <param name="connectMs">connect_ms.</param>
        /// <param name="queueMs">queue_ms.</param>
        /// <param name="tunnelSecs">tunnel_secs.</param>
        public Timeouts1(
            int? serverSecs = null,
            int? serverFinMs = null,
            int? connectMs = null,
            int? queueMs = null,
            int? tunnelSecs = null)
        {
            this.ServerSecs = serverSecs;
            this.ServerFinMs = serverFinMs;
            this.ConnectMs = connectMs;
            this.QueueMs = queueMs;
            this.TunnelSecs = tunnelSecs;
        }

        /// <summary>
        /// The number of seconds the load balancer will wait for a response from the container instance. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.2-timeout%20server) for more information.
        /// </summary>
        [JsonProperty("server_secs", NullValueHandling = NullValueHandling.Include)]
        public int? ServerSecs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will wait for the server to send data when one direction is already closed. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20server-fin) for more information.
        /// </summary>
        [JsonProperty("server_fin_ms", NullValueHandling = NullValueHandling.Include)]
        public int? ServerFinMs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will wait for a successful connection to a container instance. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20connect) for more information.
        /// </summary>
        [JsonProperty("connect_ms", NullValueHandling = NullValueHandling.Include)]
        public int? ConnectMs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will hold connections in a queue when the maximum number of connections has been reached. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20queue) for more information.
        /// </summary>
        [JsonProperty("queue_ms", NullValueHandling = NullValueHandling.Include)]
        public int? QueueMs { get; set; }

        /// <summary>
        /// The number of milliseconds the load balancer will allow for inactivity on a bidirectional tunnel. See the [HAProxy Docs](https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4-timeout%20tunnel) for more information.
        /// </summary>
        [JsonProperty("tunnel_secs", NullValueHandling = NullValueHandling.Include)]
        public int? TunnelSecs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Timeouts1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Timeouts1 other &&                ((this.ServerSecs == null && other.ServerSecs == null) || (this.ServerSecs?.Equals(other.ServerSecs) == true)) &&
                ((this.ServerFinMs == null && other.ServerFinMs == null) || (this.ServerFinMs?.Equals(other.ServerFinMs) == true)) &&
                ((this.ConnectMs == null && other.ConnectMs == null) || (this.ConnectMs?.Equals(other.ConnectMs) == true)) &&
                ((this.QueueMs == null && other.QueueMs == null) || (this.QueueMs?.Equals(other.QueueMs) == true)) &&
                ((this.TunnelSecs == null && other.TunnelSecs == null) || (this.TunnelSecs?.Equals(other.TunnelSecs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServerSecs = {(this.ServerSecs == null ? "null" : this.ServerSecs.ToString())}");
            toStringOutput.Add($"this.ServerFinMs = {(this.ServerFinMs == null ? "null" : this.ServerFinMs.ToString())}");
            toStringOutput.Add($"this.ConnectMs = {(this.ConnectMs == null ? "null" : this.ConnectMs.ToString())}");
            toStringOutput.Add($"this.QueueMs = {(this.QueueMs == null ? "null" : this.QueueMs.ToString())}");
            toStringOutput.Add($"this.TunnelSecs = {(this.TunnelSecs == null ? "null" : this.TunnelSecs.ToString())}");
        }
    }
}
// <copyright file="Frontend.cs" company="APIMatic">
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
    /// Frontend.
    /// </summary>
    public class Frontend
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frontend"/> class.
        /// </summary>
        public Frontend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Frontend"/> class.
        /// </summary>
        /// <param name="mode">mode.</param>
        /// <param name="maxConnections">max_connections.</param>
        /// <param name="timeouts">timeouts.</param>
        public Frontend(
            Models.ModeEnum mode,
            int? maxConnections = null,
            Models.Timeouts timeouts = null)
        {
            this.Mode = mode;
            this.MaxConnections = maxConnections;
            this.Timeouts = timeouts;
        }

        /// <summary>
        /// The type of traffic expected by the load balancer for this port. Can be either:
        ///  - tcp: Traffic is forwarded without any parsing or additional manipulation.
        ///  - http: Traffic is treated as web traffic. If a LINKED record is configured for a container exposing this port, the domain will be parsed and it will be forwarded to the proper container. This allows multiple services to run on port 80 in the same environment.
        /// </summary>
        [JsonProperty("mode")]
        public Models.ModeEnum Mode { get; set; }

        /// <summary>
        /// The number of simultaneous connections that can be processed at a time.
        /// </summary>
        [JsonProperty("max_connections", NullValueHandling = NullValueHandling.Include)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// Various options for handling timeouts when communicating with the client.
        /// </summary>
        [JsonProperty("timeouts", NullValueHandling = NullValueHandling.Include)]
        public Models.Timeouts Timeouts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Frontend : ({string.Join(", ", toStringOutput)})";
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
            return obj is Frontend other &&                this.Mode.Equals(other.Mode) &&
                ((this.MaxConnections == null && other.MaxConnections == null) || (this.MaxConnections?.Equals(other.MaxConnections) == true)) &&
                ((this.Timeouts == null && other.Timeouts == null) || (this.Timeouts?.Equals(other.Timeouts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mode = {this.Mode}");
            toStringOutput.Add($"this.MaxConnections = {(this.MaxConnections == null ? "null" : this.MaxConnections.ToString())}");
            toStringOutput.Add($"this.Timeouts = {(this.Timeouts == null ? "null" : this.Timeouts.ToString())}");
        }
    }
}
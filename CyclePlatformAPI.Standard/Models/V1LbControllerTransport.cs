// <copyright file="V1LbControllerTransport.cs" company="APIMatic">
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
    /// V1LbControllerTransport.
    /// </summary>
    public class V1LbControllerTransport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbControllerTransport"/> class.
        /// </summary>
        public V1LbControllerTransport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbControllerTransport"/> class.
        /// </summary>
        /// <param name="disable">disable.</param>
        /// <param name="mode">mode.</param>
        /// <param name="config">config.</param>
        /// <param name="routers">routers.</param>
        public V1LbControllerTransport(
            bool disable,
            Models.Mode2Enum mode,
            Models.Config1 config,
            List<Models.V1LbRouterConfig> routers)
        {
            this.Disable = disable;
            this.Mode = mode;
            this.Config = config;
            this.Routers = routers;
        }

        /// <summary>
        /// When true, this controller is disabled and will not be used.
        /// </summary>
        [JsonProperty("disable")]
        public bool Disable { get; set; }

        /// <summary>
        /// The kind of traffic (http/tcp) that will be sent to the load balancer.
        /// </summary>
        [JsonProperty("mode")]
        public Models.Mode2Enum Mode { get; set; }

        /// <summary>
        /// Defines how the transport for this controller operates.
        /// </summary>
        [JsonProperty("config")]
        public Models.Config1 Config { get; set; }

        /// <summary>
        /// Defines where traffic is sent. Many can be defined per controller.
        /// </summary>
        [JsonProperty("routers")]
        public List<Models.V1LbRouterConfig> Routers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1LbControllerTransport : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1LbControllerTransport other &&                this.Disable.Equals(other.Disable) &&
                this.Mode.Equals(other.Mode) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.Routers == null && other.Routers == null) || (this.Routers?.Equals(other.Routers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Disable = {this.Disable}");
            toStringOutput.Add($"this.Mode = {this.Mode}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.Routers = {(this.Routers == null ? "null" : $"[{string.Join(", ", this.Routers)} ]")}");
        }
    }
}
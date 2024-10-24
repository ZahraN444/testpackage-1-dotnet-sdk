// <copyright file="Details2.cs" company="APIMatic">
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
    /// Details2.
    /// </summary>
    public class Details2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details2"/> class.
        /// </summary>
        public Details2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details2"/> class.
        /// </summary>
        /// <param name="connections">connections.</param>
        /// <param name="telemetry">telemetry.</param>
        public Details2(
            Models.Connections connections,
            Models.Telemetry telemetry)
        {
            this.Connections = connections;
            this.Telemetry = telemetry;
        }

        /// <summary>
        /// Defines extra configuration options connections to the load balancer
        /// </summary>
        [JsonProperty("connections")]
        public Models.Connections Connections { get; set; }

        /// <summary>
        /// Configuration options for how telemetry is handled.
        /// </summary>
        [JsonProperty("telemetry")]
        public Models.Telemetry Telemetry { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details2 other &&                ((this.Connections == null && other.Connections == null) || (this.Connections?.Equals(other.Connections) == true)) &&
                ((this.Telemetry == null && other.Telemetry == null) || (this.Telemetry?.Equals(other.Telemetry) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Connections = {(this.Connections == null ? "null" : this.Connections.ToString())}");
            toStringOutput.Add($"this.Telemetry = {(this.Telemetry == null ? "null" : this.Telemetry.ToString())}");
        }
    }
}
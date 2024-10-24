// <copyright file="Config1.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Config1.
    /// </summary>
    public class Config1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config1"/> class.
        /// </summary>
        public Config1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config1"/> class.
        /// </summary>
        /// <param name="performance">performance.</param>
        /// <param name="ingress">ingress.</param>
        /// <param name="timeouts">timeouts.</param>
        /// <param name="verbosity">verbosity.</param>
        /// <param name="extension">extension.</param>
        public Config1(
            bool performance,
            Models.Ingress ingress,
            Models.Timeouts3 timeouts,
            Models.VerbosityEnum verbosity,
            Config1Extension extension = null)
        {
            this.Performance = performance;
            this.Ingress = ingress;
            this.Timeouts = timeouts;
            this.Verbosity = verbosity;
            this.Extension = extension;
        }

        /// <summary>
        /// Enable/disable performance mode. If enabled, some telemetry will be disabled to dedicate full processing to handling requests.
        /// You will not see per-request breakdowns or URL logging if performance mode is enabled.
        /// </summary>
        [JsonProperty("performance")]
        public bool Performance { get; set; }

        /// <summary>
        /// Defines how traffic gets into the load balancer.
        /// </summary>
        [JsonProperty("ingress")]
        public Models.Ingress Ingress { get; set; }

        /// <summary>
        /// Defines settings for various types of timeouts.
        /// </summary>
        [JsonProperty("timeouts")]
        public Models.Timeouts3 Timeouts { get; set; }

        /// <summary>
        /// Verbosity describes the level of logging detail for the controller
        /// </summary>
        [JsonProperty("verbosity")]
        public Models.VerbosityEnum Verbosity { get; set; }

        /// <summary>
        /// Extended configurations for the specified transport mode (http/tcp)
        /// </summary>
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public Config1Extension Extension { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Config1 other &&                this.Performance.Equals(other.Performance) &&
                ((this.Ingress == null && other.Ingress == null) || (this.Ingress?.Equals(other.Ingress) == true)) &&
                ((this.Timeouts == null && other.Timeouts == null) || (this.Timeouts?.Equals(other.Timeouts) == true)) &&
                this.Verbosity.Equals(other.Verbosity) &&
                ((this.Extension == null && other.Extension == null) || (this.Extension?.Equals(other.Extension) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Performance = {this.Performance}");
            toStringOutput.Add($"this.Ingress = {(this.Ingress == null ? "null" : this.Ingress.ToString())}");
            toStringOutput.Add($"this.Timeouts = {(this.Timeouts == null ? "null" : this.Timeouts.ToString())}");
            toStringOutput.Add($"this.Verbosity = {this.Verbosity}");
            toStringOutput.Add($"Extension = {(this.Extension == null ? "null" : this.Extension.ToString())}");
        }
    }
}
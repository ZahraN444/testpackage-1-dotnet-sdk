// <copyright file="V1LbRouterConfig.cs" company="APIMatic">
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
    /// V1LbRouterConfig.
    /// </summary>
    public class V1LbRouterConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbRouterConfig"/> class.
        /// </summary>
        public V1LbRouterConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbRouterConfig"/> class.
        /// </summary>
        /// <param name="match">match.</param>
        /// <param name="mode">mode.</param>
        /// <param name="config">config.</param>
        public V1LbRouterConfig(
            Models.Match match,
            Models.Mode1Enum mode,
            Models.Config config)
        {
            this.Match = match;
            this.Mode = mode;
            this.Config = config;
        }

        /// <summary>
        /// The ruleset for this router to be selected. If both `domains`` and `internal_port` are null, then this match acts as a wildcard and will match all.
        /// </summary>
        [JsonProperty("match")]
        public Models.Match Match { get; set; }

        /// <summary>
        /// How to route the traffic to the destination.
        /// `random`: Pick a valid destination at random.
        /// `round-robin`: Send each request to the 'next' destination on the list, restarting from the beginning when the last destination is used.
        /// </summary>
        [JsonProperty("mode")]
        public Models.Mode1Enum Mode { get; set; }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config")]
        public Models.Config Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1LbRouterConfig : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1LbRouterConfig other &&                ((this.Match == null && other.Match == null) || (this.Match?.Equals(other.Match) == true)) &&
                this.Mode.Equals(other.Mode) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Match = {(this.Match == null ? "null" : this.Match.ToString())}");
            toStringOutput.Add($"this.Mode = {this.Mode}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}
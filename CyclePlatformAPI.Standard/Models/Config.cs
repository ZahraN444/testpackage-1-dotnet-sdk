// <copyright file="Config.cs" company="APIMatic">
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
    /// Config.
    /// </summary>
    public class Config
    {
        private Models.Tls tls;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "tls", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Config"/> class.
        /// </summary>
        public Config()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config"/> class.
        /// </summary>
        /// <param name="stickySessions">sticky_sessions.</param>
        /// <param name="destinationRetries">destination_retries.</param>
        /// <param name="timeouts">timeouts.</param>
        /// <param name="tls">tls.</param>
        /// <param name="extension">extension.</param>
        public Config(
            bool stickySessions,
            int destinationRetries,
            Models.Timeouts2 timeouts,
            Models.Tls tls = null,
            ConfigExtension extension = null)
        {
            this.StickySessions = stickySessions;
            this.DestinationRetries = destinationRetries;
            if (tls != null)
            {
                this.Tls = tls;
            }

            this.Timeouts = timeouts;
            this.Extension = extension;
        }

        /// <summary>
        /// If a request comes in from the same origin, ensure it hits the same destination.
        /// </summary>
        [JsonProperty("sticky_sessions")]
        public bool StickySessions { get; set; }

        /// <summary>
        /// If a destination is unavailable, retry up to [x] times, instead of immediately failing with a 503/504 error.
        /// </summary>
        [JsonProperty("destination_retries")]
        public int DestinationRetries { get; set; }

        /// <summary>
        /// TLS termination configuration. If null, the platform will use the default configuration. Port 443 by default has TLS termination enabled.
        /// </summary>
        [JsonProperty("tls")]
        public Models.Tls Tls
        {
            get
            {
                return this.tls;
            }

            set
            {
                this.shouldSerialize["tls"] = true;
                this.tls = value;
            }
        }

        /// <summary>
        /// Defines how the length of various sorts of timeouts when communicating with the destination.
        /// </summary>
        [JsonProperty("timeouts")]
        public Models.Timeouts2 Timeouts { get; set; }

        /// <summary>
        /// Additional configuration options specific to the selected mode (tcp/http).
        /// </summary>
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigExtension Extension { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTls()
        {
            this.shouldSerialize["tls"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTls()
        {
            return this.shouldSerialize["tls"];
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
            return obj is Config other &&                this.StickySessions.Equals(other.StickySessions) &&
                this.DestinationRetries.Equals(other.DestinationRetries) &&
                ((this.Tls == null && other.Tls == null) || (this.Tls?.Equals(other.Tls) == true)) &&
                ((this.Timeouts == null && other.Timeouts == null) || (this.Timeouts?.Equals(other.Timeouts) == true)) &&
                ((this.Extension == null && other.Extension == null) || (this.Extension?.Equals(other.Extension) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StickySessions = {this.StickySessions}");
            toStringOutput.Add($"this.DestinationRetries = {this.DestinationRetries}");
            toStringOutput.Add($"this.Tls = {(this.Tls == null ? "null" : this.Tls.ToString())}");
            toStringOutput.Add($"this.Timeouts = {(this.Timeouts == null ? "null" : this.Timeouts.ToString())}");
            toStringOutput.Add($"Extension = {(this.Extension == null ? "null" : this.Extension.ToString())}");
        }
    }
}
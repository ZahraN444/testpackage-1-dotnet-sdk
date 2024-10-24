// <copyright file="Shutdown.cs" company="APIMatic">
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
    /// Shutdown.
    /// </summary>
    public class Shutdown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shutdown"/> class.
        /// </summary>
        public Shutdown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shutdown"/> class.
        /// </summary>
        /// <param name="gracefulTimeout">graceful_timeout.</param>
        /// <param name="signals">signals.</param>
        public Shutdown(
            ShutdownGracefulTimeout gracefulTimeout = null,
            List<string> signals = null)
        {
            this.GracefulTimeout = gracefulTimeout;
            this.Signals = signals;
        }

        /// <summary>
        /// How long the platform will wait for a container to stop gracefully.
        /// </summary>
        [JsonProperty("graceful_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public ShutdownGracefulTimeout GracefulTimeout { get; set; }

        /// <summary>
        /// Gets or sets Signals.
        /// </summary>
        [JsonProperty("signals", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Signals { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Shutdown : ({string.Join(", ", toStringOutput)})";
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
            return obj is Shutdown other &&                ((this.GracefulTimeout == null && other.GracefulTimeout == null) || (this.GracefulTimeout?.Equals(other.GracefulTimeout) == true)) &&
                ((this.Signals == null && other.Signals == null) || (this.Signals?.Equals(other.Signals) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"GracefulTimeout = {(this.GracefulTimeout == null ? "null" : this.GracefulTimeout.ToString())}");
            toStringOutput.Add($"this.Signals = {(this.Signals == null ? "null" : $"[{string.Join(", ", this.Signals)} ]")}");
        }
    }
}
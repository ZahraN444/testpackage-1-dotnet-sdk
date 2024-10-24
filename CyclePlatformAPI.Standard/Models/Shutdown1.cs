// <copyright file="Shutdown1.cs" company="APIMatic">
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
    /// Shutdown1.
    /// </summary>
    public class Shutdown1
    {
        private List<Models.SignalEnum> signals;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "signals", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Shutdown1"/> class.
        /// </summary>
        public Shutdown1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shutdown1"/> class.
        /// </summary>
        /// <param name="gracefulTimeout">graceful_timeout.</param>
        /// <param name="signals">signals.</param>
        public Shutdown1(
            Shutdown1GracefulTimeout gracefulTimeout = null,
            List<Models.SignalEnum> signals = null)
        {
            this.GracefulTimeout = gracefulTimeout;
            if (signals != null)
            {
                this.Signals = signals;
            }

        }

        /// <summary>
        /// How long the platform will wait for a container to stop gracefully.
        /// </summary>
        [JsonProperty("graceful_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public Shutdown1GracefulTimeout GracefulTimeout { get; set; }

        /// <summary>
        /// Process signal sent to the container process.
        /// </summary>
        [JsonProperty("signals")]
        public List<Models.SignalEnum> Signals
        {
            get
            {
                return this.signals;
            }

            set
            {
                this.shouldSerialize["signals"] = true;
                this.signals = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Shutdown1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSignals()
        {
            this.shouldSerialize["signals"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignals()
        {
            return this.shouldSerialize["signals"];
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
            return obj is Shutdown1 other &&                ((this.GracefulTimeout == null && other.GracefulTimeout == null) || (this.GracefulTimeout?.Equals(other.GracefulTimeout) == true)) &&
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
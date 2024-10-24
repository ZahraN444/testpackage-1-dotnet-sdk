// <copyright file="InstanceTelemetryNetworkSnapshot.cs" company="APIMatic">
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
    /// InstanceTelemetryNetworkSnapshot.
    /// </summary>
    public class InstanceTelemetryNetworkSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryNetworkSnapshot"/> class.
        /// </summary>
        public InstanceTelemetryNetworkSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryNetworkSnapshot"/> class.
        /// </summary>
        /// <param name="interfaces">interfaces.</param>
        public InstanceTelemetryNetworkSnapshot(
            List<Models.InstanceTelemetryNetworkInterfaceSnapshot> interfaces)
        {
            this.Interfaces = interfaces;
        }

        /// <summary>
        /// An array of network interfaces attached to this instance.
        /// </summary>
        [JsonProperty("interfaces")]
        public List<Models.InstanceTelemetryNetworkInterfaceSnapshot> Interfaces { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryNetworkSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryNetworkSnapshot other &&                ((this.Interfaces == null && other.Interfaces == null) || (this.Interfaces?.Equals(other.Interfaces) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Interfaces = {(this.Interfaces == null ? "null" : $"[{string.Join(", ", this.Interfaces)} ]")}");
        }
    }
}
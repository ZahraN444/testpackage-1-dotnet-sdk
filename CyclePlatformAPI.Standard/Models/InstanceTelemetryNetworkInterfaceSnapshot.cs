// <copyright file="InstanceTelemetryNetworkInterfaceSnapshot.cs" company="APIMatic">
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
    /// InstanceTelemetryNetworkInterfaceSnapshot.
    /// </summary>
    public class InstanceTelemetryNetworkInterfaceSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryNetworkInterfaceSnapshot"/> class.
        /// </summary>
        public InstanceTelemetryNetworkInterfaceSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceTelemetryNetworkInterfaceSnapshot"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="rxBytes">rx_bytes.</param>
        /// <param name="txBytes">tx_bytes.</param>
        public InstanceTelemetryNetworkInterfaceSnapshot(
            string name,
            int rxBytes,
            int txBytes)
        {
            this.Name = name;
            this.RxBytes = rxBytes;
            this.TxBytes = txBytes;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets RxBytes.
        /// </summary>
        [JsonProperty("rx_bytes")]
        public int RxBytes { get; set; }

        /// <summary>
        /// Gets or sets TxBytes.
        /// </summary>
        [JsonProperty("tx_bytes")]
        public int TxBytes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceTelemetryNetworkInterfaceSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceTelemetryNetworkInterfaceSnapshot other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.RxBytes.Equals(other.RxBytes) &&
                this.TxBytes.Equals(other.TxBytes);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.RxBytes = {this.RxBytes}");
            toStringOutput.Add($"this.TxBytes = {this.TxBytes}");
        }
    }
}
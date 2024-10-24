// <copyright file="Details.cs" company="APIMatic">
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
    /// Details.
    /// </summary>
    public class Details
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details"/> class.
        /// </summary>
        public Details()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details"/> class.
        /// </summary>
        /// <param name="mDefault">default.</param>
        /// <param name="ports">ports.</param>
        public Details(
            Models.HAProxyConfig2 mDefault = null,
            Dictionary<string, Models.HAProxyConfig> ports = null)
        {
            this.MDefault = mDefault;
            this.Ports = ports;
        }

        /// <summary>
        /// Settings that are applied to any port that is not overridden in the following ports section.
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HAProxyConfig2 MDefault { get; set; }

        /// <summary>
        /// An object that defines how HAProxy will act on a specific port. The key is a custom port, and the value is the same settings object found under `default` above.
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.HAProxyConfig> Ports { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details other &&                ((this.MDefault == null && other.MDefault == null) || (this.MDefault?.Equals(other.MDefault) == true)) &&
                ((this.Ports == null && other.Ports == null) || (this.Ports?.Equals(other.Ports) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MDefault = {(this.MDefault == null ? "null" : this.MDefault.ToString())}");
            toStringOutput.Add($"Ports = {(this.Ports == null ? "null" : this.Ports.ToString())}");
        }
    }
}
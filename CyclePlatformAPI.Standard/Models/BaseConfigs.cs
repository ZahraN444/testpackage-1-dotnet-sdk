// <copyright file="BaseConfigs.cs" company="APIMatic">
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
    /// BaseConfigs.
    /// </summary>
    public class BaseConfigs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseConfigs"/> class.
        /// </summary>
        public BaseConfigs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseConfigs"/> class.
        /// </summary>
        /// <param name="haproxy">haproxy.</param>
        /// <param name="v1">v1.</param>
        public BaseConfigs(
            Models.HaProxyConfig1 haproxy,
            Models.V1LbConfig v1)
        {
            this.Haproxy = haproxy;
            this.V1 = v1;
        }

        /// <summary>
        /// Describes settings that are passed to HAProxy within the load balancer.
        /// </summary>
        [JsonProperty("haproxy")]
        public Models.HaProxyConfig1 Haproxy { get; set; }

        /// <summary>
        /// Gets or sets V1.
        /// </summary>
        [JsonProperty("v1")]
        public Models.V1LbConfig V1 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BaseConfigs : ({string.Join(", ", toStringOutput)})";
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
            return obj is BaseConfigs other &&                ((this.Haproxy == null && other.Haproxy == null) || (this.Haproxy?.Equals(other.Haproxy) == true)) &&
                ((this.V1 == null && other.V1 == null) || (this.V1?.Equals(other.V1) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Haproxy = {(this.Haproxy == null ? "null" : this.Haproxy.ToString())}");
            toStringOutput.Add($"this.V1 = {(this.V1 == null ? "null" : this.V1.ToString())}");
        }
    }
}
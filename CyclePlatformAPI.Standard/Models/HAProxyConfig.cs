// <copyright file="HAProxyConfig.cs" company="APIMatic">
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
    /// HAProxyConfig.
    /// </summary>
    public class HAProxyConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HAProxyConfig"/> class.
        /// </summary>
        public HAProxyConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HAProxyConfig"/> class.
        /// </summary>
        /// <param name="frontend">frontend.</param>
        /// <param name="backend">backend.</param>
        public HAProxyConfig(
            Models.Frontend frontend,
            Models.Backend backend)
        {
            this.Frontend = frontend;
            this.Backend = backend;
        }

        /// <summary>
        /// Settings that describe how incoming traffic to the load balancer is handled.
        /// </summary>
        [JsonProperty("frontend")]
        public Models.Frontend Frontend { get; set; }

        /// <summary>
        /// Settings related to how the load balancer routes connections to container instances.
        /// </summary>
        [JsonProperty("backend")]
        public Models.Backend Backend { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HAProxyConfig : ({string.Join(", ", toStringOutput)})";
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
            return obj is HAProxyConfig other &&                ((this.Frontend == null && other.Frontend == null) || (this.Frontend?.Equals(other.Frontend) == true)) &&
                ((this.Backend == null && other.Backend == null) || (this.Backend?.Equals(other.Backend) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Frontend = {(this.Frontend == null ? "null" : this.Frontend.ToString())}");
            toStringOutput.Add($"this.Backend = {(this.Backend == null ? "null" : this.Backend.ToString())}");
        }
    }
}
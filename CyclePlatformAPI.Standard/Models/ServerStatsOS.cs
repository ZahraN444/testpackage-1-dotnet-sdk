// <copyright file="ServerStatsOS.cs" company="APIMatic">
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
    /// ServerStatsOS.
    /// </summary>
    public class ServerStatsOS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsOS"/> class.
        /// </summary>
        public ServerStatsOS()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsOS"/> class.
        /// </summary>
        /// <param name="release">release.</param>
        /// <param name="kernel">kernel.</param>
        /// <param name="hostname">hostname.</param>
        public ServerStatsOS(
            string release = null,
            string kernel = null,
            string hostname = null)
        {
            this.Release = release;
            this.Kernel = kernel;
            this.Hostname = hostname;
        }

        /// <summary>
        /// The currently installed release version of the OS.
        /// </summary>
        [JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
        public string Release { get; set; }

        /// <summary>
        /// The currently installed kernel version.
        /// </summary>
        [JsonProperty("kernel", NullValueHandling = NullValueHandling.Ignore)]
        public string Kernel { get; set; }

        /// <summary>
        /// The hostname as set by the given server's OS.
        /// </summary>
        [JsonProperty("hostname", NullValueHandling = NullValueHandling.Ignore)]
        public string Hostname { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsOS : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsOS other &&                ((this.Release == null && other.Release == null) || (this.Release?.Equals(other.Release) == true)) &&
                ((this.Kernel == null && other.Kernel == null) || (this.Kernel?.Equals(other.Kernel) == true)) &&
                ((this.Hostname == null && other.Hostname == null) || (this.Hostname?.Equals(other.Hostname) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Release = {(this.Release == null ? "null" : this.Release)}");
            toStringOutput.Add($"this.Kernel = {(this.Kernel == null ? "null" : this.Kernel)}");
            toStringOutput.Add($"this.Hostname = {(this.Hostname == null ? "null" : this.Hostname)}");
        }
    }
}
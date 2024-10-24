// <copyright file="ServerStatsVersions.cs" company="APIMatic">
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
    /// ServerStatsVersions.
    /// </summary>
    public class ServerStatsVersions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsVersions"/> class.
        /// </summary>
        public ServerStatsVersions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsVersions"/> class.
        /// </summary>
        /// <param name="services">services.</param>
        public ServerStatsVersions(
            Dictionary<string, string> services)
        {
            this.Services = services;
        }

        /// <summary>
        /// A list of records about Cycle services.
        /// </summary>
        [JsonProperty("services")]
        public Dictionary<string, string> Services { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsVersions : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsVersions other &&                ((this.Services == null && other.Services == null) || (this.Services?.Equals(other.Services) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Services = {(this.Services == null ? "null" : this.Services.ToString())}");
        }
    }
}
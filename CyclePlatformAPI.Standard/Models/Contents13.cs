// <copyright file="Contents13.cs" company="APIMatic">
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
    /// Contents13.
    /// </summary>
    public class Contents13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents13"/> class.
        /// </summary>
        public Contents13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents13"/> class.
        /// </summary>
        /// <param name="environmentIds">environment_ids.</param>
        public Contents13(
            List<string> environmentIds)
        {
            this.EnvironmentIds = environmentIds;
        }

        /// <summary>
        /// An array of environment identifiers for the Network.
        /// </summary>
        [JsonProperty("environment_ids")]
        public List<string> EnvironmentIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents13 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents13 other &&                ((this.EnvironmentIds == null && other.EnvironmentIds == null) || (this.EnvironmentIds?.Equals(other.EnvironmentIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnvironmentIds = {(this.EnvironmentIds == null ? "null" : $"[{string.Join(", ", this.EnvironmentIds)} ]")}");
        }
    }
}
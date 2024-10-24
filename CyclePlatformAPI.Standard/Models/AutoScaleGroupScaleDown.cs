// <copyright file="AutoScaleGroupScaleDown.cs" company="APIMatic">
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
    /// AutoScaleGroupScaleDown.
    /// </summary>
    public class AutoScaleGroupScaleDown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupScaleDown"/> class.
        /// </summary>
        public AutoScaleGroupScaleDown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupScaleDown"/> class.
        /// </summary>
        /// <param name="minTtl">min_ttl.</param>
        /// <param name="inactivityPeriod">inactivity_period.</param>
        /// <param name="method">method.</param>
        public AutoScaleGroupScaleDown(
            string minTtl = null,
            string inactivityPeriod = null,
            Models.MethodEnum? method = null)
        {
            this.MinTtl = minTtl;
            this.InactivityPeriod = inactivityPeriod;
            this.Method = method;
        }

        /// <summary>
        /// The minimum TTL for the server once deployed through an autoscale event.
        /// </summary>
        [JsonProperty("min_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string MinTtl { get; set; }

        /// <summary>
        /// The amount of time between last instance deployed and when the server can begin to get deleted.
        /// </summary>
        [JsonProperty("inactivity_period", NullValueHandling = NullValueHandling.Ignore)]
        public string InactivityPeriod { get; set; }

        /// <summary>
        /// Gets or sets Method.
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MethodEnum? Method { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoScaleGroupScaleDown : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoScaleGroupScaleDown other &&                ((this.MinTtl == null && other.MinTtl == null) || (this.MinTtl?.Equals(other.MinTtl) == true)) &&
                ((this.InactivityPeriod == null && other.InactivityPeriod == null) || (this.InactivityPeriod?.Equals(other.InactivityPeriod) == true)) &&
                ((this.Method == null && other.Method == null) || (this.Method?.Equals(other.Method) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MinTtl = {(this.MinTtl == null ? "null" : this.MinTtl)}");
            toStringOutput.Add($"this.InactivityPeriod = {(this.InactivityPeriod == null ? "null" : this.InactivityPeriod)}");
            toStringOutput.Add($"this.Method = {(this.Method == null ? "null" : this.Method.ToString())}");
        }
    }
}
// <copyright file="ServerStatsLoad.cs" company="APIMatic">
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
    /// ServerStatsLoad.
    /// </summary>
    public class ServerStatsLoad
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsLoad"/> class.
        /// </summary>
        public ServerStatsLoad()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsLoad"/> class.
        /// </summary>
        /// <param name="avg1m">avg1m.</param>
        /// <param name="avg5m">avg5m.</param>
        /// <param name="avg15m">avg15m.</param>
        public ServerStatsLoad(
            double avg1m,
            double avg5m,
            double avg15m)
        {
            this.Avg1m = avg1m;
            this.Avg5m = avg5m;
            this.Avg15m = avg15m;
        }

        /// <summary>
        /// The 1 minute load average.
        /// </summary>
        [JsonProperty("avg1m")]
        public double Avg1m { get; set; }

        /// <summary>
        /// The 5 minute load average.
        /// </summary>
        [JsonProperty("avg5m")]
        public double Avg5m { get; set; }

        /// <summary>
        /// the 15 minute load average.
        /// </summary>
        [JsonProperty("avg15m")]
        public double Avg15m { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsLoad : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsLoad other &&                this.Avg1m.Equals(other.Avg1m) &&
                this.Avg5m.Equals(other.Avg5m) &&
                this.Avg15m.Equals(other.Avg15m);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Avg1m = {this.Avg1m}");
            toStringOutput.Add($"this.Avg5m = {this.Avg5m}");
            toStringOutput.Add($"this.Avg15m = {this.Avg15m}");
        }
    }
}
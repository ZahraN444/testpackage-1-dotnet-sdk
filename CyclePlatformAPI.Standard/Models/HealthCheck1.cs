// <copyright file="HealthCheck1.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// HealthCheck1.
    /// </summary>
    public class HealthCheck1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheck1"/> class.
        /// </summary>
        public HealthCheck1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheck1"/> class.
        /// </summary>
        /// <param name="command">command.</param>
        /// <param name="retries">retries.</param>
        /// <param name="delay">delay.</param>
        /// <param name="interval">interval.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="restart">restart.</param>
        public HealthCheck1(
            string command,
            int retries,
            HealthCheck1Delay delay,
            string interval,
            string timeout,
            bool restart)
        {
            this.Command = command;
            this.Retries = retries;
            this.Delay = delay;
            this.Interval = interval;
            this.Timeout = timeout;
            this.Restart = restart;
        }

        /// <summary>
        /// The command that will be run to verify the health of the container.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// The number of times the platform will retry the command before marking the container unhealthy.
        /// </summary>
        [JsonProperty("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// How long to wait before performing an initial health check when the instance starts. The `state.health.healthy` field of the instance will be `null`` until the first check is performed.
        /// </summary>
        [JsonProperty("delay")]
        public HealthCheck1Delay Delay { get; set; }

        /// <summary>
        /// How long to wait between restarts.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// How long before a health check attempt times out.
        /// </summary>
        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// A boolean where `true` represents the desire for a container to restart if unhealthy.
        /// </summary>
        [JsonProperty("restart")]
        public bool Restart { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HealthCheck1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is HealthCheck1 other &&                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                this.Retries.Equals(other.Retries) &&
                ((this.Delay == null && other.Delay == null) || (this.Delay?.Equals(other.Delay) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.Timeout == null && other.Timeout == null) || (this.Timeout?.Equals(other.Timeout) == true)) &&
                this.Restart.Equals(other.Restart);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command)}");
            toStringOutput.Add($"this.Retries = {this.Retries}");
            toStringOutput.Add($"Delay = {(this.Delay == null ? "null" : this.Delay.ToString())}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval)}");
            toStringOutput.Add($"this.Timeout = {(this.Timeout == null ? "null" : this.Timeout)}");
            toStringOutput.Add($"this.Restart = {this.Restart}");
        }
    }
}
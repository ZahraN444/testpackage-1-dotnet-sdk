// <copyright file="HealthCheck.cs" company="APIMatic">
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
    /// HealthCheck.
    /// </summary>
    public class HealthCheck
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheck"/> class.
        /// </summary>
        public HealthCheck()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheck"/> class.
        /// </summary>
        /// <param name="command">command.</param>
        /// <param name="retries">retries.</param>
        /// <param name="interval">interval.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="restart">restart.</param>
        /// <param name="delay">delay.</param>
        public HealthCheck(
            string command,
            int retries,
            string interval,
            string timeout,
            bool restart,
            HealthCheckDelay delay = null)
        {
            this.Command = command;
            this.Retries = retries;
            this.Interval = interval;
            this.Timeout = timeout;
            this.Restart = restart;
            this.Delay = delay;
        }

        /// <summary>
        /// The command to run as your health check
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// The number of times to retry the command before marking an instance unhealthy
        /// </summary>
        [JsonProperty("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// How long to wait between running health checks.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// How long before a health check attempt times out.
        /// </summary>
        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// A boolean where true represents the desire for the container to restart if any instance is unhealthy.
        /// </summary>
        [JsonProperty("restart")]
        public bool Restart { get; set; }

        /// <summary>
        /// How long to wait after a container start event before starting health checks.
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public HealthCheckDelay Delay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HealthCheck : ({string.Join(", ", toStringOutput)})";
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
            return obj is HealthCheck other &&                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                this.Retries.Equals(other.Retries) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.Timeout == null && other.Timeout == null) || (this.Timeout?.Equals(other.Timeout) == true)) &&
                this.Restart.Equals(other.Restart) &&
                ((this.Delay == null && other.Delay == null) || (this.Delay?.Equals(other.Delay) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command)}");
            toStringOutput.Add($"this.Retries = {this.Retries}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval)}");
            toStringOutput.Add($"this.Timeout = {(this.Timeout == null ? "null" : this.Timeout)}");
            toStringOutput.Add($"this.Restart = {this.Restart}");
            toStringOutput.Add($"Delay = {(this.Delay == null ? "null" : this.Delay.ToString())}");
        }
    }
}
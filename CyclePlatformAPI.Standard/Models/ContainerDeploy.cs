// <copyright file="ContainerDeploy.cs" company="APIMatic">
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
    /// ContainerDeploy.
    /// </summary>
    public class ContainerDeploy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerDeploy"/> class.
        /// </summary>
        public ContainerDeploy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerDeploy"/> class.
        /// </summary>
        /// <param name="instances">instances.</param>
        /// <param name="strategy">strategy.</param>
        /// <param name="stateful">stateful.</param>
        /// <param name="constraints">constraints.</param>
        /// <param name="shutdown">shutdown.</param>
        /// <param name="startup">startup.</param>
        /// <param name="update">update.</param>
        /// <param name="restart">restart.</param>
        /// <param name="healthCheck">health_check.</param>
        /// <param name="telemetry">telemetry.</param>
        public ContainerDeploy(
            int instances,
            Models.DeploymentStrategyName1Enum? strategy = null,
            Models.Stateful1 stateful = null,
            Models.Constraints1 constraints = null,
            Models.Shutdown1 shutdown = null,
            Models.Startup1 startup = null,
            Models.Update1 update = null,
            Models.Restart1 restart = null,
            Models.HealthCheck1 healthCheck = null,
            Models.Telemetry2 telemetry = null)
        {
            this.Instances = instances;
            this.Strategy = strategy;
            this.Stateful = stateful;
            this.Constraints = constraints;
            this.Shutdown = shutdown;
            this.Startup = startup;
            this.Update = update;
            this.Restart = restart;
            this.HealthCheck = healthCheck;
            this.Telemetry = telemetry;
        }

        /// <summary>
        /// The number of initial desired instances for a given container.
        /// </summary>
        [JsonProperty("instances")]
        public int Instances { get; set; }

        /// <summary>
        /// The deployment strategy to use when scaling the given container.
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategyName1Enum? Strategy { get; set; }

        /// <summary>
        /// Gets or sets Stateful.
        /// </summary>
        [JsonProperty("stateful", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Stateful1 Stateful { get; set; }

        /// <summary>
        /// Settings that give more granular control over deployment targets and conditions.
        /// </summary>
        [JsonProperty("constraints", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Constraints1 Constraints { get; set; }

        /// <summary>
        /// Configuration for what to do during container shutdown.
        /// </summary>
        [JsonProperty("shutdown", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Shutdown1 Shutdown { get; set; }

        /// <summary>
        /// Configurations for container startup.
        /// </summary>
        [JsonProperty("startup", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Startup1 Startup { get; set; }

        /// <summary>
        /// Configurations for container updates.
        /// </summary>
        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Update1 Update { get; set; }

        /// <summary>
        /// Configurations for container restart events.
        /// </summary>
        [JsonProperty("restart", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Restart1 Restart { get; set; }

        /// <summary>
        /// Configuration for determining the health of a container.
        /// </summary>
        [JsonProperty("health_check", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HealthCheck1 HealthCheck { get; set; }

        /// <summary>
        /// Configuration settings for container telemetery reporting.
        /// </summary>
        [JsonProperty("telemetry", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Telemetry2 Telemetry { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerDeploy : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerDeploy other &&                this.Instances.Equals(other.Instances) &&
                ((this.Strategy == null && other.Strategy == null) || (this.Strategy?.Equals(other.Strategy) == true)) &&
                ((this.Stateful == null && other.Stateful == null) || (this.Stateful?.Equals(other.Stateful) == true)) &&
                ((this.Constraints == null && other.Constraints == null) || (this.Constraints?.Equals(other.Constraints) == true)) &&
                ((this.Shutdown == null && other.Shutdown == null) || (this.Shutdown?.Equals(other.Shutdown) == true)) &&
                ((this.Startup == null && other.Startup == null) || (this.Startup?.Equals(other.Startup) == true)) &&
                ((this.Update == null && other.Update == null) || (this.Update?.Equals(other.Update) == true)) &&
                ((this.Restart == null && other.Restart == null) || (this.Restart?.Equals(other.Restart) == true)) &&
                ((this.HealthCheck == null && other.HealthCheck == null) || (this.HealthCheck?.Equals(other.HealthCheck) == true)) &&
                ((this.Telemetry == null && other.Telemetry == null) || (this.Telemetry?.Equals(other.Telemetry) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Instances = {this.Instances}");
            toStringOutput.Add($"this.Strategy = {(this.Strategy == null ? "null" : this.Strategy.ToString())}");
            toStringOutput.Add($"this.Stateful = {(this.Stateful == null ? "null" : this.Stateful.ToString())}");
            toStringOutput.Add($"this.Constraints = {(this.Constraints == null ? "null" : this.Constraints.ToString())}");
            toStringOutput.Add($"this.Shutdown = {(this.Shutdown == null ? "null" : this.Shutdown.ToString())}");
            toStringOutput.Add($"this.Startup = {(this.Startup == null ? "null" : this.Startup.ToString())}");
            toStringOutput.Add($"this.Update = {(this.Update == null ? "null" : this.Update.ToString())}");
            toStringOutput.Add($"this.Restart = {(this.Restart == null ? "null" : this.Restart.ToString())}");
            toStringOutput.Add($"this.HealthCheck = {(this.HealthCheck == null ? "null" : this.HealthCheck.ToString())}");
            toStringOutput.Add($"this.Telemetry = {(this.Telemetry == null ? "null" : this.Telemetry.ToString())}");
        }
    }
}
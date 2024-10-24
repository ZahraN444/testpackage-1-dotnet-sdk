// <copyright file="StackContainerConfigDeployYml.cs" company="APIMatic">
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
    /// StackContainerConfigDeployYml.
    /// </summary>
    public class StackContainerConfigDeployYml
    {
        private Models.DeploymentStrategyNameEnum? strategy;
        private Models.Stateful stateful;
        private Models.Constraints constraints;
        private Models.Shutdown shutdown;
        private Models.Startup startup;
        private Models.Update update;
        private Models.Restart restart;
        private Models.HealthCheck healthCheck;
        private Models.Telemetry1 telemetry;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "strategy", false },
            { "stateful", false },
            { "constraints", false },
            { "shutdown", false },
            { "startup", false },
            { "update", false },
            { "restart", false },
            { "health_check", false },
            { "telemetry", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigDeployYml"/> class.
        /// </summary>
        public StackContainerConfigDeployYml()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigDeployYml"/> class.
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
        public StackContainerConfigDeployYml(
            int instances,
            Models.DeploymentStrategyNameEnum? strategy = null,
            Models.Stateful stateful = null,
            Models.Constraints constraints = null,
            Models.Shutdown shutdown = null,
            Models.Startup startup = null,
            Models.Update update = null,
            Models.Restart restart = null,
            Models.HealthCheck healthCheck = null,
            Models.Telemetry1 telemetry = null)
        {
            this.Instances = instances;
            if (strategy != null)
            {
                this.Strategy = strategy;
            }

            if (stateful != null)
            {
                this.Stateful = stateful;
            }

            if (constraints != null)
            {
                this.Constraints = constraints;
            }

            if (shutdown != null)
            {
                this.Shutdown = shutdown;
            }

            if (startup != null)
            {
                this.Startup = startup;
            }

            if (update != null)
            {
                this.Update = update;
            }

            if (restart != null)
            {
                this.Restart = restart;
            }

            if (healthCheck != null)
            {
                this.HealthCheck = healthCheck;
            }

            if (telemetry != null)
            {
                this.Telemetry = telemetry;
            }

        }

        /// <summary>
        /// Gets or sets Instances.
        /// </summary>
        [JsonProperty("instances")]
        public int Instances { get; set; }

        /// <summary>
        /// Gets or sets Strategy.
        /// </summary>
        [JsonProperty("strategy")]
        public Models.DeploymentStrategyNameEnum? Strategy
        {
            get
            {
                return this.strategy;
            }

            set
            {
                this.shouldSerialize["strategy"] = true;
                this.strategy = value;
            }
        }

        /// <summary>
        /// Gets or sets Stateful.
        /// </summary>
        [JsonProperty("stateful")]
        public Models.Stateful Stateful
        {
            get
            {
                return this.stateful;
            }

            set
            {
                this.shouldSerialize["stateful"] = true;
                this.stateful = value;
            }
        }

        /// <summary>
        /// Gets or sets Constraints.
        /// </summary>
        [JsonProperty("constraints")]
        public Models.Constraints Constraints
        {
            get
            {
                return this.constraints;
            }

            set
            {
                this.shouldSerialize["constraints"] = true;
                this.constraints = value;
            }
        }

        /// <summary>
        /// Gets or sets Shutdown.
        /// </summary>
        [JsonProperty("shutdown")]
        public Models.Shutdown Shutdown
        {
            get
            {
                return this.shutdown;
            }

            set
            {
                this.shouldSerialize["shutdown"] = true;
                this.shutdown = value;
            }
        }

        /// <summary>
        /// Gets or sets Startup.
        /// </summary>
        [JsonProperty("startup")]
        public Models.Startup Startup
        {
            get
            {
                return this.startup;
            }

            set
            {
                this.shouldSerialize["startup"] = true;
                this.startup = value;
            }
        }

        /// <summary>
        /// Configurations for container updates.
        /// </summary>
        [JsonProperty("update")]
        public Models.Update Update
        {
            get
            {
                return this.update;
            }

            set
            {
                this.shouldSerialize["update"] = true;
                this.update = value;
            }
        }

        /// <summary>
        /// Gets or sets Restart.
        /// </summary>
        [JsonProperty("restart")]
        public Models.Restart Restart
        {
            get
            {
                return this.restart;
            }

            set
            {
                this.shouldSerialize["restart"] = true;
                this.restart = value;
            }
        }

        /// <summary>
        /// Gets or sets HealthCheck.
        /// </summary>
        [JsonProperty("health_check")]
        public Models.HealthCheck HealthCheck
        {
            get
            {
                return this.healthCheck;
            }

            set
            {
                this.shouldSerialize["health_check"] = true;
                this.healthCheck = value;
            }
        }

        /// <summary>
        /// Gets or sets Telemetry.
        /// </summary>
        [JsonProperty("telemetry")]
        public Models.Telemetry1 Telemetry
        {
            get
            {
                return this.telemetry;
            }

            set
            {
                this.shouldSerialize["telemetry"] = true;
                this.telemetry = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackContainerConfigDeployYml : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStrategy()
        {
            this.shouldSerialize["strategy"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStateful()
        {
            this.shouldSerialize["stateful"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetConstraints()
        {
            this.shouldSerialize["constraints"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetShutdown()
        {
            this.shouldSerialize["shutdown"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStartup()
        {
            this.shouldSerialize["startup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpdate()
        {
            this.shouldSerialize["update"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRestart()
        {
            this.shouldSerialize["restart"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHealthCheck()
        {
            this.shouldSerialize["health_check"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTelemetry()
        {
            this.shouldSerialize["telemetry"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStrategy()
        {
            return this.shouldSerialize["strategy"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStateful()
        {
            return this.shouldSerialize["stateful"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConstraints()
        {
            return this.shouldSerialize["constraints"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShutdown()
        {
            return this.shouldSerialize["shutdown"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStartup()
        {
            return this.shouldSerialize["startup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdate()
        {
            return this.shouldSerialize["update"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRestart()
        {
            return this.shouldSerialize["restart"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHealthCheck()
        {
            return this.shouldSerialize["health_check"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTelemetry()
        {
            return this.shouldSerialize["telemetry"];
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
            return obj is StackContainerConfigDeployYml other &&                this.Instances.Equals(other.Instances) &&
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
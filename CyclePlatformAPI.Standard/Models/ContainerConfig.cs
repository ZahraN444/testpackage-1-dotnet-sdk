// <copyright file="ContainerConfig.cs" company="APIMatic">
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
    /// ContainerConfig.
    /// </summary>
    public class ContainerConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerConfig"/> class.
        /// </summary>
        public ContainerConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerConfig"/> class.
        /// </summary>
        /// <param name="network">network.</param>
        /// <param name="deploy">deploy.</param>
        /// <param name="scale">scale.</param>
        /// <param name="runtime">runtime.</param>
        /// <param name="resources">resources.</param>
        /// <param name="integrations">integrations.</param>
        public ContainerConfig(
            Models.ContainerNetwork network,
            Models.ContainerDeploy deploy,
            Models.ContainerScale scale = null,
            Models.ContainerRuntime runtime = null,
            Models.ContainerResources resources = null,
            Models.ContainerIntegrations integrations = null)
        {
            this.Network = network;
            this.Deploy = deploy;
            this.Scale = scale;
            this.Runtime = runtime;
            this.Resources = resources;
            this.Integrations = integrations;
        }

        /// <summary>
        /// Network configuration for a container.
        /// </summary>
        [JsonProperty("network")]
        public Models.ContainerNetwork Network { get; set; }

        /// <summary>
        /// Deployment configuration for the given container.
        /// </summary>
        [JsonProperty("deploy")]
        public Models.ContainerDeploy Deploy { get; set; }

        /// <summary>
        /// Network configuration for a container.
        /// </summary>
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContainerScale Scale { get; set; }

        /// <summary>
        /// Runtime configurations for a given container.
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContainerRuntime Runtime { get; set; }

        /// <summary>
        /// Configuration settings for the resource allocations and limits of a given container.
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContainerResources Resources { get; set; }

        /// <summary>
        /// Configuration settings for integrations with a given container.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContainerIntegrations Integrations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerConfig : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerConfig other &&                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Deploy == null && other.Deploy == null) || (this.Deploy?.Equals(other.Deploy) == true)) &&
                ((this.Scale == null && other.Scale == null) || (this.Scale?.Equals(other.Scale) == true)) &&
                ((this.Runtime == null && other.Runtime == null) || (this.Runtime?.Equals(other.Runtime) == true)) &&
                ((this.Resources == null && other.Resources == null) || (this.Resources?.Equals(other.Resources) == true)) &&
                ((this.Integrations == null && other.Integrations == null) || (this.Integrations?.Equals(other.Integrations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"this.Deploy = {(this.Deploy == null ? "null" : this.Deploy.ToString())}");
            toStringOutput.Add($"this.Scale = {(this.Scale == null ? "null" : this.Scale.ToString())}");
            toStringOutput.Add($"this.Runtime = {(this.Runtime == null ? "null" : this.Runtime.ToString())}");
            toStringOutput.Add($"this.Resources = {(this.Resources == null ? "null" : this.Resources.ToString())}");
            toStringOutput.Add($"this.Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
        }
    }
}
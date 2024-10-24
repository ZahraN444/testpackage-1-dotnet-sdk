// <copyright file="StackSpecContainerConfig.cs" company="APIMatic">
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
    /// StackSpecContainerConfig.
    /// </summary>
    public class StackSpecContainerConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecContainerConfig"/> class.
        /// </summary>
        public StackSpecContainerConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecContainerConfig"/> class.
        /// </summary>
        /// <param name="network">network.</param>
        /// <param name="deploy">deploy.</param>
        /// <param name="scaling">scaling.</param>
        /// <param name="runtime">runtime.</param>
        /// <param name="resources">resources.</param>
        /// <param name="integrations">integrations.</param>
        public StackSpecContainerConfig(
            Models.StackContainerConfigNetworkYml network,
            Models.StackContainerConfigDeployYml deploy,
            StackSpecContainerConfigScaling scaling = null,
            StackSpecContainerConfigRuntime runtime = null,
            StackSpecContainerConfigResources resources = null,
            StackSpecContainerConfigIntegrations integrations = null)
        {
            this.Network = network;
            this.Deploy = deploy;
            this.Scaling = scaling;
            this.Runtime = runtime;
            this.Resources = resources;
            this.Integrations = integrations;
        }

        /// <summary>
        /// Gets or sets Network.
        /// </summary>
        [JsonProperty("network")]
        public Models.StackContainerConfigNetworkYml Network { get; set; }

        /// <summary>
        /// Gets or sets Deploy.
        /// </summary>
        [JsonProperty("deploy")]
        public Models.StackContainerConfigDeployYml Deploy { get; set; }

        /// <summary>
        /// Gets or sets Scaling.
        /// </summary>
        [JsonProperty("scaling", NullValueHandling = NullValueHandling.Ignore)]
        public StackSpecContainerConfigScaling Scaling { get; set; }

        /// <summary>
        /// Gets or sets Runtime.
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public StackSpecContainerConfigRuntime Runtime { get; set; }

        /// <summary>
        /// Gets or sets Resources.
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public StackSpecContainerConfigResources Resources { get; set; }

        /// <summary>
        /// Gets or sets Integrations.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public StackSpecContainerConfigIntegrations Integrations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackSpecContainerConfig : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackSpecContainerConfig other &&                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Deploy == null && other.Deploy == null) || (this.Deploy?.Equals(other.Deploy) == true)) &&
                ((this.Scaling == null && other.Scaling == null) || (this.Scaling?.Equals(other.Scaling) == true)) &&
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
            toStringOutput.Add($"Scaling = {(this.Scaling == null ? "null" : this.Scaling.ToString())}");
            toStringOutput.Add($"Runtime = {(this.Runtime == null ? "null" : this.Runtime.ToString())}");
            toStringOutput.Add($"Resources = {(this.Resources == null ? "null" : this.Resources.ToString())}");
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
        }
    }
}
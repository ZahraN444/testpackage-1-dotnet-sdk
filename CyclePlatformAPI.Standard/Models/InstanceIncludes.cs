// <copyright file="InstanceIncludes.cs" company="APIMatic">
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
    /// InstanceIncludes.
    /// </summary>
    public class InstanceIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceIncludes"/> class.
        /// </summary>
        public InstanceIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="servers">servers.</param>
        /// <param name="locations">locations.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="integrationsIdentifiers">integrations:identifiers.</param>
        /// <param name="containers">containers.</param>
        /// <param name="containersIdentifiers">containers:identifiers.</param>
        /// <param name="environments">environments.</param>
        /// <param name="environmentsIdentifiers">environments:identifiers.</param>
        public InstanceIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.Server> servers = null,
            Dictionary<string, Models.ProviderLocation> locations = null,
            Dictionary<string, Models.Integration> integrations = null,
            object integrationsIdentifiers = null,
            Dictionary<string, Models.Container> containers = null,
            object containersIdentifiers = null,
            Dictionary<string, Models.Environment> environments = null,
            object environmentsIdentifiers = null)
        {
            this.Creators = creators;
            this.Servers = servers;
            this.Locations = locations;
            this.Integrations = integrations;
            this.IntegrationsIdentifiers = integrationsIdentifiers;
            this.Containers = containers;
            this.ContainersIdentifiers = containersIdentifiers;
            this.Environments = environments;
            this.EnvironmentsIdentifiers = environmentsIdentifiers;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// A resource thats associated with a server.
        /// </summary>
        [JsonProperty("servers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Server> Servers { get; set; }

        /// <summary>
        /// A resource thats associated with a provider location.
        /// </summary>
        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ProviderLocation> Locations { get; set; }

        /// <summary>
        /// A resource thats associated with an integration.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Integration> Integrations { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("integrations:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object IntegrationsIdentifiers { get; set; }

        /// <summary>
        /// A resource thats associated with a contianer.
        /// </summary>
        [JsonProperty("containers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Container> Containers { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("containers:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object ContainersIdentifiers { get; set; }

        /// <summary>
        /// An identity that is associated with an environment.
        /// </summary>
        [JsonProperty("environments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Environment> Environments { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("environments:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object EnvironmentsIdentifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Servers == null && other.Servers == null) || (this.Servers?.Equals(other.Servers) == true)) &&
                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true)) &&
                ((this.Integrations == null && other.Integrations == null) || (this.Integrations?.Equals(other.Integrations) == true)) &&
                ((this.IntegrationsIdentifiers == null && other.IntegrationsIdentifiers == null) || (this.IntegrationsIdentifiers?.Equals(other.IntegrationsIdentifiers) == true)) &&
                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.ContainersIdentifiers == null && other.ContainersIdentifiers == null) || (this.ContainersIdentifiers?.Equals(other.ContainersIdentifiers) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true)) &&
                ((this.EnvironmentsIdentifiers == null && other.EnvironmentsIdentifiers == null) || (this.EnvironmentsIdentifiers?.Equals(other.EnvironmentsIdentifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"Servers = {(this.Servers == null ? "null" : this.Servers.ToString())}");
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
            toStringOutput.Add($"IntegrationsIdentifiers = {(this.IntegrationsIdentifiers == null ? "null" : this.IntegrationsIdentifiers.ToString())}");
            toStringOutput.Add($"Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"ContainersIdentifiers = {(this.ContainersIdentifiers == null ? "null" : this.ContainersIdentifiers.ToString())}");
            toStringOutput.Add($"Environments = {(this.Environments == null ? "null" : this.Environments.ToString())}");
            toStringOutput.Add($"EnvironmentsIdentifiers = {(this.EnvironmentsIdentifiers == null ? "null" : this.EnvironmentsIdentifiers.ToString())}");
        }
    }
}
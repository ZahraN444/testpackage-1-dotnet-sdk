// <copyright file="PoolIncludes.cs" company="APIMatic">
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
    /// PoolIncludes.
    /// </summary>
    public class PoolIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoolIncludes"/> class.
        /// </summary>
        public PoolIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="servers">servers.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="locations">locations.</param>
        public PoolIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.Server> servers = null,
            Dictionary<string, Models.Integration> integrations = null,
            Dictionary<string, Models.ProviderLocation> locations = null)
        {
            this.Creators = creators;
            this.Servers = servers;
            this.Integrations = integrations;
            this.Locations = locations;
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
        /// A resource thats associated with an integration.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Integration> Integrations { get; set; }

        /// <summary>
        /// A resource thats associated with a provider location.
        /// </summary>
        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ProviderLocation> Locations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PoolIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is PoolIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Servers == null && other.Servers == null) || (this.Servers?.Equals(other.Servers) == true)) &&
                ((this.Integrations == null && other.Integrations == null) || (this.Integrations?.Equals(other.Integrations) == true)) &&
                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"Servers = {(this.Servers == null ? "null" : this.Servers.ToString())}");
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
        }
    }
}
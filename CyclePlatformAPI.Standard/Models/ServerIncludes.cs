// <copyright file="ServerIncludes.cs" company="APIMatic">
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
    /// ServerIncludes.
    /// </summary>
    public class ServerIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerIncludes"/> class.
        /// </summary>
        public ServerIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerIncludes"/> class.
        /// </summary>
        /// <param name="locations">locations.</param>
        /// <param name="models">models.</param>
        /// <param name="integrations">integrations.</param>
        public ServerIncludes(
            Dictionary<string, Models.ProviderLocation> locations = null,
            Dictionary<string, Models.ProviderServerModel> models = null,
            Dictionary<string, Models.Integration> integrations = null)
        {
            this.Locations = locations;
            this.Models = models;
            this.Integrations = integrations;
        }

        /// <summary>
        /// A resource thats associated with a provider location.
        /// </summary>
        [JsonProperty("locations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ProviderLocation> Locations { get; set; }

        /// <summary>
        /// A resources that assocaited with a provider server.
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ProviderServerModel> Models { get; set; }

        /// <summary>
        /// A resource thats associated with an integration.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Integration> Integrations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerIncludes other &&                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true)) &&
                ((this.Models == null && other.Models == null) || (this.Models?.Equals(other.Models) == true)) &&
                ((this.Integrations == null && other.Integrations == null) || (this.Integrations?.Equals(other.Integrations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
            toStringOutput.Add($"Models = {(this.Models == null ? "null" : this.Models.ToString())}");
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
        }
    }
}
// <copyright file="AutoScaleGroupIncludes.cs" company="APIMatic">
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
    /// AutoScaleGroupIncludes.
    /// </summary>
    public class AutoScaleGroupIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupIncludes"/> class.
        /// </summary>
        public AutoScaleGroupIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupIncludes"/> class.
        /// </summary>
        /// <param name="integrations">integrations.</param>
        /// <param name="models">models.</param>
        /// <param name="locations">locations.</param>
        public AutoScaleGroupIncludes(
            Dictionary<string, Models.Integration> integrations = null,
            Dictionary<string, Models.ProviderServerModel> models = null,
            Dictionary<string, Models.ProviderLocation> locations = null)
        {
            this.Integrations = integrations;
            this.Models = models;
            this.Locations = locations;
        }

        /// <summary>
        /// A resource thats associated with an integration.
        /// </summary>
        [JsonProperty("integrations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Integration> Integrations { get; set; }

        /// <summary>
        /// A resource associated with a server models.
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ProviderServerModel> Models { get; set; }

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

            return $"AutoScaleGroupIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoScaleGroupIncludes other &&                ((this.Integrations == null && other.Integrations == null) || (this.Integrations?.Equals(other.Integrations) == true)) &&
                ((this.Models == null && other.Models == null) || (this.Models?.Equals(other.Models) == true)) &&
                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Integrations = {(this.Integrations == null ? "null" : this.Integrations.ToString())}");
            toStringOutput.Add($"Models = {(this.Models == null ? "null" : this.Models.ToString())}");
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
        }
    }
}
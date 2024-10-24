// <copyright file="Providers.cs" company="APIMatic">
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
    /// Providers.
    /// </summary>
    public class Providers
    {
        private Dictionary<string, int> locations;
        private Dictionary<string, int> models;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "locations", false },
            { "models", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Providers"/> class.
        /// </summary>
        public Providers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Providers"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="locations">locations.</param>
        /// <param name="models">models.</param>
        /// <param name="resources">resources.</param>
        public Providers(
            double count,
            Dictionary<string, int> locations = null,
            Dictionary<string, int> models = null,
            Models.InfrastructureResourceSummary resources = null)
        {
            this.Count = count;
            if (locations != null)
            {
                this.Locations = locations;
            }

            if (models != null)
            {
                this.Models = models;
            }

            this.Resources = resources;
        }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count")]
        public double Count { get; set; }

        /// <summary>
        /// Gets or sets Locations.
        /// </summary>
        [JsonProperty("locations")]
        public Dictionary<string, int> Locations
        {
            get
            {
                return this.locations;
            }

            set
            {
                this.shouldSerialize["locations"] = true;
                this.locations = value;
            }
        }

        /// <summary>
        /// Gets or sets Models.
        /// </summary>
        [JsonProperty("models")]
        public Dictionary<string, int> Models
        {
            get
            {
                return this.models;
            }

            set
            {
                this.shouldSerialize["models"] = true;
                this.models = value;
            }
        }

        /// <summary>
        /// A summary of resource utilization/availability.
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InfrastructureResourceSummary Resources { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Providers : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocations()
        {
            this.shouldSerialize["locations"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetModels()
        {
            this.shouldSerialize["models"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocations()
        {
            return this.shouldSerialize["locations"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeModels()
        {
            return this.shouldSerialize["models"];
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
            return obj is Providers other &&                this.Count.Equals(other.Count) &&
                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true)) &&
                ((this.Models == null && other.Models == null) || (this.Models?.Equals(other.Models) == true)) &&
                ((this.Resources == null && other.Resources == null) || (this.Resources?.Equals(other.Resources) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {this.Count}");
            toStringOutput.Add($"Locations = {(this.Locations == null ? "null" : this.Locations.ToString())}");
            toStringOutput.Add($"Models = {(this.Models == null ? "null" : this.Models.ToString())}");
            toStringOutput.Add($"this.Resources = {(this.Resources == null ? "null" : this.Resources.ToString())}");
        }
    }
}
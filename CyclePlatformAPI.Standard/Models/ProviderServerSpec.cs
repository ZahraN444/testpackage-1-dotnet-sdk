// <copyright file="ProviderServerSpec.cs" company="APIMatic">
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
    /// ProviderServerSpec.
    /// </summary>
    public class ProviderServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderServerSpec"/> class.
        /// </summary>
        public ProviderServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderServerSpec"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="category">category.</param>
        /// <param name="model">model.</param>
        /// <param name="locations">locations.</param>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="mClass">class.</param>
        /// <param name="availabilityZones">availability_zones.</param>
        public ProviderServerSpec(
            string identifier,
            string category,
            string model,
            List<string> locations,
            ProviderServerSpecIntegrationId integrationId = null,
            string mClass = null,
            object availabilityZones = null)
        {
            this.Identifier = identifier;
            this.IntegrationId = integrationId;
            this.Category = category;
            this.MClass = mClass;
            this.Model = model;
            this.Locations = locations;
            this.AvailabilityZones = availabilityZones;
        }

        /// <summary>
        /// A provider identifier
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets IntegrationId.
        /// </summary>
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderServerSpecIntegrationId IntegrationId { get; set; }

        /// <summary>
        /// A category for the server.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// A class for the server.
        /// </summary>
        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string MClass { get; set; }

        /// <summary>
        /// The model of the server.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// A list of location ID's this server is available.
        /// </summary>
        [JsonProperty("locations")]
        public List<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets AvailabilityZones.
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public object AvailabilityZones { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProviderServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProviderServerSpec other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.MClass == null && other.MClass == null) || (this.MClass?.Equals(other.MClass) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true)) &&
                ((this.AvailabilityZones == null && other.AvailabilityZones == null) || (this.AvailabilityZones?.Equals(other.AvailabilityZones) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId.ToString())}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category)}");
            toStringOutput.Add($"this.MClass = {(this.MClass == null ? "null" : this.MClass)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Locations = {(this.Locations == null ? "null" : $"[{string.Join(", ", this.Locations)} ]")}");
            toStringOutput.Add($"AvailabilityZones = {(this.AvailabilityZones == null ? "null" : this.AvailabilityZones.ToString())}");
        }
    }
}
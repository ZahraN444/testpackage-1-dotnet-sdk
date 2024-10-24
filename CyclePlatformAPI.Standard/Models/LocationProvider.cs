// <copyright file="LocationProvider.cs" company="APIMatic">
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
    /// LocationProvider.
    /// </summary>
    public class LocationProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationProvider"/> class.
        /// </summary>
        public LocationProvider()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationProvider"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="location">location.</param>
        /// <param name="code">code.</param>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="availabilityZones">availability_zones.</param>
        public LocationProvider(
            string identifier,
            string location,
            string code,
            string integrationId = null,
            List<string> availabilityZones = null)
        {
            this.Identifier = identifier;
            this.IntegrationId = integrationId;
            this.Location = location;
            this.Code = code;
            this.AvailabilityZones = availabilityZones;
        }

        /// <summary>
        /// An identifier for the given provider
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The ID of the provider integration associated with this location.
        /// </summary>
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// A location name returned from the provider.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// A location code returned from the provider.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets AvailabilityZones.
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZones { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationProvider : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationProvider other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.AvailabilityZones == null && other.AvailabilityZones == null) || (this.AvailabilityZones?.Equals(other.AvailabilityZones) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.AvailabilityZones = {(this.AvailabilityZones == null ? "null" : $"[{string.Join(", ", this.AvailabilityZones)} ]")}");
        }
    }
}
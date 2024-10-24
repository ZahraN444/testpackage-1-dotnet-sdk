// <copyright file="Servers1.cs" company="APIMatic">
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
    /// Servers1.
    /// </summary>
    public class Servers1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Servers1"/> class.
        /// </summary>
        public Servers1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Servers1"/> class.
        /// </summary>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="modelId">model_id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="hostnames">hostnames.</param>
        /// <param name="advanced">advanced.</param>
        public Servers1(
            string integrationId,
            string modelId,
            string locationId,
            int quantity,
            List<string> hostnames = null,
            List<Models.Advanced> advanced = null)
        {
            this.IntegrationId = integrationId;
            this.ModelId = modelId;
            this.LocationId = locationId;
            this.Quantity = quantity;
            this.Hostnames = hostnames;
            this.Advanced = advanced;
        }

        /// <summary>
        /// The ID of the provider integration to use for this Server.
        /// </summary>
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        /// <summary>
        /// The model ID of the Server.
        /// </summary>
        [JsonProperty("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// The location ID of the Server.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// The number of this Server at this location to deploy.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// An array of hostnames for the given servers.
        /// </summary>
        [JsonProperty("hostnames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hostnames { get; set; }

        /// <summary>
        /// Gets or sets Advanced.
        /// </summary>
        [JsonProperty("advanced", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Advanced> Advanced { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Servers1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Servers1 other &&                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.ModelId == null && other.ModelId == null) || (this.ModelId?.Equals(other.ModelId) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                this.Quantity.Equals(other.Quantity) &&
                ((this.Hostnames == null && other.Hostnames == null) || (this.Hostnames?.Equals(other.Hostnames) == true)) &&
                ((this.Advanced == null && other.Advanced == null) || (this.Advanced?.Equals(other.Advanced) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
            toStringOutput.Add($"this.ModelId = {(this.ModelId == null ? "null" : this.ModelId)}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.Quantity = {this.Quantity}");
            toStringOutput.Add($"this.Hostnames = {(this.Hostnames == null ? "null" : $"[{string.Join(", ", this.Hostnames)} ]")}");
            toStringOutput.Add($"this.Advanced = {(this.Advanced == null ? "null" : $"[{string.Join(", ", this.Advanced)} ]")}");
        }
    }
}
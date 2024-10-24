// <copyright file="Model.cs" company="APIMatic">
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
    /// Model.
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model"/> class.
        /// </summary>
        public Model()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model"/> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="modelId">model_id.</param>
        /// <param name="priority">priority.</param>
        /// <param name="locations">locations.</param>
        /// <param name="integrationId">integration_id.</param>
        public Model(
            string provider,
            string modelId,
            int priority,
            List<Models.Location> locations,
            string integrationId = null)
        {
            this.Provider = provider;
            this.IntegrationId = integrationId;
            this.ModelId = modelId;
            this.Priority = priority;
            this.Locations = locations;
        }

        /// <summary>
        /// The integration identifier for infrastructure provider used.
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The ID of the integration associated with this auto-scale group infrastructure.
        /// </summary>
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Gets or sets ModelId.
        /// </summary>
        [JsonProperty("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// Gets or sets Priority.
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets Locations.
        /// </summary>
        [JsonProperty("locations")]
        public List<Models.Location> Locations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Model : ({string.Join(", ", toStringOutput)})";
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
            return obj is Model other &&                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.ModelId == null && other.ModelId == null) || (this.ModelId?.Equals(other.ModelId) == true)) &&
                this.Priority.Equals(other.Priority) &&
                ((this.Locations == null && other.Locations == null) || (this.Locations?.Equals(other.Locations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider)}");
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
            toStringOutput.Add($"this.ModelId = {(this.ModelId == null ? "null" : this.ModelId)}");
            toStringOutput.Add($"this.Priority = {this.Priority}");
            toStringOutput.Add($"this.Locations = {(this.Locations == null ? "null" : $"[{string.Join(", ", this.Locations)} ]")}");
        }
    }
}
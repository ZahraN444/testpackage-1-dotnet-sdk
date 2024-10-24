// <copyright file="ProviderServerModel.cs" company="APIMatic">
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
    /// ProviderServerModel.
    /// </summary>
    public class ProviderServerModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderServerModel"/> class.
        /// </summary>
        public ProviderServerModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderServerModel"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="specs">specs.</param>
        /// <param name="provider">provider.</param>
        /// <param name="price">price.</param>
        /// <param name="compatible">compatible.</param>
        /// <param name="lowResource">low_resource.</param>
        /// <param name="locationIds">location_ids.</param>
        public ProviderServerModel(
            string id,
            string name,
            string description,
            Models.ServerSpecs specs,
            Models.ProviderServerSpec provider,
            Models.BillingAmount price,
            bool compatible,
            bool lowResource,
            List<string> locationIds)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Specs = specs;
            this.Provider = provider;
            this.Price = price;
            this.Compatible = compatible;
            this.LowResource = lowResource;
            this.LocationIds = locationIds;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A name for the server.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description of the server.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Specs for a given server
        /// </summary>
        [JsonProperty("specs")]
        public Models.ServerSpecs Specs { get; set; }

        /// <summary>
        /// Higher level information about a providers server.
        /// </summary>
        [JsonProperty("provider")]
        public Models.ProviderServerSpec Provider { get; set; }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("price")]
        public Models.BillingAmount Price { get; set; }

        /// <summary>
        /// A boolean where true signifies this server is compatible with the platform.
        /// </summary>
        [JsonProperty("compatible")]
        public bool Compatible { get; set; }

        /// <summary>
        /// A boolean where true signifies the server has a limited amount of resources and should only be used for very lightweight workloads.
        /// </summary>
        [JsonProperty("low_resource")]
        public bool LowResource { get; set; }

        /// <summary>
        /// An array of location IDs where this server type is available.
        /// </summary>
        [JsonProperty("location_ids")]
        public List<string> LocationIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProviderServerModel : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProviderServerModel other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Specs == null && other.Specs == null) || (this.Specs?.Equals(other.Specs) == true)) &&
                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                this.Compatible.Equals(other.Compatible) &&
                this.LowResource.Equals(other.LowResource) &&
                ((this.LocationIds == null && other.LocationIds == null) || (this.LocationIds?.Equals(other.LocationIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Specs = {(this.Specs == null ? "null" : this.Specs.ToString())}");
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.Compatible = {this.Compatible}");
            toStringOutput.Add($"this.LowResource = {this.LowResource}");
            toStringOutput.Add($"this.LocationIds = {(this.LocationIds == null ? "null" : $"[{string.Join(", ", this.LocationIds)} ]")}");
        }
    }
}
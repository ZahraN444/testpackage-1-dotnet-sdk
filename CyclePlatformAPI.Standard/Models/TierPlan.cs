// <copyright file="TierPlan.cs" company="APIMatic">
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
    /// TierPlan.
    /// </summary>
    public class TierPlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TierPlan"/> class.
        /// </summary>
        public TierPlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TierPlan"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="generation">generation.</param>
        /// <param name="usable">usable.</param>
        /// <param name="price">price.</param>
        /// <param name="servers">servers.</param>
        /// <param name="members">members.</param>
        /// <param name="advancedFeatures">advanced_features.</param>
        /// <param name="ram">ram.</param>
        /// <param name="imageStorage">image_storage.</param>
        /// <param name="builds">builds.</param>
        /// <param name="hidden">hidden.</param>
        /// <param name="description">description.</param>
        /// <param name="maxNodes">max_nodes.</param>
        /// <param name="maxMembers">max_members.</param>
        /// <param name="maxDailyApiRequests">max_daily_api_requests.</param>
        public TierPlan(
            string id,
            string name,
            string code,
            int generation,
            bool usable,
            Models.BillingAmount price,
            Models.BillingServers servers,
            Models.BillingMembers members,
            Models.AdvancedFeatures advancedFeatures,
            Models.BillingRam ram,
            Models.BillingImageStorage imageStorage,
            Models.BillingBuilds builds,
            bool hidden,
            string description,
            int? maxNodes = null,
            int? maxMembers = null,
            int? maxDailyApiRequests = null)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.Generation = generation;
            this.Usable = usable;
            this.Price = price;
            this.Servers = servers;
            this.Members = members;
            this.MaxNodes = maxNodes;
            this.MaxMembers = maxMembers;
            this.AdvancedFeatures = advancedFeatures;
            this.MaxDailyApiRequests = maxDailyApiRequests;
            this.Ram = ram;
            this.ImageStorage = imageStorage;
            this.Builds = builds;
            this.Hidden = hidden;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Generation.
        /// </summary>
        [JsonProperty("generation")]
        public int Generation { get; set; }

        /// <summary>
        /// Gets or sets Usable.
        /// </summary>
        [JsonProperty("usable")]
        public bool Usable { get; set; }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("price")]
        public Models.BillingAmount Price { get; set; }

        /// <summary>
        /// An object holding information about servers included in Billing tier
        /// </summary>
        [JsonProperty("servers")]
        public Models.BillingServers Servers { get; set; }

        /// <summary>
        /// An object holding information about members included in Billing tier
        /// </summary>
        [JsonProperty("members")]
        public Models.BillingMembers Members { get; set; }

        /// <summary>
        /// Gets or sets MaxNodes.
        /// </summary>
        [JsonProperty("max_nodes", NullValueHandling = NullValueHandling.Include)]
        public int? MaxNodes { get; set; }

        /// <summary>
        /// Gets or sets MaxMembers.
        /// </summary>
        [JsonProperty("max_members", NullValueHandling = NullValueHandling.Include)]
        public int? MaxMembers { get; set; }

        /// <summary>
        /// Gets or sets AdvancedFeatures.
        /// </summary>
        [JsonProperty("advanced_features")]
        public Models.AdvancedFeatures AdvancedFeatures { get; set; }

        /// <summary>
        /// Gets or sets MaxDailyApiRequests.
        /// </summary>
        [JsonProperty("max_daily_api_requests", NullValueHandling = NullValueHandling.Include)]
        public int? MaxDailyApiRequests { get; set; }

        /// <summary>
        /// An object holding information about servers included in Billing tier
        /// </summary>
        [JsonProperty("ram")]
        public Models.BillingRam Ram { get; set; }

        /// <summary>
        /// An object holding information about servers included in Billing tier
        /// </summary>
        [JsonProperty("image_storage")]
        public Models.BillingImageStorage ImageStorage { get; set; }

        /// <summary>
        /// An object holding information about servers included in Billing tier
        /// </summary>
        [JsonProperty("builds")]
        public Models.BillingBuilds Builds { get; set; }

        /// <summary>
        /// Gets or sets Hidden.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TierPlan : ({string.Join(", ", toStringOutput)})";
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
            return obj is TierPlan other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                this.Generation.Equals(other.Generation) &&
                this.Usable.Equals(other.Usable) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.Servers == null && other.Servers == null) || (this.Servers?.Equals(other.Servers) == true)) &&
                ((this.Members == null && other.Members == null) || (this.Members?.Equals(other.Members) == true)) &&
                ((this.MaxNodes == null && other.MaxNodes == null) || (this.MaxNodes?.Equals(other.MaxNodes) == true)) &&
                ((this.MaxMembers == null && other.MaxMembers == null) || (this.MaxMembers?.Equals(other.MaxMembers) == true)) &&
                ((this.AdvancedFeatures == null && other.AdvancedFeatures == null) || (this.AdvancedFeatures?.Equals(other.AdvancedFeatures) == true)) &&
                ((this.MaxDailyApiRequests == null && other.MaxDailyApiRequests == null) || (this.MaxDailyApiRequests?.Equals(other.MaxDailyApiRequests) == true)) &&
                ((this.Ram == null && other.Ram == null) || (this.Ram?.Equals(other.Ram) == true)) &&
                ((this.ImageStorage == null && other.ImageStorage == null) || (this.ImageStorage?.Equals(other.ImageStorage) == true)) &&
                ((this.Builds == null && other.Builds == null) || (this.Builds?.Equals(other.Builds) == true)) &&
                this.Hidden.Equals(other.Hidden) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Generation = {this.Generation}");
            toStringOutput.Add($"this.Usable = {this.Usable}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.Servers = {(this.Servers == null ? "null" : this.Servers.ToString())}");
            toStringOutput.Add($"this.Members = {(this.Members == null ? "null" : this.Members.ToString())}");
            toStringOutput.Add($"this.MaxNodes = {(this.MaxNodes == null ? "null" : this.MaxNodes.ToString())}");
            toStringOutput.Add($"this.MaxMembers = {(this.MaxMembers == null ? "null" : this.MaxMembers.ToString())}");
            toStringOutput.Add($"this.AdvancedFeatures = {(this.AdvancedFeatures == null ? "null" : this.AdvancedFeatures.ToString())}");
            toStringOutput.Add($"this.MaxDailyApiRequests = {(this.MaxDailyApiRequests == null ? "null" : this.MaxDailyApiRequests.ToString())}");
            toStringOutput.Add($"this.Ram = {(this.Ram == null ? "null" : this.Ram.ToString())}");
            toStringOutput.Add($"this.ImageStorage = {(this.ImageStorage == null ? "null" : this.ImageStorage.ToString())}");
            toStringOutput.Add($"this.Builds = {(this.Builds == null ? "null" : this.Builds.ToString())}");
            toStringOutput.Add($"this.Hidden = {this.Hidden}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}
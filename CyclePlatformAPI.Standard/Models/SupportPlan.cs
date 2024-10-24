// <copyright file="SupportPlan.cs" company="APIMatic">
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
    /// SupportPlan.
    /// </summary>
    public class SupportPlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportPlan"/> class.
        /// </summary>
        public SupportPlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportPlan"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="price">price.</param>
        /// <param name="description">description.</param>
        /// <param name="features">features.</param>
        /// <param name="contract">contract.</param>
        /// <param name="mDefault">default.</param>
        public SupportPlan(
            string name,
            Models.BillingAmount price,
            string description,
            Models.SupportPlanFeatures features,
            bool contract,
            bool mDefault)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Features = features;
            this.Contract = contract;
            this.MDefault = mDefault;
        }

        /// <summary>
        /// The name of the support plan.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// An object holding information about term and amount that relates to a specific billing component.
        /// </summary>
        [JsonProperty("price")]
        public Models.BillingAmount Price { get; set; }

        /// <summary>
        /// Information about the billing support plan that describes the plan.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information about billing support plan features.
        /// </summary>
        [JsonProperty("features")]
        public Models.SupportPlanFeatures Features { get; set; }

        /// <summary>
        /// A boolean where true represents the plan is a long term contract, not just month to month.
        /// </summary>
        [JsonProperty("contract")]
        public bool Contract { get; set; }

        /// <summary>
        /// This returns true if it shows up.
        /// </summary>
        [JsonProperty("default")]
        public bool MDefault { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SupportPlan : ({string.Join(", ", toStringOutput)})";
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
            return obj is SupportPlan other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Price == null && other.Price == null) || (this.Price?.Equals(other.Price) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                this.Contract.Equals(other.Contract) &&
                this.MDefault.Equals(other.MDefault);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
            toStringOutput.Add($"this.Contract = {this.Contract}");
            toStringOutput.Add($"this.MDefault = {this.MDefault}");
        }
    }
}
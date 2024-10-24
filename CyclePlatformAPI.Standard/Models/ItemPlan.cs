// <copyright file="ItemPlan.cs" company="APIMatic">
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
    /// ItemPlan.
    /// </summary>
    public class ItemPlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPlan"/> class.
        /// </summary>
        public ItemPlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPlan"/> class.
        /// </summary>
        /// <param name="support">support.</param>
        /// <param name="tier">tier.</param>
        public ItemPlan(
            Models.Support support = null,
            Models.Tier tier = null)
        {
            this.Support = support;
            this.Tier = tier;
        }

        /// <summary>
        /// Information about the support component of the billing item.
        /// </summary>
        [JsonProperty("support", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Support Support { get; set; }

        /// <summary>
        /// Information about the tier component of the billing item.
        /// </summary>
        [JsonProperty("tier", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Tier Tier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ItemPlan : ({string.Join(", ", toStringOutput)})";
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
            return obj is ItemPlan other &&                ((this.Support == null && other.Support == null) || (this.Support?.Equals(other.Support) == true)) &&
                ((this.Tier == null && other.Tier == null) || (this.Tier?.Equals(other.Tier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Support = {(this.Support == null ? "null" : this.Support.ToString())}");
            toStringOutput.Add($"this.Tier = {(this.Tier == null ? "null" : this.Tier.ToString())}");
        }
    }
}
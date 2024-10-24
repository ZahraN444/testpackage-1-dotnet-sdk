// <copyright file="Plans.cs" company="APIMatic">
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
    /// Plans.
    /// </summary>
    public class Plans
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plans"/> class.
        /// </summary>
        public Plans()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plans"/> class.
        /// </summary>
        /// <param name="tierId">tier_id.</param>
        /// <param name="supportId">support_id.</param>
        public Plans(
            string tierId = null,
            string supportId = null)
        {
            this.TierId = tierId;
            this.SupportId = supportId;
        }

        /// <summary>
        /// An ID referencing the pricing tier applied to this hub.
        /// </summary>
        [JsonProperty("tier_id", NullValueHandling = NullValueHandling.Include)]
        public string TierId { get; set; }

        /// <summary>
        /// An ID referencing the support plan applied to this hub.
        /// </summary>
        [JsonProperty("support_id", NullValueHandling = NullValueHandling.Include)]
        public string SupportId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Plans : ({string.Join(", ", toStringOutput)})";
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
            return obj is Plans other &&                ((this.TierId == null && other.TierId == null) || (this.TierId?.Equals(other.TierId) == true)) &&
                ((this.SupportId == null && other.SupportId == null) || (this.SupportId?.Equals(other.SupportId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TierId = {(this.TierId == null ? "null" : this.TierId)}");
            toStringOutput.Add($"this.SupportId = {(this.SupportId == null ? "null" : this.SupportId)}");
        }
    }
}
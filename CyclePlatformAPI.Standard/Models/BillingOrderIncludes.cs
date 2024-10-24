// <copyright file="BillingOrderIncludes.cs" company="APIMatic">
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
    /// BillingOrderIncludes.
    /// </summary>
    public class BillingOrderIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOrderIncludes"/> class.
        /// </summary>
        public BillingOrderIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOrderIncludes"/> class.
        /// </summary>
        /// <param name="promoCodes">promo_codes.</param>
        public BillingOrderIncludes(
            Dictionary<string, Models.PromoCode> promoCodes = null)
        {
            this.PromoCodes = promoCodes;
        }

        /// <summary>
        /// A resource thats associated with a promo code.
        /// </summary>
        [JsonProperty("promo_codes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.PromoCode> PromoCodes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingOrderIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingOrderIncludes other &&                ((this.PromoCodes == null && other.PromoCodes == null) || (this.PromoCodes?.Equals(other.PromoCodes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PromoCodes = {(this.PromoCodes == null ? "null" : this.PromoCodes.ToString())}");
        }
    }
}
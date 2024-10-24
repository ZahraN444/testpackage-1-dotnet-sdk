// <copyright file="V1BillingOrdersRequest.cs" company="APIMatic">
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
    /// V1BillingOrdersRequest.
    /// </summary>
    public class V1BillingOrdersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingOrdersRequest"/> class.
        /// </summary>
        public V1BillingOrdersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingOrdersRequest"/> class.
        /// </summary>
        /// <param name="tierPlanId">tier_plan_id.</param>
        /// <param name="supportPlanId">support_plan_id.</param>
        /// <param name="termLength">term_length.</param>
        /// <param name="promoCode">promo_code.</param>
        public V1BillingOrdersRequest(
            string tierPlanId = null,
            string supportPlanId = null,
            Models.TermLengthEnum? termLength = null,
            string promoCode = null)
        {
            this.TierPlanId = tierPlanId;
            this.SupportPlanId = supportPlanId;
            this.TermLength = termLength;
            this.PromoCode = promoCode;
        }

        /// <summary>
        /// ID associated with the tier plan
        /// </summary>
        [JsonProperty("tier_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TierPlanId { get; set; }

        /// <summary>
        /// ID associated with the support plan
        /// </summary>
        [JsonProperty("support_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportPlanId { get; set; }

        /// <summary>
        /// String that defines term length
        /// </summary>
        [JsonProperty("term_length", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TermLengthEnum? TermLength { get; set; }

        /// <summary>
        /// String that defines a promo code
        /// </summary>
        [JsonProperty("promo_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PromoCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1BillingOrdersRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1BillingOrdersRequest other &&                ((this.TierPlanId == null && other.TierPlanId == null) || (this.TierPlanId?.Equals(other.TierPlanId) == true)) &&
                ((this.SupportPlanId == null && other.SupportPlanId == null) || (this.SupportPlanId?.Equals(other.SupportPlanId) == true)) &&
                ((this.TermLength == null && other.TermLength == null) || (this.TermLength?.Equals(other.TermLength) == true)) &&
                ((this.PromoCode == null && other.PromoCode == null) || (this.PromoCode?.Equals(other.PromoCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TierPlanId = {(this.TierPlanId == null ? "null" : this.TierPlanId)}");
            toStringOutput.Add($"this.SupportPlanId = {(this.SupportPlanId == null ? "null" : this.SupportPlanId)}");
            toStringOutput.Add($"this.TermLength = {(this.TermLength == null ? "null" : this.TermLength.ToString())}");
            toStringOutput.Add($"this.PromoCode = {(this.PromoCode == null ? "null" : this.PromoCode)}");
        }
    }
}
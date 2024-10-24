// <copyright file="PromoCode.cs" company="APIMatic">
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
    /// PromoCode.
    /// </summary>
    public class PromoCode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoCode"/> class.
        /// </summary>
        public PromoCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoCode"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="state">state.</param>
        /// <param name="credit">credit.</param>
        public PromoCode(
            string code,
            Models.PromoCodeState state,
            Dictionary<string, Models.Credit> credit = null)
        {
            this.Code = code;
            this.Credit = credit;
            this.State = state;
        }

        /// <summary>
        /// The promo "code".
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The amount of credit the promo code offers.
        /// </summary>
        [JsonProperty("credit", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, Models.Credit> Credit { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.PromoCodeState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PromoCode : ({string.Join(", ", toStringOutput)})";
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
            return obj is PromoCode other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Credit == null && other.Credit == null) || (this.Credit?.Equals(other.Credit) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"Credit = {(this.Credit == null ? "null" : this.Credit.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}
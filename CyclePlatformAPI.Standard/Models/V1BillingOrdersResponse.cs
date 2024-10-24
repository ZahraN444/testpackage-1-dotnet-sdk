// <copyright file="V1BillingOrdersResponse.cs" company="APIMatic">
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
    /// V1BillingOrdersResponse.
    /// </summary>
    public class V1BillingOrdersResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingOrdersResponse"/> class.
        /// </summary>
        public V1BillingOrdersResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1BillingOrdersResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="includes">includes.</param>
        public V1BillingOrdersResponse(
            List<Models.Order> data,
            Models.BillingOrderIncludes includes = null)
        {
            this.Data = data;
            this.Includes = includes;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.Order> Data { get; set; }

        /// <summary>
        /// Gets or sets Includes.
        /// </summary>
        [JsonProperty("includes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingOrderIncludes Includes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1BillingOrdersResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1BillingOrdersResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Includes == null && other.Includes == null) || (this.Includes?.Equals(other.Includes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Includes = {(this.Includes == null ? "null" : this.Includes.ToString())}");
        }
    }
}
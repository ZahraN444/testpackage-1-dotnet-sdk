// <copyright file="BillingMethodExpiration.cs" company="APIMatic">
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
    /// BillingMethodExpiration.
    /// </summary>
    public class BillingMethodExpiration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingMethodExpiration"/> class.
        /// </summary>
        public BillingMethodExpiration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingMethodExpiration"/> class.
        /// </summary>
        /// <param name="month">month.</param>
        /// <param name="year">year.</param>
        public BillingMethodExpiration(
            int month,
            int year)
        {
            this.Month = month;
            this.Year = year;
        }

        /// <summary>
        /// The month the billing method expires.
        /// </summary>
        [JsonProperty("month")]
        public int Month { get; set; }

        /// <summary>
        /// The year the billing method expires.
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingMethodExpiration : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingMethodExpiration other &&                this.Month.Equals(other.Month) &&
                this.Year.Equals(other.Year);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Month = {this.Month}");
            toStringOutput.Add($"this.Year = {this.Year}");
        }
    }
}
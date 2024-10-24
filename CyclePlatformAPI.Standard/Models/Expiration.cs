// <copyright file="Expiration.cs" company="APIMatic">
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
    /// Expiration.
    /// </summary>
    public class Expiration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expiration"/> class.
        /// </summary>
        public Expiration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Expiration"/> class.
        /// </summary>
        /// <param name="month">month.</param>
        /// <param name="year">year.</param>
        public Expiration(
            double month,
            double year)
        {
            this.Month = month;
            this.Year = year;
        }

        /// <summary>
        /// Gets or sets Month.
        /// </summary>
        [JsonProperty("month")]
        public double Month { get; set; }

        /// <summary>
        /// Gets or sets Year.
        /// </summary>
        [JsonProperty("year")]
        public double Year { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Expiration : ({string.Join(", ", toStringOutput)})";
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
            return obj is Expiration other &&                this.Month.Equals(other.Month) &&
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
// <copyright file="Ram.cs" company="APIMatic">
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
    /// Ram.
    /// </summary>
    public class Ram
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ram"/> class.
        /// </summary>
        public Ram()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ram"/> class.
        /// </summary>
        /// <param name="gbHours">gb_hours.</param>
        /// <param name="cost">cost.</param>
        public Ram(
            int gbHours,
            int cost)
        {
            this.GbHours = gbHours;
            this.Cost = cost;
        }

        /// <summary>
        /// The number of hours of overage.
        /// </summary>
        [JsonProperty("gb_hours")]
        public int GbHours { get; set; }

        /// <summary>
        /// The cost of the overage.
        /// </summary>
        [JsonProperty("cost")]
        public int Cost { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ram : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ram other &&                this.GbHours.Equals(other.GbHours) &&
                this.Cost.Equals(other.Cost);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GbHours = {this.GbHours}");
            toStringOutput.Add($"this.Cost = {this.Cost}");
        }
    }
}
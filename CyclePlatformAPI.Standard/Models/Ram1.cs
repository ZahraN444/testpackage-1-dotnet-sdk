// <copyright file="Ram1.cs" company="APIMatic">
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
    /// Ram1.
    /// </summary>
    public class Ram1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ram1"/> class.
        /// </summary>
        public Ram1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ram1"/> class.
        /// </summary>
        /// <param name="limit">limit.</param>
        /// <param name="reserve">reserve.</param>
        /// <param name="swappiness">swappiness.</param>
        public Ram1(
            string limit = null,
            string reserve = null,
            double? swappiness = null)
        {
            this.Limit = limit;
            this.Reserve = reserve;
            this.Swappiness = swappiness;
        }

        /// <summary>
        /// Gets or sets Limit.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// Gets or sets Reserve.
        /// </summary>
        [JsonProperty("reserve", NullValueHandling = NullValueHandling.Ignore)]
        public string Reserve { get; set; }

        /// <summary>
        /// Gets or sets Swappiness.
        /// </summary>
        [JsonProperty("swappiness", NullValueHandling = NullValueHandling.Ignore)]
        public double? Swappiness { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ram1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ram1 other &&                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Reserve == null && other.Reserve == null) || (this.Reserve?.Equals(other.Reserve) == true)) &&
                ((this.Swappiness == null && other.Swappiness == null) || (this.Swappiness?.Equals(other.Swappiness) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Reserve = {(this.Reserve == null ? "null" : this.Reserve)}");
            toStringOutput.Add($"this.Swappiness = {(this.Swappiness == null ? "null" : this.Swappiness.ToString())}");
        }
    }
}
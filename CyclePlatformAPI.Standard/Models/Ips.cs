// <copyright file="Ips.cs" company="APIMatic">
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
    /// Ips.
    /// </summary>
    public class Ips
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ips"/> class.
        /// </summary>
        public Ips()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ips"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="available">available.</param>
        public Ips(
            int total,
            int available)
        {
            this.Total = total;
            this.Available = available;
        }

        /// <summary>
        /// The total number of IPs in the pool.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Of the total number of IP's how many are available to be assigned.
        /// </summary>
        [JsonProperty("available")]
        public int Available { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ips : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ips other &&                this.Total.Equals(other.Total) &&
                this.Available.Equals(other.Available);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.Available = {this.Available}");
        }
    }
}
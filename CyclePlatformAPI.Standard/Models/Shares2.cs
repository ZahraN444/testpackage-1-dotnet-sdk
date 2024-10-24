// <copyright file="Shares2.cs" company="APIMatic">
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
    /// Shares2.
    /// </summary>
    public class Shares2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shares2"/> class.
        /// </summary>
        public Shares2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shares2"/> class.
        /// </summary>
        /// <param name="allocated">allocated.</param>
        /// <param name="total">total.</param>
        public Shares2(
            int allocated,
            int total)
        {
            this.Allocated = allocated;
            this.Total = total;
        }

        /// <summary>
        /// The number of shares allocated.
        /// </summary>
        [JsonProperty("allocated")]
        public int Allocated { get; set; }

        /// <summary>
        /// The total number of shares available.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Shares2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Shares2 other &&                this.Allocated.Equals(other.Allocated) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Allocated = {this.Allocated}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}
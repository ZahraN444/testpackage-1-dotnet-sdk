// <copyright file="Criteria.cs" company="APIMatic">
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
    /// Criteria.
    /// </summary>
    public class Criteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Criteria"/> class.
        /// </summary>
        public Criteria()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Criteria"/> class.
        /// </summary>
        /// <param name="expire">expire.</param>
        public Criteria(
            string expire = null)
        {
            this.Expire = expire;
        }

        /// <summary>
        /// A string signifying a duration of time. Valid time units are "ns", "us" (or "Âµs"), "ms", "s", "m", "h", "d", "w", "y".
        /// </summary>
        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public string Expire { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Criteria : ({string.Join(", ", toStringOutput)})";
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
            return obj is Criteria other &&                ((this.Expire == null && other.Expire == null) || (this.Expire?.Equals(other.Expire) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Expire = {(this.Expire == null ? "null" : this.Expire)}");
        }
    }
}
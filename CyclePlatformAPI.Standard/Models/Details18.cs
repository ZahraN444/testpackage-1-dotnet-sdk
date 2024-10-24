// <copyright file="Details18.cs" company="APIMatic">
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
    /// Details18.
    /// </summary>
    public class Details18
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details18"/> class.
        /// </summary>
        public Details18()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details18"/> class.
        /// </summary>
        /// <param name="requestsTotal">requests_total.</param>
        public Details18(
            int requestsTotal)
        {
            this.RequestsTotal = requestsTotal;
        }

        /// <summary>
        /// Gets or sets RequestsTotal.
        /// </summary>
        [JsonProperty("requests_total")]
        public int RequestsTotal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details18 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details18 other &&                this.RequestsTotal.Equals(other.RequestsTotal);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestsTotal = {this.RequestsTotal}");
        }
    }
}
// <copyright file="Shares.cs" company="APIMatic">
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
    /// Shares.
    /// </summary>
    public class Shares
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shares"/> class.
        /// </summary>
        public Shares()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shares"/> class.
        /// </summary>
        /// <param name="limit">limit.</param>
        /// <param name="reserve">reserve.</param>
        public Shares(
            int limit,
            int reserve)
        {
            this.Limit = limit;
            this.Reserve = reserve;
        }

        /// <summary>
        /// Gets or sets Limit.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets Reserve.
        /// </summary>
        [JsonProperty("reserve")]
        public int Reserve { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Shares : ({string.Join(", ", toStringOutput)})";
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
            return obj is Shares other &&                this.Limit.Equals(other.Limit) &&
                this.Reserve.Equals(other.Reserve);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Limit = {this.Limit}");
            toStringOutput.Add($"this.Reserve = {this.Reserve}");
        }
    }
}
// <copyright file="Shares1.cs" company="APIMatic">
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
    /// Shares1.
    /// </summary>
    public class Shares1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shares1"/> class.
        /// </summary>
        public Shares1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shares1"/> class.
        /// </summary>
        /// <param name="limit">limit.</param>
        /// <param name="reserve">reserve.</param>
        public Shares1(
            int limit,
            int reserve)
        {
            this.Limit = limit;
            this.Reserve = reserve;
        }

        /// <summary>
        /// The limit (maximum) amount of shares each instance of a container can use.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// The reserve (allocation) number of shares for each instance of a given container.
        /// </summary>
        [JsonProperty("reserve")]
        public int Reserve { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Shares1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Shares1 other &&                this.Limit.Equals(other.Limit) &&
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
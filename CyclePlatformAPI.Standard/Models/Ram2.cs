// <copyright file="Ram2.cs" company="APIMatic">
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
    /// Ram2.
    /// </summary>
    public class Ram2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ram2"/> class.
        /// </summary>
        public Ram2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ram2"/> class.
        /// </summary>
        /// <param name="limit">limit.</param>
        /// <param name="reserve">reserve.</param>
        public Ram2(
            string limit = null,
            string reserve = null)
        {
            this.Limit = limit;
            this.Reserve = reserve;
        }

        /// <summary>
        /// The limit (maximum) amount of RAM each instance of the given container can use.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// The reserve (allocation) of RAM given to each instance of the container.
        /// </summary>
        [JsonProperty("reserve", NullValueHandling = NullValueHandling.Ignore)]
        public string Reserve { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ram2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ram2 other &&                ((this.Limit == null && other.Limit == null) || (this.Limit?.Equals(other.Limit) == true)) &&
                ((this.Reserve == null && other.Reserve == null) || (this.Reserve?.Equals(other.Reserve) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Limit = {(this.Limit == null ? "null" : this.Limit)}");
            toStringOutput.Add($"this.Reserve = {(this.Reserve == null ? "null" : this.Reserve)}");
        }
    }
}
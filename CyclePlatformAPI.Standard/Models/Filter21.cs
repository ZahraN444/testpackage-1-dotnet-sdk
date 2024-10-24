// <copyright file="Filter21.cs" company="APIMatic">
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
    /// Filter21.
    /// </summary>
    public class Filter21
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter21"/> class.
        /// </summary>
        public Filter21()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter21"/> class.
        /// </summary>
        /// <param name="locationIds">location_ids.</param>
        public Filter21(
            string locationIds = null)
        {
            this.LocationIds = locationIds;
        }

        /// <summary>
        /// `filter[location_ids]=value` List only those provider servers matching this location. May return multiple results.
        /// </summary>
        [JsonProperty("location_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationIds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter21 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter21 other &&                ((this.LocationIds == null && other.LocationIds == null) || (this.LocationIds?.Equals(other.LocationIds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocationIds = {(this.LocationIds == null ? "null" : this.LocationIds)}");
        }
    }
}
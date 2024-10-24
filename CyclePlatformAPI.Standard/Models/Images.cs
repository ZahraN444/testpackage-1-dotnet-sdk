// <copyright file="Images.cs" company="APIMatic">
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
    /// Images.
    /// </summary>
    public class Images
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Images"/> class.
        /// </summary>
        public Images()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Images"/> class.
        /// </summary>
        /// <param name="tier">tier.</param>
        public Images(
            Models.Tier1 tier)
        {
            this.Tier = tier;
        }

        /// <summary>
        /// Image tier information.
        /// </summary>
        [JsonProperty("tier")]
        public Models.Tier1 Tier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Images : ({string.Join(", ", toStringOutput)})";
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
            return obj is Images other &&                ((this.Tier == null && other.Tier == null) || (this.Tier?.Equals(other.Tier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tier = {(this.Tier == null ? "null" : this.Tier.ToString())}");
        }
    }
}
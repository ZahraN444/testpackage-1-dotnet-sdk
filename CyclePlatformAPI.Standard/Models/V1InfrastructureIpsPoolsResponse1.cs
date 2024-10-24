// <copyright file="V1InfrastructureIpsPoolsResponse1.cs" company="APIMatic">
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
    /// V1InfrastructureIpsPoolsResponse1.
    /// </summary>
    public class V1InfrastructureIpsPoolsResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureIpsPoolsResponse1"/> class.
        /// </summary>
        public V1InfrastructureIpsPoolsResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureIpsPoolsResponse1"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="includes">includes.</param>
        public V1InfrastructureIpsPoolsResponse1(
            Models.InfrastructureIPPool data,
            Models.PoolIncludes includes = null)
        {
            this.Data = data;
            this.Includes = includes;
        }

        /// <summary>
        /// An IP Pool
        /// </summary>
        [JsonProperty("data")]
        public Models.InfrastructureIPPool Data { get; set; }

        /// <summary>
        /// Resources associated with an IP Pool.
        /// </summary>
        [JsonProperty("includes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PoolIncludes Includes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1InfrastructureIpsPoolsResponse1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1InfrastructureIpsPoolsResponse1 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Includes == null && other.Includes == null) || (this.Includes?.Equals(other.Includes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.Includes = {(this.Includes == null ? "null" : this.Includes.ToString())}");
        }
    }
}
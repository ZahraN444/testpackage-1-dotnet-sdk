// <copyright file="V1InfrastructureIpsPoolsIpsResponse.cs" company="APIMatic">
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
    /// V1InfrastructureIpsPoolsIpsResponse.
    /// </summary>
    public class V1InfrastructureIpsPoolsIpsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureIpsPoolsIpsResponse"/> class.
        /// </summary>
        public V1InfrastructureIpsPoolsIpsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureIpsPoolsIpsResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1InfrastructureIpsPoolsIpsResponse(
            List<Models.IP> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public List<Models.IP> Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1InfrastructureIpsPoolsIpsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1InfrastructureIpsPoolsIpsResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
        }
    }
}
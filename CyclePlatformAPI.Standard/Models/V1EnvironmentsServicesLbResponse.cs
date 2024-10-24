// <copyright file="V1EnvironmentsServicesLbResponse.cs" company="APIMatic">
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
    /// V1EnvironmentsServicesLbResponse.
    /// </summary>
    public class V1EnvironmentsServicesLbResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesLbResponse"/> class.
        /// </summary>
        public V1EnvironmentsServicesLbResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesLbResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1EnvironmentsServicesLbResponse(
            Models.Data2 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Information about an environments load balancer configuration, state, and availability settings.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data2 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsServicesLbResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsServicesLbResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}
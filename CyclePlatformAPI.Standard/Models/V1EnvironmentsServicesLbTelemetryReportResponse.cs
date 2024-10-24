// <copyright file="V1EnvironmentsServicesLbTelemetryReportResponse.cs" company="APIMatic">
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
    /// V1EnvironmentsServicesLbTelemetryReportResponse.
    /// </summary>
    public class V1EnvironmentsServicesLbTelemetryReportResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesLbTelemetryReportResponse"/> class.
        /// </summary>
        public V1EnvironmentsServicesLbTelemetryReportResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesLbTelemetryReportResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1EnvironmentsServicesLbTelemetryReportResponse(
            Models.LoadBalancerTelemetryReport data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Aggregated load balancer telemetry across all instances for a given range.
        /// </summary>
        [JsonProperty("data")]
        public Models.LoadBalancerTelemetryReport Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsServicesLbTelemetryReportResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsServicesLbTelemetryReportResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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
// <copyright file="V1EnvironmentsSummaryResponse.cs" company="APIMatic">
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
    /// V1EnvironmentsSummaryResponse.
    /// </summary>
    public class V1EnvironmentsSummaryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsSummaryResponse"/> class.
        /// </summary>
        public V1EnvironmentsSummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsSummaryResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1EnvironmentsSummaryResponse(
            Models.EnvironmentSummary data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Contains useful and relevant data/statistics for an environment that would otherwise be several separate API calls.
        /// </summary>
        [JsonProperty("data")]
        public Models.EnvironmentSummary Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsSummaryResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsSummaryResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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
// <copyright file="SupportPlanFeatures.cs" company="APIMatic">
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
    /// SupportPlanFeatures.
    /// </summary>
    public class SupportPlanFeatures
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportPlanFeatures"/> class.
        /// </summary>
        public SupportPlanFeatures()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportPlanFeatures"/> class.
        /// </summary>
        /// <param name="engineeringSupport">engineering_support.</param>
        /// <param name="uptimeSla">uptime_sla.</param>
        /// <param name="guaranteedResponseTime">guaranteed_response_time.</param>
        public SupportPlanFeatures(
            bool engineeringSupport,
            bool uptimeSla,
            string guaranteedResponseTime = null)
        {
            this.EngineeringSupport = engineeringSupport;
            this.UptimeSla = uptimeSla;
            this.GuaranteedResponseTime = guaranteedResponseTime;
        }

        /// <summary>
        /// A boolean where true indicates the contract includes support for engineering.
        /// </summary>
        [JsonProperty("engineering_support")]
        public bool EngineeringSupport { get; set; }

        /// <summary>
        /// A boolean where true represents the contract has an uptime SLA agreement.
        /// </summary>
        [JsonProperty("uptime_sla")]
        public bool UptimeSla { get; set; }

        /// <summary>
        /// The time in which this support contract guarantees response time.
        /// </summary>
        [JsonProperty("guaranteed_response_time", NullValueHandling = NullValueHandling.Include)]
        public string GuaranteedResponseTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SupportPlanFeatures : ({string.Join(", ", toStringOutput)})";
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
            return obj is SupportPlanFeatures other &&                this.EngineeringSupport.Equals(other.EngineeringSupport) &&
                this.UptimeSla.Equals(other.UptimeSla) &&
                ((this.GuaranteedResponseTime == null && other.GuaranteedResponseTime == null) || (this.GuaranteedResponseTime?.Equals(other.GuaranteedResponseTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EngineeringSupport = {this.EngineeringSupport}");
            toStringOutput.Add($"this.UptimeSla = {this.UptimeSla}");
            toStringOutput.Add($"this.GuaranteedResponseTime = {(this.GuaranteedResponseTime == null ? "null" : this.GuaranteedResponseTime)}");
        }
    }
}
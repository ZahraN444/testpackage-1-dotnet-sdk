// <copyright file="SecurityReportSummary.cs" company="APIMatic">
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
    /// SecurityReportSummary.
    /// </summary>
    public class SecurityReportSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityReportSummary"/> class.
        /// </summary>
        public SecurityReportSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityReportSummary"/> class.
        /// </summary>
        /// <param name="incidents">incidents.</param>
        public SecurityReportSummary(
            List<Models.SecurityIncident> incidents)
        {
            this.Incidents = incidents;
        }

        /// <summary>
        /// Gets or sets Incidents.
        /// </summary>
        [JsonProperty("incidents")]
        public List<Models.SecurityIncident> Incidents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecurityReportSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecurityReportSummary other &&                ((this.Incidents == null && other.Incidents == null) || (this.Incidents?.Equals(other.Incidents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Incidents = {(this.Incidents == null ? "null" : $"[{string.Join(", ", this.Incidents)} ]")}");
        }
    }
}
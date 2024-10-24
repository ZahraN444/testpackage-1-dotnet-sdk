// <copyright file="Incidents.cs" company="APIMatic">
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
    /// Incidents.
    /// </summary>
    public class Incidents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Incidents"/> class.
        /// </summary>
        public Incidents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Incidents"/> class.
        /// </summary>
        /// <param name="info">info.</param>
        /// <param name="low">low.</param>
        /// <param name="medium">medium.</param>
        /// <param name="high">high.</param>
        /// <param name="critical">critical.</param>
        public Incidents(
            Models.SecuritySnapshotIncidentBreakdown info = null,
            Models.SecuritySnapshotIncidentBreakdown low = null,
            Models.SecuritySnapshotIncidentBreakdown medium = null,
            Models.SecuritySnapshotIncidentBreakdown high = null,
            Models.SecuritySnapshotIncidentBreakdown critical = null)
        {
            this.Info = info;
            this.Low = low;
            this.Medium = medium;
            this.High = high;
            this.Critical = critical;
        }

        /// <summary>
        /// A breakdown of a snapshot's incidents inside a security report.
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SecuritySnapshotIncidentBreakdown Info { get; set; }

        /// <summary>
        /// A breakdown of a snapshot's incidents inside a security report.
        /// </summary>
        [JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SecuritySnapshotIncidentBreakdown Low { get; set; }

        /// <summary>
        /// A breakdown of a snapshot's incidents inside a security report.
        /// </summary>
        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SecuritySnapshotIncidentBreakdown Medium { get; set; }

        /// <summary>
        /// A breakdown of a snapshot's incidents inside a security report.
        /// </summary>
        [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SecuritySnapshotIncidentBreakdown High { get; set; }

        /// <summary>
        /// A breakdown of a snapshot's incidents inside a security report.
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SecuritySnapshotIncidentBreakdown Critical { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Incidents : ({string.Join(", ", toStringOutput)})";
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
            return obj is Incidents other &&                ((this.Info == null && other.Info == null) || (this.Info?.Equals(other.Info) == true)) &&
                ((this.Low == null && other.Low == null) || (this.Low?.Equals(other.Low) == true)) &&
                ((this.Medium == null && other.Medium == null) || (this.Medium?.Equals(other.Medium) == true)) &&
                ((this.High == null && other.High == null) || (this.High?.Equals(other.High) == true)) &&
                ((this.Critical == null && other.Critical == null) || (this.Critical?.Equals(other.Critical) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Info = {(this.Info == null ? "null" : this.Info.ToString())}");
            toStringOutput.Add($"this.Low = {(this.Low == null ? "null" : this.Low.ToString())}");
            toStringOutput.Add($"this.Medium = {(this.Medium == null ? "null" : this.Medium.ToString())}");
            toStringOutput.Add($"this.High = {(this.High == null ? "null" : this.High.ToString())}");
            toStringOutput.Add($"this.Critical = {(this.Critical == null ? "null" : this.Critical.ToString())}");
        }
    }
}
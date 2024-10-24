// <copyright file="SecurityReportSnapshot.cs" company="APIMatic">
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
    /// SecurityReportSnapshot.
    /// </summary>
    public class SecurityReportSnapshot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityReportSnapshot"/> class.
        /// </summary>
        public SecurityReportSnapshot()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityReportSnapshot"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="incidents">incidents.</param>
        /// <param name="count">count.</param>
        public SecurityReportSnapshot(
            DateTime time,
            Models.Incidents incidents,
            int count)
        {
            this.Time = time;
            this.Incidents = incidents;
            this.Count = count;
        }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets Incidents.
        /// </summary>
        [JsonProperty("incidents")]
        public Models.Incidents Incidents { get; set; }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecurityReportSnapshot : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecurityReportSnapshot other &&                this.Time.Equals(other.Time) &&
                ((this.Incidents == null && other.Incidents == null) || (this.Incidents?.Equals(other.Incidents) == true)) &&
                this.Count.Equals(other.Count);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Incidents = {(this.Incidents == null ? "null" : this.Incidents.ToString())}");
            toStringOutput.Add($"this.Count = {this.Count}");
        }
    }
}
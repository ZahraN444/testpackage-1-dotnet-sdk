// <copyright file="SecurityReport.cs" company="APIMatic">
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
    /// SecurityReport.
    /// </summary>
    public class SecurityReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityReport"/> class.
        /// </summary>
        public SecurityReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityReport"/> class.
        /// </summary>
        /// <param name="hubId">hub_id.</param>
        /// <param name="created">created.</param>
        /// <param name="range">range.</param>
        /// <param name="summary">summary.</param>
        /// <param name="snapshots">snapshots.</param>
        public SecurityReport(
            string hubId,
            DateTime created,
            Models.Range1 range,
            Models.SecurityReportSummary summary,
            List<Models.SecurityReportSnapshot> snapshots)
        {
            this.HubId = hubId;
            this.Created = created;
            this.Range = range;
            this.Summary = summary;
            this.Snapshots = snapshots;
        }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// Gets or sets Created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The period over which the report was generated.
        /// </summary>
        [JsonProperty("range")]
        public Models.Range1 Range { get; set; }

        /// <summary>
        /// A summary of the incidents tags accumulated over the report's range.
        /// </summary>
        [JsonProperty("summary")]
        public Models.SecurityReportSummary Summary { get; set; }

        /// <summary>
        /// The ID of the environment this instnace is in.
        /// </summary>
        [JsonProperty("snapshots")]
        public List<Models.SecurityReportSnapshot> Snapshots { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecurityReport : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecurityReport other &&                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                this.Created.Equals(other.Created) &&
                ((this.Range == null && other.Range == null) || (this.Range?.Equals(other.Range) == true)) &&
                ((this.Summary == null && other.Summary == null) || (this.Summary?.Equals(other.Summary) == true)) &&
                ((this.Snapshots == null && other.Snapshots == null) || (this.Snapshots?.Equals(other.Snapshots) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Range = {(this.Range == null ? "null" : this.Range.ToString())}");
            toStringOutput.Add($"this.Summary = {(this.Summary == null ? "null" : this.Summary.ToString())}");
            toStringOutput.Add($"this.Snapshots = {(this.Snapshots == null ? "null" : $"[{string.Join(", ", this.Snapshots)} ]")}");
        }
    }
}
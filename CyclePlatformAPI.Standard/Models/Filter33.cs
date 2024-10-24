// <copyright file="Filter33.cs" company="APIMatic">
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
    /// Filter33.
    /// </summary>
    public class Filter33
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter33"/> class.
        /// </summary>
        public Filter33()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter33"/> class.
        /// </summary>
        /// <param name="rangeStart">range-start.</param>
        /// <param name="rangeEnd">range-end.</param>
        /// <param name="environment">environment.</param>
        /// <param name="mEvent">event.</param>
        public Filter33(
            DateTime? rangeStart = null,
            DateTime? rangeEnd = null,
            string environment = null,
            string mEvent = null)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
            this.Environment = environment;
            this.MEvent = mEvent;
        }

        /// <summary>
        /// The start date from when to pull the security report
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeStart { get; set; }

        /// <summary>
        /// The end date from when to pull the security report
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeEnd { get; set; }

        /// <summary>
        /// <![CDATA[
        /// `filter[environment]=<Environment ID>` fetch the security report for the specified environment
        /// ]]>
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public string Environment { get; set; }

        /// <summary>
        /// `filter[event]=value` filter by event occurrence. Example: `filter[event]=environment.services.vpn.login`
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public string MEvent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter33 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter33 other &&                ((this.RangeStart == null && other.RangeStart == null) || (this.RangeStart?.Equals(other.RangeStart) == true)) &&
                ((this.RangeEnd == null && other.RangeEnd == null) || (this.RangeEnd?.Equals(other.RangeEnd) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.MEvent == null && other.MEvent == null) || (this.MEvent?.Equals(other.MEvent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RangeStart = {(this.RangeStart == null ? "null" : this.RangeStart.ToString())}");
            toStringOutput.Add($"this.RangeEnd = {(this.RangeEnd == null ? "null" : this.RangeEnd.ToString())}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"this.MEvent = {(this.MEvent == null ? "null" : this.MEvent)}");
        }
    }
}
// <copyright file="Throttling.cs" company="APIMatic">
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
    /// Throttling.
    /// </summary>
    public class Throttling
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Throttling"/> class.
        /// </summary>
        public Throttling()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Throttling"/> class.
        /// </summary>
        /// <param name="periods">periods.</param>
        /// <param name="throttledPeriods">throttled_periods.</param>
        /// <param name="throttledTime">throttled_time.</param>
        public Throttling(
            int? periods = null,
            int? throttledPeriods = null,
            int? throttledTime = null)
        {
            this.Periods = periods;
            this.ThrottledPeriods = throttledPeriods;
            this.ThrottledTime = throttledTime;
        }

        /// <summary>
        /// The amount of periods that have passed since the last restart.
        /// </summary>
        [JsonProperty("periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? Periods { get; set; }

        /// <summary>
        /// How many times the instance has been throttled for using all its alloted CPU during a period.
        /// </summary>
        [JsonProperty("throttled_periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThrottledPeriods { get; set; }

        /// <summary>
        /// The amount of time in nanoseconds this instnace has spent with throttled CPU resources.
        /// </summary>
        [JsonProperty("throttled_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThrottledTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Throttling : ({string.Join(", ", toStringOutput)})";
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
            return obj is Throttling other &&                ((this.Periods == null && other.Periods == null) || (this.Periods?.Equals(other.Periods) == true)) &&
                ((this.ThrottledPeriods == null && other.ThrottledPeriods == null) || (this.ThrottledPeriods?.Equals(other.ThrottledPeriods) == true)) &&
                ((this.ThrottledTime == null && other.ThrottledTime == null) || (this.ThrottledTime?.Equals(other.ThrottledTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Periods = {(this.Periods == null ? "null" : this.Periods.ToString())}");
            toStringOutput.Add($"this.ThrottledPeriods = {(this.ThrottledPeriods == null ? "null" : this.ThrottledPeriods.ToString())}");
            toStringOutput.Add($"this.ThrottledTime = {(this.ThrottledTime == null ? "null" : this.ThrottledTime.ToString())}");
        }
    }
}
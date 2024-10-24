// <copyright file="HugeTLB.cs" company="APIMatic">
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
    /// HugeTLB.
    /// </summary>
    public class HugeTLB
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HugeTLB"/> class.
        /// </summary>
        public HugeTLB()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HugeTLB"/> class.
        /// </summary>
        /// <param name="usage">usage.</param>
        /// <param name="max">max.</param>
        /// <param name="failCount">fail_count.</param>
        public HugeTLB(
            int? usage = null,
            int? max = null,
            int? failCount = null)
        {
            this.Usage = usage;
            this.Max = max;
            this.FailCount = failCount;
        }

        /// <summary>
        /// The number of bytes being consumed by huge pages of all sizes.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public int? Usage { get; set; }

        /// <summary>
        /// The maximum number of bytes allowed to be used for huge pages for this instance.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }

        /// <summary>
        /// The number of times the hugeTLB memory limit has been exceeded by this instance.
        /// </summary>
        [JsonProperty("fail_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HugeTLB : ({string.Join(", ", toStringOutput)})";
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
            return obj is HugeTLB other &&                ((this.Usage == null && other.Usage == null) || (this.Usage?.Equals(other.Usage) == true)) &&
                ((this.Max == null && other.Max == null) || (this.Max?.Equals(other.Max) == true)) &&
                ((this.FailCount == null && other.FailCount == null) || (this.FailCount?.Equals(other.FailCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
            toStringOutput.Add($"this.Max = {(this.Max == null ? "null" : this.Max.ToString())}");
            toStringOutput.Add($"this.FailCount = {(this.FailCount == null ? "null" : this.FailCount.ToString())}");
        }
    }
}
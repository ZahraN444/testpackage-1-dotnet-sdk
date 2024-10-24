// <copyright file="Range1.cs" company="APIMatic">
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
    /// Range1.
    /// </summary>
    public class Range1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Range1"/> class.
        /// </summary>
        public Range1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range1"/> class.
        /// </summary>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        public Range1(
            DateTime start,
            DateTime end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Gets or sets Start.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets End.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end")]
        public DateTime End { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Range1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Range1 other &&                this.Start.Equals(other.Start) &&
                this.End.Equals(other.End);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Start = {this.Start}");
            toStringOutput.Add($"this.End = {this.End}");
        }
    }
}
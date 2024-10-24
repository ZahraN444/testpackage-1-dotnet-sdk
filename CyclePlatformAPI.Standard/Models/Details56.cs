// <copyright file="Details56.cs" company="APIMatic">
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
    /// Details56.
    /// </summary>
    public class Details56
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details56"/> class.
        /// </summary>
        public Details56()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details56"/> class.
        /// </summary>
        /// <param name="duration">duration.</param>
        public Details56(
            string duration = null)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Total duration to run this step for, before moving on to the next step.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details56 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details56 other &&                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration)}");
        }
    }
}
// <copyright file="AutoScaleGroupScaleUp.cs" company="APIMatic">
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
    /// AutoScaleGroupScaleUp.
    /// </summary>
    public class AutoScaleGroupScaleUp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupScaleUp"/> class.
        /// </summary>
        public AutoScaleGroupScaleUp()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupScaleUp"/> class.
        /// </summary>
        /// <param name="maximum">maximum.</param>
        public AutoScaleGroupScaleUp(
            int? maximum = null)
        {
            this.Maximum = maximum;
        }

        /// <summary>
        /// Gets or sets Maximum.
        /// </summary>
        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
        public int? Maximum { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoScaleGroupScaleUp : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoScaleGroupScaleUp other &&                ((this.Maximum == null && other.Maximum == null) || (this.Maximum?.Equals(other.Maximum) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Maximum = {(this.Maximum == null ? "null" : this.Maximum.ToString())}");
        }
    }
}
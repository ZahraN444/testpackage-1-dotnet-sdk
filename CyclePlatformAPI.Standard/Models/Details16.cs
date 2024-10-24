// <copyright file="Details16.cs" company="APIMatic">
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
    /// Details16.
    /// </summary>
    public class Details16
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details16"/> class.
        /// </summary>
        public Details16()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details16"/> class.
        /// </summary>
        /// <param name="utilization">utilization.</param>
        public Details16(
            int utilization)
        {
            this.Utilization = utilization;
        }

        /// <summary>
        /// Gets or sets Utilization.
        /// </summary>
        [JsonProperty("utilization")]
        public int Utilization { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details16 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details16 other &&                this.Utilization.Equals(other.Utilization);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Utilization = {this.Utilization}");
        }
    }
}
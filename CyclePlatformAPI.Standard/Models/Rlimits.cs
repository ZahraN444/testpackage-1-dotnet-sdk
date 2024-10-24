// <copyright file="Rlimits.cs" company="APIMatic">
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
    /// Rlimits.
    /// </summary>
    public class Rlimits
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rlimits"/> class.
        /// </summary>
        public Rlimits()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rlimits"/> class.
        /// </summary>
        /// <param name="hard">hard.</param>
        /// <param name="soft">soft.</param>
        public Rlimits(
            int hard,
            int soft)
        {
            this.Hard = hard;
            this.Soft = soft;
        }

        /// <summary>
        /// Gets or sets Hard.
        /// </summary>
        [JsonProperty("hard")]
        public int Hard { get; set; }

        /// <summary>
        /// Gets or sets Soft.
        /// </summary>
        [JsonProperty("soft")]
        public int Soft { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Rlimits : ({string.Join(", ", toStringOutput)})";
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
            return obj is Rlimits other &&                this.Hard.Equals(other.Hard) &&
                this.Soft.Equals(other.Soft);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hard = {this.Hard}");
            toStringOutput.Add($"this.Soft = {this.Soft}");
        }
    }
}
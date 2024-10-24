// <copyright file="Rlimits1.cs" company="APIMatic">
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
    /// Rlimits1.
    /// </summary>
    public class Rlimits1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rlimits1"/> class.
        /// </summary>
        public Rlimits1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rlimits1"/> class.
        /// </summary>
        /// <param name="hard">hard.</param>
        /// <param name="soft">soft.</param>
        public Rlimits1(
            int? hard = null,
            int? soft = null)
        {
            this.Hard = hard;
            this.Soft = soft;
        }

        /// <summary>
        /// The hard limit for the rlimit.
        /// </summary>
        [JsonProperty("hard", NullValueHandling = NullValueHandling.Ignore)]
        public int? Hard { get; set; }

        /// <summary>
        /// The soft limit for the rlimit.
        /// </summary>
        [JsonProperty("soft", NullValueHandling = NullValueHandling.Ignore)]
        public int? Soft { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Rlimits1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Rlimits1 other &&                ((this.Hard == null && other.Hard == null) || (this.Hard?.Equals(other.Hard) == true)) &&
                ((this.Soft == null && other.Soft == null) || (this.Soft?.Equals(other.Soft) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hard = {(this.Hard == null ? "null" : this.Hard.ToString())}");
            toStringOutput.Add($"this.Soft = {(this.Soft == null ? "null" : this.Soft.ToString())}");
        }
    }
}
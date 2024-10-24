// <copyright file="Capabilities10.cs" company="APIMatic">
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
    /// Capabilities10.
    /// </summary>
    public class Capabilities10
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities10"/> class.
        /// </summary>
        public Capabilities10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities10"/> class.
        /// </summary>
        /// <param name="all">all.</param>
        /// <param name="specific">specific.</param>
        public Capabilities10(
            bool all,
            List<Models.CapabilityEnum> specific)
        {
            this.All = all;
            this.Specific = specific;
        }

        /// <summary>
        /// Gets or sets All.
        /// </summary>
        [JsonProperty("all")]
        public bool All { get; set; }

        /// <summary>
        /// Gets or sets Specific.
        /// </summary>
        [JsonProperty("specific")]
        public List<Models.CapabilityEnum> Specific { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Capabilities10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Capabilities10 other &&                this.All.Equals(other.All) &&
                ((this.Specific == null && other.Specific == null) || (this.Specific?.Equals(other.Specific) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.All = {this.All}");
            toStringOutput.Add($"this.Specific = {(this.Specific == null ? "null" : $"[{string.Join(", ", this.Specific)} ]")}");
        }
    }
}
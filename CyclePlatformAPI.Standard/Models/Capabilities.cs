// <copyright file="Capabilities.cs" company="APIMatic">
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
    /// Capabilities.
    /// </summary>
    public class Capabilities
    {
        private List<Models.CapabilityEnum> specific;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "specific", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities"/> class.
        /// </summary>
        public Capabilities()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Capabilities"/> class.
        /// </summary>
        /// <param name="all">all.</param>
        /// <param name="specific">specific.</param>
        public Capabilities(
            bool all,
            List<Models.CapabilityEnum> specific = null)
        {
            this.All = all;
            if (specific != null)
            {
                this.Specific = specific;
            }

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
        public List<Models.CapabilityEnum> Specific
        {
            get
            {
                return this.specific;
            }

            set
            {
                this.shouldSerialize["specific"] = true;
                this.specific = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Capabilities : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSpecific()
        {
            this.shouldSerialize["specific"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSpecific()
        {
            return this.shouldSerialize["specific"];
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
            return obj is Capabilities other &&                this.All.Equals(other.All) &&
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
// <copyright file="Extra.cs" company="APIMatic">
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
    /// Extra.
    /// </summary>
    public class Extra
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extra"/> class.
        /// </summary>
        public Extra()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extra"/> class.
        /// </summary>
        /// <param name="capability">capability.</param>
        public Extra(
            Models.Capability1Enum? capability = null)
        {
            this.Capability = capability;
        }

        /// <summary>
        /// If the error occured because of a lack of permission (403), this will list the specific capability that the Role/API Key is missing.
        /// </summary>
        [JsonProperty("capability", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Capability1Enum? Capability { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Extra : ({string.Join(", ", toStringOutput)})";
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
            return obj is Extra other &&                ((this.Capability == null && other.Capability == null) || (this.Capability?.Equals(other.Capability) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Capability = {(this.Capability == null ? "null" : this.Capability.ToString())}");
        }
    }
}
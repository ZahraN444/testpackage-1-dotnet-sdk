// <copyright file="Seccomp1.cs" company="APIMatic">
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
    /// Seccomp1.
    /// </summary>
    public class Seccomp1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Seccomp1"/> class.
        /// </summary>
        public Seccomp1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seccomp1"/> class.
        /// </summary>
        /// <param name="disable">disable.</param>
        /// <param name="rules">rules.</param>
        public Seccomp1(
            bool? disable = null,
            List<Models.SeccompRule> rules = null)
        {
            this.Disable = disable;
            this.Rules = rules;
        }

        /// <summary>
        /// Gets or sets Disable.
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// Gets or sets Rules.
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SeccompRule> Rules { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Seccomp1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Seccomp1 other &&                ((this.Disable == null && other.Disable == null) || (this.Disable?.Equals(other.Disable) == true)) &&
                ((this.Rules == null && other.Rules == null) || (this.Rules?.Equals(other.Rules) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Disable = {(this.Disable == null ? "null" : this.Disable.ToString())}");
            toStringOutput.Add($"this.Rules = {(this.Rules == null ? "null" : $"[{string.Join(", ", this.Rules)} ]")}");
        }
    }
}
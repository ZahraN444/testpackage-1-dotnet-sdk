// <copyright file="Rule.cs" company="APIMatic">
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
    /// Rule.
    /// </summary>
    public class Rule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule"/> class.
        /// </summary>
        public Rule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rule"/> class.
        /// </summary>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="syscall">syscall.</param>
        public Rule(
            Models.Capabilities3 capabilities,
            Models.Syscall syscall)
        {
            this.Capabilities = capabilities;
            this.Syscall = syscall;
        }

        /// <summary>
        /// Gets or sets Capabilities.
        /// </summary>
        [JsonProperty("capabilities")]
        public Models.Capabilities3 Capabilities { get; set; }

        /// <summary>
        /// Gets or sets Syscall.
        /// </summary>
        [JsonProperty("syscall")]
        public Models.Syscall Syscall { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Rule : ({string.Join(", ", toStringOutput)})";
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
            return obj is Rule other &&                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                ((this.Syscall == null && other.Syscall == null) || (this.Syscall?.Equals(other.Syscall) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : this.Capabilities.ToString())}");
            toStringOutput.Add($"this.Syscall = {(this.Syscall == null ? "null" : this.Syscall.ToString())}");
        }
    }
}
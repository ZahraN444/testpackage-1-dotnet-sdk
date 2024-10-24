// <copyright file="Resources.cs" company="APIMatic">
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
    /// Resources.
    /// </summary>
    public class Resources
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resources"/> class.
        /// </summary>
        public Resources()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resources"/> class.
        /// </summary>
        /// <param name="cpu">cpu.</param>
        /// <param name="ram">ram.</param>
        public Resources(
            Models.Cpu cpu = null,
            Models.Ram1 ram = null)
        {
            this.Cpu = cpu;
            this.Ram = ram;
        }

        /// <summary>
        /// Gets or sets Cpu.
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Cpu Cpu { get; set; }

        /// <summary>
        /// Gets or sets Ram.
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Ram1 Ram { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Resources : ({string.Join(", ", toStringOutput)})";
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
            return obj is Resources other &&                ((this.Cpu == null && other.Cpu == null) || (this.Cpu?.Equals(other.Cpu) == true)) &&
                ((this.Ram == null && other.Ram == null) || (this.Ram?.Equals(other.Ram) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cpu = {(this.Cpu == null ? "null" : this.Cpu.ToString())}");
            toStringOutput.Add($"this.Ram = {(this.Ram == null ? "null" : this.Ram.ToString())}");
        }
    }
}
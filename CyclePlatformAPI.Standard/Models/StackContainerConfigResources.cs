// <copyright file="StackContainerConfigResources.cs" company="APIMatic">
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
    /// StackContainerConfigResources.
    /// </summary>
    public class StackContainerConfigResources
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigResources"/> class.
        /// </summary>
        public StackContainerConfigResources()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigResources"/> class.
        /// </summary>
        /// <param name="cpu">cpu.</param>
        /// <param name="ram">ram.</param>
        public StackContainerConfigResources(
            Models.Cpu cpu,
            Models.Ram1 ram)
        {
            this.Cpu = cpu;
            this.Ram = ram;
        }

        /// <summary>
        /// Gets or sets Cpu.
        /// </summary>
        [JsonProperty("cpu")]
        [JsonRequired]
        public Models.Cpu Cpu { get; set; }

        /// <summary>
        /// Gets or sets Ram.
        /// </summary>
        [JsonProperty("ram")]
        [JsonRequired]
        public Models.Ram1 Ram { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackContainerConfigResources : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackContainerConfigResources other &&                ((this.Cpu == null && other.Cpu == null) || (this.Cpu?.Equals(other.Cpu) == true)) &&
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
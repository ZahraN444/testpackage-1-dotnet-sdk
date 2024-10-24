// <copyright file="InfrastructureResourceSummary1.cs" company="APIMatic">
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
    /// InfrastructureResourceSummary1.
    /// </summary>
    public class InfrastructureResourceSummary1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureResourceSummary1"/> class.
        /// </summary>
        public InfrastructureResourceSummary1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureResourceSummary1"/> class.
        /// </summary>
        /// <param name="ram">ram.</param>
        /// <param name="cpu">cpu.</param>
        public InfrastructureResourceSummary1(
            Models.Ram3 ram,
            Models.Cpu2 cpu)
        {
            this.Ram = ram;
            this.Cpu = cpu;
        }

        /// <summary>
        /// Information about RAM Resources.
        /// </summary>
        [JsonProperty("ram")]
        public Models.Ram3 Ram { get; set; }

        /// <summary>
        /// Information about CPU resources.
        /// </summary>
        [JsonProperty("cpu")]
        public Models.Cpu2 Cpu { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InfrastructureResourceSummary1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is InfrastructureResourceSummary1 other &&                ((this.Ram == null && other.Ram == null) || (this.Ram?.Equals(other.Ram) == true)) &&
                ((this.Cpu == null && other.Cpu == null) || (this.Cpu?.Equals(other.Cpu) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ram = {(this.Ram == null ? "null" : this.Ram.ToString())}");
            toStringOutput.Add($"this.Cpu = {(this.Cpu == null ? "null" : this.Cpu.ToString())}");
        }
    }
}
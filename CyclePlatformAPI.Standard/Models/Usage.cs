// <copyright file="Usage.cs" company="APIMatic">
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
    /// Usage.
    /// </summary>
    public class Usage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usage"/> class.
        /// </summary>
        public Usage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="perCore">per_core.</param>
        /// <param name="kernel">kernel.</param>
        /// <param name="user">user.</param>
        public Usage(
            int total,
            List<int> perCore,
            int kernel,
            double user)
        {
            this.Total = total;
            this.PerCore = perCore;
            this.Kernel = kernel;
            this.User = user;
        }

        /// <summary>
        /// Total amount of VPU time since last restart.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// An array showing CPU core specific usage in nanoseconds since the last restart.
        /// </summary>
        [JsonProperty("per_core")]
        public List<int> PerCore { get; set; }

        /// <summary>
        /// The amount of time in nanoseconds used by the kernel since last restart.
        /// </summary>
        [JsonProperty("kernel")]
        public int Kernel { get; set; }

        /// <summary>
        /// The amount of time in nanoseconds taken up for user processes.
        /// </summary>
        [JsonProperty("user")]
        public double User { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Usage : ({string.Join(", ", toStringOutput)})";
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
            return obj is Usage other &&                this.Total.Equals(other.Total) &&
                ((this.PerCore == null && other.PerCore == null) || (this.PerCore?.Equals(other.PerCore) == true)) &&
                this.Kernel.Equals(other.Kernel) &&
                this.User.Equals(other.User);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.PerCore = {(this.PerCore == null ? "null" : $"[{string.Join(", ", this.PerCore)} ]")}");
            toStringOutput.Add($"this.Kernel = {this.Kernel}");
            toStringOutput.Add($"this.User = {this.User}");
        }
    }
}
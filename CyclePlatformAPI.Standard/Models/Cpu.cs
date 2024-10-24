// <copyright file="Cpu.cs" company="APIMatic">
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
    /// Cpu.
    /// </summary>
    public class Cpu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cpu"/> class.
        /// </summary>
        public Cpu()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cpu"/> class.
        /// </summary>
        /// <param name="shares">shares.</param>
        /// <param name="cpus">cpus.</param>
        public Cpu(
            Models.Shares shares = null,
            string cpus = null)
        {
            this.Shares = shares;
            this.Cpus = cpus;
        }

        /// <summary>
        /// Gets or sets Shares.
        /// </summary>
        [JsonProperty("shares", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Shares Shares { get; set; }

        /// <summary>
        /// Gets or sets Cpus.
        /// </summary>
        [JsonProperty("cpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cpu : ({string.Join(", ", toStringOutput)})";
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
            return obj is Cpu other &&                ((this.Shares == null && other.Shares == null) || (this.Shares?.Equals(other.Shares) == true)) &&
                ((this.Cpus == null && other.Cpus == null) || (this.Cpus?.Equals(other.Cpus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Shares = {(this.Shares == null ? "null" : this.Shares.ToString())}");
            toStringOutput.Add($"this.Cpus = {(this.Cpus == null ? "null" : this.Cpus)}");
        }
    }
}
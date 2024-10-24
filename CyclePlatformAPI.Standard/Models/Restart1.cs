// <copyright file="Restart1.cs" company="APIMatic">
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
    /// Restart1.
    /// </summary>
    public class Restart1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Restart1"/> class.
        /// </summary>
        public Restart1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Restart1"/> class.
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <param name="delay">delay.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        public Restart1(
            Models.Condition1Enum condition,
            string delay,
            int maxAttempts)
        {
            this.Condition = condition;
            this.Delay = delay;
            this.MaxAttempts = maxAttempts;
        }

        /// <summary>
        /// Policy for what should happen in the event of a container dying.
        /// </summary>
        [JsonProperty("condition")]
        public Models.Condition1Enum Condition { get; set; }

        /// <summary>
        /// How long the platform will wait before trying to restart the container.
        /// </summary>
        [JsonProperty("delay")]
        public string Delay { get; set; }

        /// <summary>
        /// The amount of times the platform will attempt the restart policies.
        /// </summary>
        [JsonProperty("max_attempts")]
        public int MaxAttempts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Restart1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Restart1 other &&                this.Condition.Equals(other.Condition) &&
                ((this.Delay == null && other.Delay == null) || (this.Delay?.Equals(other.Delay) == true)) &&
                this.MaxAttempts.Equals(other.MaxAttempts);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Condition = {this.Condition}");
            toStringOutput.Add($"this.Delay = {(this.Delay == null ? "null" : this.Delay)}");
            toStringOutput.Add($"this.MaxAttempts = {this.MaxAttempts}");
        }
    }
}
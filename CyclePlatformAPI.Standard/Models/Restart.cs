// <copyright file="Restart.cs" company="APIMatic">
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
    /// Restart.
    /// </summary>
    public class Restart
    {
        private Models.Notify notify;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "notify", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Restart"/> class.
        /// </summary>
        public Restart()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Restart"/> class.
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <param name="delay">delay.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="notify">notify.</param>
        public Restart(
            Models.ConditionEnum condition,
            string delay,
            int maxAttempts,
            Models.Notify notify = null)
        {
            this.Condition = condition;
            this.Delay = delay;
            this.MaxAttempts = maxAttempts;
            if (notify != null)
            {
                this.Notify = notify;
            }

        }

        /// <summary>
        /// Gets or sets Condition.
        /// </summary>
        [JsonProperty("condition")]
        public Models.ConditionEnum Condition { get; set; }

        /// <summary>
        /// How long the platform will wait before trying to restart the container.
        /// </summary>
        [JsonProperty("delay")]
        public string Delay { get; set; }

        /// <summary>
        /// Gets or sets MaxAttempts.
        /// </summary>
        [JsonProperty("max_attempts")]
        public int MaxAttempts { get; set; }

        /// <summary>
        /// Gets or sets Notify.
        /// </summary>
        [JsonProperty("notify")]
        public Models.Notify Notify
        {
            get
            {
                return this.notify;
            }

            set
            {
                this.shouldSerialize["notify"] = true;
                this.notify = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Restart : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNotify()
        {
            this.shouldSerialize["notify"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotify()
        {
            return this.shouldSerialize["notify"];
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
            return obj is Restart other &&                this.Condition.Equals(other.Condition) &&
                ((this.Delay == null && other.Delay == null) || (this.Delay?.Equals(other.Delay) == true)) &&
                this.MaxAttempts.Equals(other.MaxAttempts) &&
                ((this.Notify == null && other.Notify == null) || (this.Notify?.Equals(other.Notify) == true));
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
            toStringOutput.Add($"this.Notify = {(this.Notify == null ? "null" : this.Notify.ToString())}");
        }
    }
}
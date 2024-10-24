// <copyright file="Options30.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Options30.
    /// </summary>
    public class Options30
    {
        private int? maxAttempts;
        private Models.FailOn failOn;
        private Models.RetryOn retryOn;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "max_attempts", false },
            { "fail_on", false },
            { "retry_on", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Options30"/> class.
        /// </summary>
        public Options30()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Options30"/> class.
        /// </summary>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="interval">interval.</param>
        /// <param name="failOn">fail_on.</param>
        /// <param name="retryOn">retry_on.</param>
        public Options30(
            int? maxAttempts = null,
            Options30Interval interval = null,
            Models.FailOn failOn = null,
            Models.RetryOn retryOn = null)
        {
            if (maxAttempts != null)
            {
                this.MaxAttempts = maxAttempts;
            }

            this.Interval = interval;
            if (failOn != null)
            {
                this.FailOn = failOn;
            }

            if (retryOn != null)
            {
                this.RetryOn = retryOn;
            }

        }

        /// <summary>
        /// Gets or sets MaxAttempts.
        /// </summary>
        [JsonProperty("max_attempts")]
        public int? MaxAttempts
        {
            get
            {
                return this.maxAttempts;
            }

            set
            {
                this.shouldSerialize["max_attempts"] = true;
                this.maxAttempts = value;
            }
        }

        /// <summary>
        /// How long to wait between retries on wait.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public Options30Interval Interval { get; set; }

        /// <summary>
        /// Gets or sets FailOn.
        /// </summary>
        [JsonProperty("fail_on")]
        public Models.FailOn FailOn
        {
            get
            {
                return this.failOn;
            }

            set
            {
                this.shouldSerialize["fail_on"] = true;
                this.failOn = value;
            }
        }

        /// <summary>
        /// Gets or sets RetryOn.
        /// </summary>
        [JsonProperty("retry_on")]
        public Models.RetryOn RetryOn
        {
            get
            {
                return this.retryOn;
            }

            set
            {
                this.shouldSerialize["retry_on"] = true;
                this.retryOn = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Options30 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMaxAttempts()
        {
            this.shouldSerialize["max_attempts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFailOn()
        {
            this.shouldSerialize["fail_on"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRetryOn()
        {
            this.shouldSerialize["retry_on"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxAttempts()
        {
            return this.shouldSerialize["max_attempts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFailOn()
        {
            return this.shouldSerialize["fail_on"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRetryOn()
        {
            return this.shouldSerialize["retry_on"];
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
            return obj is Options30 other &&                ((this.MaxAttempts == null && other.MaxAttempts == null) || (this.MaxAttempts?.Equals(other.MaxAttempts) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.FailOn == null && other.FailOn == null) || (this.FailOn?.Equals(other.FailOn) == true)) &&
                ((this.RetryOn == null && other.RetryOn == null) || (this.RetryOn?.Equals(other.RetryOn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MaxAttempts = {(this.MaxAttempts == null ? "null" : this.MaxAttempts.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.FailOn = {(this.FailOn == null ? "null" : this.FailOn.ToString())}");
            toStringOutput.Add($"this.RetryOn = {(this.RetryOn == null ? "null" : this.RetryOn.ToString())}");
        }
    }
}
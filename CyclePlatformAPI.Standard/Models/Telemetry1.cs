// <copyright file="Telemetry1.cs" company="APIMatic">
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
    /// Telemetry1.
    /// </summary>
    public class Telemetry1
    {
        private string webHook;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "web_hook", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Telemetry1"/> class.
        /// </summary>
        public Telemetry1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Telemetry1"/> class.
        /// </summary>
        /// <param name="disable">disable.</param>
        /// <param name="retention">retention.</param>
        /// <param name="interval">interval.</param>
        /// <param name="webHook">web_hook.</param>
        public Telemetry1(
            bool disable,
            Telemetry1Retention retention = null,
            Telemetry1Interval interval = null,
            string webHook = null)
        {
            this.Retention = retention;
            this.Interval = interval;
            if (webHook != null)
            {
                this.WebHook = webHook;
            }

            this.Disable = disable;
        }

        /// <summary>
        /// How long telemetry data should be retained.
        /// </summary>
        [JsonProperty("retention", NullValueHandling = NullValueHandling.Ignore)]
        public Telemetry1Retention Retention { get; set; }

        /// <summary>
        /// The duration between samples.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public Telemetry1Interval Interval { get; set; }

        /// <summary>
        /// A URL where Cycle will send telemetry data to.
        /// </summary>
        [JsonProperty("web_hook")]
        public string WebHook
        {
            get
            {
                return this.webHook;
            }

            set
            {
                this.shouldSerialize["web_hook"] = true;
                this.webHook = value;
            }
        }

        /// <summary>
        /// Gets or sets Disable.
        /// </summary>
        [JsonProperty("disable")]
        public bool Disable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Telemetry1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWebHook()
        {
            this.shouldSerialize["web_hook"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWebHook()
        {
            return this.shouldSerialize["web_hook"];
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
            return obj is Telemetry1 other &&                ((this.Retention == null && other.Retention == null) || (this.Retention?.Equals(other.Retention) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.WebHook == null && other.WebHook == null) || (this.WebHook?.Equals(other.WebHook) == true)) &&
                this.Disable.Equals(other.Disable);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Retention = {(this.Retention == null ? "null" : this.Retention.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.WebHook = {(this.WebHook == null ? "null" : this.WebHook)}");
            toStringOutput.Add($"this.Disable = {this.Disable}");
        }
    }
}
// <copyright file="Telemetry2.cs" company="APIMatic">
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
    /// Telemetry2.
    /// </summary>
    public class Telemetry2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Telemetry2"/> class.
        /// </summary>
        public Telemetry2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Telemetry2"/> class.
        /// </summary>
        /// <param name="retention">retention.</param>
        /// <param name="interval">interval.</param>
        /// <param name="disable">disable.</param>
        /// <param name="webHook">web_hook.</param>
        public Telemetry2(
            string retention,
            string interval,
            bool disable,
            string webHook = null)
        {
            this.Retention = retention;
            this.Interval = interval;
            this.Disable = disable;
            this.WebHook = webHook;
        }

        /// <summary>
        /// How long telemetry data should be retained.
        /// </summary>
        [JsonProperty("retention")]
        public string Retention { get; set; }

        /// <summary>
        /// The duration between samples.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// A boolean where true disables all telemetry reporting for this container.
        /// </summary>
        [JsonProperty("disable")]
        public bool Disable { get; set; }

        /// <summary>
        /// An endpoint to report the telemetry data to.
        /// </summary>
        [JsonProperty("web_hook", NullValueHandling = NullValueHandling.Ignore)]
        public string WebHook { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Telemetry2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Telemetry2 other &&                ((this.Retention == null && other.Retention == null) || (this.Retention?.Equals(other.Retention) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                this.Disable.Equals(other.Disable) &&
                ((this.WebHook == null && other.WebHook == null) || (this.WebHook?.Equals(other.WebHook) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Retention = {(this.Retention == null ? "null" : this.Retention)}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval)}");
            toStringOutput.Add($"this.Disable = {this.Disable}");
            toStringOutput.Add($"this.WebHook = {(this.WebHook == null ? "null" : this.WebHook)}");
        }
    }
}
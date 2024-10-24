// <copyright file="Health.cs" company="APIMatic">
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
    /// Health.
    /// </summary>
    public class Health
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Health"/> class.
        /// </summary>
        public Health()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Health"/> class.
        /// </summary>
        /// <param name="updated">updated.</param>
        /// <param name="healthy">healthy.</param>
        public Health(
            DateTime updated,
            bool? healthy = null)
        {
            this.Healthy = healthy;
            this.Updated = updated;
        }

        /// <summary>
        /// Describes the healthiness of the instance. Health checks can be configured at the container level.
        /// - `true`: The instance is considered healthy.
        /// - `false`: The instance is considered unhealthy.
        /// - `null`: The instance has not yet reported its health, or a health check has not yet been performed.
        /// </summary>
        [JsonProperty("healthy", NullValueHandling = NullValueHandling.Include)]
        public bool? Healthy { get; set; }

        /// <summary>
        /// A timestamp of the last time the instance health was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Health : ({string.Join(", ", toStringOutput)})";
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
            return obj is Health other &&                ((this.Healthy == null && other.Healthy == null) || (this.Healthy?.Equals(other.Healthy) == true)) &&
                this.Updated.Equals(other.Updated);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Healthy = {(this.Healthy == null ? "null" : this.Healthy.ToString())}");
            toStringOutput.Add($"this.Updated = {this.Updated}");
        }
    }
}
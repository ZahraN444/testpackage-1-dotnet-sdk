// <copyright file="Webhooks1.cs" company="APIMatic">
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
    /// Webhooks1.
    /// </summary>
    public class Webhooks1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhooks1"/> class.
        /// </summary>
        public Webhooks1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhooks1"/> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="config">config.</param>
        public Webhooks1(
            Models.Events2 events = null,
            string config = null)
        {
            this.Events = events;
            this.Config = config;
        }

        /// <summary>
        /// Container events that can be configured to report to a webhook.
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Events2 Events { get; set; }

        /// <summary>
        /// An endpoint that the platform will react out to with a get request.  This endpoint serves a partial container config which can modify `runtime`, `resources`, and `integrations` configurations.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public string Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Webhooks1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Webhooks1 other &&                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config)}");
        }
    }
}
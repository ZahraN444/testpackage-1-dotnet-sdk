// <copyright file="Webhooks.cs" company="APIMatic">
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
    /// Webhooks.
    /// </summary>
    public class Webhooks
    {
        private Models.Events1 events;
        private string config;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "events", false },
            { "config", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhooks"/> class.
        /// </summary>
        public Webhooks()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhooks"/> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="config">config.</param>
        public Webhooks(
            Models.Events1 events = null,
            string config = null)
        {
            if (events != null)
            {
                this.Events = events;
            }

            if (config != null)
            {
                this.Config = config;
            }

        }

        /// <summary>
        /// Gets or sets Events.
        /// </summary>
        [JsonProperty("events")]
        public Models.Events1 Events
        {
            get
            {
                return this.events;
            }

            set
            {
                this.shouldSerialize["events"] = true;
                this.events = value;
            }
        }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config")]
        public string Config
        {
            get
            {
                return this.config;
            }

            set
            {
                this.shouldSerialize["config"] = true;
                this.config = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Webhooks : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEvents()
        {
            this.shouldSerialize["events"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetConfig()
        {
            this.shouldSerialize["config"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEvents()
        {
            return this.shouldSerialize["events"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConfig()
        {
            return this.shouldSerialize["config"];
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
            return obj is Webhooks other &&                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
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
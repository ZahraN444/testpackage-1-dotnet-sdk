// <copyright file="Contents9.cs" company="APIMatic">
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
    /// Contents9.
    /// </summary>
    public class Contents9
    {
        private bool? highAvailability;
        private bool? autoUpdate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "high_availability", false },
            { "auto_update", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents9"/> class.
        /// </summary>
        public Contents9()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents9"/> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="highAvailability">high_availability.</param>
        /// <param name="autoUpdate">auto_update.</param>
        public Contents9(
            Contents9Config config = null,
            bool? highAvailability = null,
            bool? autoUpdate = null)
        {
            this.Config = config;
            if (highAvailability != null)
            {
                this.HighAvailability = highAvailability;
            }

            if (autoUpdate != null)
            {
                this.AutoUpdate = autoUpdate;
            }

        }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Contents9Config Config { get; set; }

        /// <summary>
        /// A boolean where `true` represents the desire to run the environment discovery service in high availability mode.
        /// </summary>
        [JsonProperty("high_availability")]
        public bool? HighAvailability
        {
            get
            {
                return this.highAvailability;
            }

            set
            {
                this.shouldSerialize["high_availability"] = true;
                this.highAvailability = value;
            }
        }

        /// <summary>
        /// A boolean where `true` represents the desire to automatically update the environment discovery service.
        /// </summary>
        [JsonProperty("auto_update")]
        public bool? AutoUpdate
        {
            get
            {
                return this.autoUpdate;
            }

            set
            {
                this.shouldSerialize["auto_update"] = true;
                this.autoUpdate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents9 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHighAvailability()
        {
            this.shouldSerialize["high_availability"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAutoUpdate()
        {
            this.shouldSerialize["auto_update"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHighAvailability()
        {
            return this.shouldSerialize["high_availability"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutoUpdate()
        {
            return this.shouldSerialize["auto_update"];
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
            return obj is Contents9 other &&                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.HighAvailability == null && other.HighAvailability == null) || (this.HighAvailability?.Equals(other.HighAvailability) == true)) &&
                ((this.AutoUpdate == null && other.AutoUpdate == null) || (this.AutoUpdate?.Equals(other.AutoUpdate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.HighAvailability = {(this.HighAvailability == null ? "null" : this.HighAvailability.ToString())}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
        }
    }
}
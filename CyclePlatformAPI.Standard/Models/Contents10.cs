// <copyright file="Contents10.cs" company="APIMatic">
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
    /// Contents10.
    /// </summary>
    public class Contents10
    {
        private bool? autoUpdate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "auto_update", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents10"/> class.
        /// </summary>
        public Contents10()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents10"/> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="autoUpdate">auto_update.</param>
        public Contents10(
            Contents10Config config = null,
            bool? autoUpdate = null)
        {
            this.Config = config;
            if (autoUpdate != null)
            {
                this.AutoUpdate = autoUpdate;
            }

        }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Contents10Config Config { get; set; }

        /// <summary>
        /// A boolean where `true` represents the desire to automatically update the environment scheduler service.
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

            return $"Contents10 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents10 other &&                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.AutoUpdate == null && other.AutoUpdate == null) || (this.AutoUpdate?.Equals(other.AutoUpdate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.AutoUpdate = {(this.AutoUpdate == null ? "null" : this.AutoUpdate.ToString())}");
        }
    }
}
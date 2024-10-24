// <copyright file="Data2.cs" company="APIMatic">
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
    /// Data2.
    /// </summary>
    public class Data2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data2"/> class.
        /// </summary>
        public Data2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data2"/> class.
        /// </summary>
        /// <param name="defaultConfig">default_config.</param>
        /// <param name="defaultType">default_type.</param>
        /// <param name="service">service.</param>
        /// <param name="baseConfigs">base_configs.</param>
        public Data2(
            Data2DefaultConfig defaultConfig,
            Models.DefaultTypeEnum defaultType,
            Data2Service service,
            Models.BaseConfigs baseConfigs = null)
        {
            this.DefaultConfig = defaultConfig;
            this.DefaultType = defaultType;
            this.BaseConfigs = baseConfigs;
            this.Service = service;
        }

        /// <summary>
        /// Gets or sets DefaultConfig.
        /// </summary>
        [JsonProperty("default_config")]
        public Data2DefaultConfig DefaultConfig { get; set; }

        /// <summary>
        /// Gets or sets DefaultType.
        /// </summary>
        [JsonProperty("default_type")]
        public Models.DefaultTypeEnum DefaultType { get; set; }

        /// <summary>
        /// Gets or sets BaseConfigs.
        /// </summary>
        [JsonProperty("base_configs", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BaseConfigs BaseConfigs { get; set; }

        /// <summary>
        /// Gets or sets Service.
        /// </summary>
        [JsonProperty("service")]
        public Data2Service Service { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data2 other &&                ((this.DefaultConfig == null && other.DefaultConfig == null) || (this.DefaultConfig?.Equals(other.DefaultConfig) == true)) &&
                this.DefaultType.Equals(other.DefaultType) &&
                ((this.BaseConfigs == null && other.BaseConfigs == null) || (this.BaseConfigs?.Equals(other.BaseConfigs) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DefaultConfig = {(this.DefaultConfig == null ? "null" : this.DefaultConfig.ToString())}");
            toStringOutput.Add($"this.DefaultType = {this.DefaultType}");
            toStringOutput.Add($"this.BaseConfigs = {(this.BaseConfigs == null ? "null" : this.BaseConfigs.ToString())}");
            toStringOutput.Add($"Service = {(this.Service == null ? "null" : this.Service.ToString())}");
        }
    }
}
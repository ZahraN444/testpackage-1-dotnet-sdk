// <copyright file="Surface2.cs" company="APIMatic">
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
    /// Surface2.
    /// </summary>
    public class Surface2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Surface2"/> class.
        /// </summary>
        public Surface2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Surface2"/> class.
        /// </summary>
        /// <param name="network">network.</param>
        /// <param name="service">service.</param>
        /// <param name="fs">fs.</param>
        /// <param name="api">api.</param>
        public Surface2(
            int? network = null,
            int? service = null,
            int? fs = null,
            int? api = null)
        {
            this.Network = network;
            this.Service = service;
            this.Fs = fs;
            this.Api = api;
        }

        /// <summary>
        /// Gets or sets Network.
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public int? Network { get; set; }

        /// <summary>
        /// Gets or sets Service.
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public int? Service { get; set; }

        /// <summary>
        /// Gets or sets Fs.
        /// </summary>
        [JsonProperty("fs", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fs { get; set; }

        /// <summary>
        /// Gets or sets Api.
        /// </summary>
        [JsonProperty("api", NullValueHandling = NullValueHandling.Ignore)]
        public int? Api { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Surface2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Surface2 other &&                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true)) &&
                ((this.Fs == null && other.Fs == null) || (this.Fs?.Equals(other.Fs) == true)) &&
                ((this.Api == null && other.Api == null) || (this.Api?.Equals(other.Api) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network.ToString())}");
            toStringOutput.Add($"this.Service = {(this.Service == null ? "null" : this.Service.ToString())}");
            toStringOutput.Add($"this.Fs = {(this.Fs == null ? "null" : this.Fs.ToString())}");
            toStringOutput.Add($"this.Api = {(this.Api == null ? "null" : this.Api.ToString())}");
        }
    }
}